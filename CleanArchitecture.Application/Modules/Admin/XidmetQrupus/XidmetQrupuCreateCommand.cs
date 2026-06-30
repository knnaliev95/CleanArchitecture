using CleanArchitecture.Domain.Modules.Admin.XidmetQrupus;
using FluentValidation;
using GenericRepository;
using Mapster;
using MediatR;
using TS.Result;

namespace CleanArchitecture.Application.Modules.Admin.XidmetQrupus
{
    public sealed record XidmetQrupuCreateCommand(string Ad, bool IsDeleted) : IRequest<Result<XidmetQrupuGetAllQueryResponse>>;

    public sealed class XidmetQrupuCreateCommandValidator : AbstractValidator<XidmetQrupuCreateCommand>
    {
        public XidmetQrupuCreateCommandValidator() => RuleFor(x => x.Ad).NotEmpty();
    }

    public sealed class XidmetQrupuCreateCommandHandler
        (IXidmetQrupuRepository repository, IUnitOfWork unitOfWork) : IRequestHandler<XidmetQrupuCreateCommand, Result<XidmetQrupuGetAllQueryResponse>>
    {
        public async Task<Result<XidmetQrupuGetAllQueryResponse>> Handle(XidmetQrupuCreateCommand request, CancellationToken cancellationToken)
        {
            var exists = await repository.AnyAsync(x => x.Ad == request.Ad, cancellationToken);
            if (exists) return Result<XidmetQrupuGetAllQueryResponse>.Failure("Bu adda mövcuddur");

            var entity = request.Adapt<XidmetQrupu>();
            entity.IsDeleted = request.IsDeleted;
            repository.Add(entity);
            await unitOfWork.SaveChangesAsync(cancellationToken);

            var response = new XidmetQrupuGetAllQueryResponse
            {
                Id = entity.Id,
                Ad = entity.Ad,
                IsDeleted = entity.IsDeleted,
                CreateUserName = entity.CreateUser != null ? entity.CreateUser.UserName : "none",
                CreatedDate = entity.CreatedDate,
                UpdateUserName = entity.UpdateUser != null ? entity.UpdateUser.UserName : "none",
                UpdatedDate = entity.UpdatedDate,
                DeletedUserName = entity.DeleteUser != null ? entity.DeleteUser.UserName : "none",
                DeletedDate = entity.DeletedDate
            };

            return response;
        }
    }
}

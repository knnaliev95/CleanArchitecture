using CleanArchitecture.Domain.Modules.Admin.XidmetQrupus;
using FluentValidation;
using GenericRepository;
using Mapster;
using MediatR;
using TS.Result;

namespace CleanArchitecture.Application.Modules.Admin.XidmetQrupus
{
    public sealed record XidmetQrupuUpdateCommand(int Id, string Ad) : IRequest<Result<XidmetQrupuGetAllQueryResponse>>;

    public sealed class XidmetQrupuUpdateCommandValidator : AbstractValidator<XidmetQrupuUpdateCommand>
    {
        public XidmetQrupuUpdateCommandValidator()
        {
            RuleFor(x => x.Id).GreaterThan(0);
            RuleFor(x => x.Ad).NotEmpty();
        }
    }

    internal sealed class XidmetQrupuUpdateCommandHandler
        (IXidmetQrupuRepository repository, IUnitOfWork unitOfWork) : IRequestHandler<XidmetQrupuUpdateCommand, Result<XidmetQrupuGetAllQueryResponse>>
    {
        public async Task<Result<XidmetQrupuGetAllQueryResponse>> Handle(XidmetQrupuUpdateCommand request, CancellationToken cancellationToken)
        {
            var entity = await repository.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
            if (entity is null) return Result<XidmetQrupuGetAllQueryResponse>.Failure("Tapılmadı");

            request.Adapt(entity);

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

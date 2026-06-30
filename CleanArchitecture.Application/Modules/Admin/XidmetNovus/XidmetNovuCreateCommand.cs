using CleanArchitecture.Domain.Modules.Admin.XidmetNovus;
using FluentValidation;
using GenericRepository;
using Mapster;
using MediatR;
using TS.Result;

namespace CleanArchitecture.Application.Modules.Admin.XidmetNovus
{
    public sealed record XidmetNovuCreateCommand(string Ad, bool IsDeleted) : IRequest<Result<XidmetNovuGetAllQueryResponse>>;

    public sealed class XidmetNovuCreateCommandValidator : AbstractValidator<XidmetNovuCreateCommand>
    {
        public XidmetNovuCreateCommandValidator() => RuleFor(x => x.Ad).NotEmpty();
    }

    public sealed class XidmetNovuCreateCommandHandler
        (IXidmetNovuRepository repository, IUnitOfWork unitOfWork) : IRequestHandler<XidmetNovuCreateCommand, Result<XidmetNovuGetAllQueryResponse>>
    {
        public async Task<Result<XidmetNovuGetAllQueryResponse>> Handle(XidmetNovuCreateCommand request, CancellationToken cancellationToken)
        {
            var exists = await repository.AnyAsync(x => x.Ad == request.Ad, cancellationToken);
            if (exists) return Result<XidmetNovuGetAllQueryResponse>.Failure("Bu adda mövcutdur");

            var entity = request.Adapt<XidmetNovu>();
            entity.IsDeleted = request.IsDeleted;
            repository.Add(entity);
            await unitOfWork.SaveChangesAsync(cancellationToken);

            var response = new XidmetNovuGetAllQueryResponse
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

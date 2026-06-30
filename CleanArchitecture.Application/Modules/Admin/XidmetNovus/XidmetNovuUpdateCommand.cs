using CleanArchitecture.Domain.Modules.Admin.XidmetNovus;
using FluentValidation;
using GenericRepository;
using Mapster;
using MediatR;
using TS.Result;

namespace CleanArchitecture.Application.Modules.Admin.XidmetNovus
{
    public sealed record XidmetNovuUpdateCommand(int Id, string Ad) : IRequest<Result<XidmetNovuGetAllQueryResponse>>;

    public sealed class XidmetNovuUpdateCommandValidator : AbstractValidator<XidmetNovuUpdateCommand>
    {
        public XidmetNovuUpdateCommandValidator()
        {
            RuleFor(x => x.Id).GreaterThan(0);
            RuleFor(x => x.Ad).NotEmpty();
        }
    }

    internal sealed class XidmetNovuUpdateCommandHandler
        (IXidmetNovuRepository repository, IUnitOfWork unitOfWork) : IRequestHandler<XidmetNovuUpdateCommand, Result<XidmetNovuGetAllQueryResponse>>
    {
        public async Task<Result<XidmetNovuGetAllQueryResponse>> Handle(XidmetNovuUpdateCommand request, CancellationToken cancellationToken)
        {
            var entity = await repository.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
            if (entity is null) return Result<XidmetNovuGetAllQueryResponse>.Failure("Tapılmadı");

            request.Adapt(entity);

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

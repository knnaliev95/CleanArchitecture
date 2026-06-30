using CleanArchitecture.Domain.Modules.Admin.EndirimTipis;
using FluentValidation;
using GenericRepository;
using Mapster;
using MediatR;
using TS.Result;

namespace CleanArchitecture.Application.Modules.Admin.EndirimTipis
{
    public sealed record EndirimTipiUpdateCommand(int Id, string Ad) : IRequest<Result<EndirimTipiGetAllQueryResponse>>;

    public sealed class EndirimTipiUpdateCommandValidator : AbstractValidator<EndirimTipiUpdateCommand>
    {
        public EndirimTipiUpdateCommandValidator()
        {
            RuleFor(x => x.Id).GreaterThan(0);
            RuleFor(x => x.Ad).NotEmpty();
        }
    }

    internal sealed class EndirimTipiUpdateCommandHandler
        (IEndirinTipiRepository repository, IUnitOfWork unitOfWork) : IRequestHandler<EndirimTipiUpdateCommand, Result<EndirimTipiGetAllQueryResponse>>
    {
        public async Task<Result<EndirimTipiGetAllQueryResponse>> Handle(EndirimTipiUpdateCommand request, CancellationToken cancellationToken)
        {
            var entity = await repository.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
            if (entity is null) return Result<EndirimTipiGetAllQueryResponse>.Failure("Endirim tipi tapılmadı");

            var exists = await repository.AnyAsync(x => x.Ad == request.Ad && x.Id != request.Id, cancellationToken);
            if (exists) return Result<EndirimTipiGetAllQueryResponse>.Failure("Bu adda başqa endirim tipi mövcuddur");

            request.Adapt(entity);

            await unitOfWork.SaveChangesAsync(cancellationToken);

            var response = new EndirimTipiGetAllQueryResponse
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

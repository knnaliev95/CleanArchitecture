using CleanArchitecture.Domain.Modules.Admin.EndirimTipis;
using FluentValidation;
using GenericRepository;
using Mapster;
using MediatR;
using TS.Result;

namespace CleanArchitecture.Application.Modules.Admin.EndirimTipis
{
    public sealed record EndirimTipiCreateCommand(string Ad, bool IsDeleted) : IRequest<Result<EndirimTipiGetAllQueryResponse>>;

    public sealed class EndirimTipiCreateCommandValidator : AbstractValidator<EndirimTipiCreateCommand>
    {
        public EndirimTipiCreateCommandValidator()
        {
            RuleFor(x => x.Ad).NotEmpty().WithMessage("Ad boş ola bilməz");
        }
    }

    public sealed class EndirimTipiCreateCommandHandler
        (IEndirinTipiRepository repository, IUnitOfWork unitOfWork) : IRequestHandler<EndirimTipiCreateCommand, Result<EndirimTipiGetAllQueryResponse>>
    {
        public async Task<Result<EndirimTipiGetAllQueryResponse>> Handle(EndirimTipiCreateCommand request, CancellationToken cancellationToken)
        {
            var exists = await repository.AnyAsync(x => x.Ad == request.Ad, cancellationToken);
            if (exists) return Result<EndirimTipiGetAllQueryResponse>.Failure("Bu adda endirim tipi artıq mövcuddur.");

            var entity = request.Adapt<EndirimTipi>();
            entity.IsDeleted = request.IsDeleted;
            repository.Add(entity);
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

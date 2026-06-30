using CleanArchitecture.Domain.Modules.Admin.Ixtisases;
using FluentValidation;
using GenericRepository;
using Mapster;
using MediatR;
using TS.Result;

namespace CleanArchitecture.Application.Modules.Admin.Ixtisases
{
    public sealed record IxtisasUpdateRequest(
        string Ad
    );
    public sealed record IxtisasUpdateCommand(
        int Id,
        string Ad
    ) : IRequest<Result<IxtisasGetAllQueryResponse>>;

    public sealed class IxtisasUpdateCommandValidator : AbstractValidator<IxtisasUpdateCommand>
    {
        public IxtisasUpdateCommandValidator()
        {
            RuleFor(x => x.Id)
                .GreaterThan(0)
                .WithMessage("Id düzgün deyil.");

            RuleFor(x => x.Ad)
                .NotEmpty()
                .WithMessage("Ixtisas adı boş olamaz.")
                .MinimumLength(3)
                .WithMessage("Ixtisas adı en az 3 simvol olmalıdır.")
                .MaximumLength(100)
                .WithMessage("Ixtisas adı 100 simvoldan uzun ola bilməz.");
        }
    }

    internal sealed class IxtisasUpdateCommandHandler
        (IIxtisasRepository ixtisasRepository, IUnitOfWork unitOfWork) : IRequestHandler<IxtisasUpdateCommand, Result<IxtisasGetAllQueryResponse>>
    {
        public async Task<Result<IxtisasGetAllQueryResponse>> Handle(IxtisasUpdateCommand request, CancellationToken cancellationToken)
        {
            var ixtisas = await ixtisasRepository
                .FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);

            if (ixtisas is null)
            {
                return Result<IxtisasGetAllQueryResponse>.Failure("Ixtisas tapılmadı.");
            }

            var isNameExists = await ixtisasRepository.AnyAsync(
                x => x.Ad == request.Ad && x.Id != request.Id,
                cancellationToken);

            if (isNameExists)
            {
                return Result<IxtisasGetAllQueryResponse>.Failure("Bu adda başqa ixtisas artıq mövcuddur.");
            }

            // Update
            request.Adapt(ixtisas);

            await unitOfWork.SaveChangesAsync(cancellationToken);

            var response = new IxtisasGetAllQueryResponse
            {
                Id = ixtisas.Id,
                Ad = ixtisas.Ad,
                IsDeleted = ixtisas.IsDeleted,
                CreateUserName = ixtisas.CreateUser != null ? ixtisas.CreateUser.UserName : "none",
                CreatedDate = ixtisas.CreatedDate,
                UpdateUserName = ixtisas.UpdateUser != null ? ixtisas.UpdateUser.UserName : "none",
                UpdatedDate = ixtisas.UpdatedDate,
                DeletedUserName = ixtisas.DeleteUser != null ? ixtisas.DeleteUser.UserName : "none",
                DeletedDate = ixtisas.DeletedDate
            };

            return response;
        }
    }
}

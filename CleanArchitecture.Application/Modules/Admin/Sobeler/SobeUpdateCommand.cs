using CleanArchitecture.Domain.Modules.Admin.Sobeler;
using FluentValidation;
using GenericRepository;
using Mapster;
using MediatR;
using TS.Result;

namespace CleanArchitecture.Application.Modules.Admin.Sobeler
{
    public sealed record SobeUpdateRequest(
        string Ad
    );
    public sealed record SobeUpdateCommand(
        int Id,
        string Ad
    ) : IRequest<Result<string>>;

    public sealed class SobeUpdateCommandValidator : AbstractValidator<SobeUpdateCommand>
    {
        public SobeUpdateCommandValidator()
        {
            RuleFor(x => x.Id)
                .GreaterThan(0)
                .WithMessage("Id düzgün deyil.");

            RuleFor(x => x.Ad)
                .NotEmpty()
                .WithMessage("Sobe adı boş olamaz.")
                .MinimumLength(3)
                .WithMessage("Sobe adı en az 3 simvol olmalıdır.")
                .MaximumLength(100)
                .WithMessage("Sobe adı 100 simvoldan uzun ola bilməz.");
        }
    }

    internal sealed class SobeUpdateCommandHandler
        (ISobeRepository sobeRepository, IUnitOfWork unitOfWork) : IRequestHandler<SobeUpdateCommand, Result<string>>
    {
        public async Task<Result<string>> Handle(SobeUpdateCommand request, CancellationToken cancellationToken)
        {
            var Sobe = await sobeRepository
                .FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);

            if (Sobe is null)
            {
                return Result<string>.Failure("Sobe tapılmadı.");
            }

            var isNameExists = await sobeRepository.AnyAsync(
                x => x.Ad == request.Ad && x.Id != request.Id,
                cancellationToken);

            if (isNameExists)
            {
                return Result<string>.Failure("Bu adda başqa Sobe artıq mövcuddur.");
            }

            // Update
            request.Adapt(Sobe);
            Sobe.UpdatedDate = DateTime.Now;

            await unitOfWork.SaveChangesAsync(cancellationToken);

            return "Sobe uğurla yeniləndi.";
        }
    }
}

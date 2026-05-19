using CleanArchitecture.Domain.Modules.Admin.Ixtisases;
using FluentValidation;
using GenericRepository;
using Mapster;
using MediatR;
using TS.Result;

namespace CleanArchitecture.Application.Modules.Admin.Ixtisases
{
    public sealed record IxtisasCreateCommand(
        string Name
        ) : IRequest<Result<string>>;

    public sealed class IxtisasCreateCommandValidator : AbstractValidator<IxtisasCreateCommand>
    {
        public IxtisasCreateCommandValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("Ixtisas adı boş olamaz.")
                .MinimumLength(3)
                .WithMessage("Ixtisas adı en az 3 simvol olmalıdır.")
                .MaximumLength(100)
                .WithMessage("Ixtisas adı 100 simvoldan uzun ola bilməz.");
        }
    }

    public sealed class IxtisasCreateCommandHandler
        (IIxtisasRepository ixtisasRepository, IUnitOfWork unitOfWork) : IRequestHandler<IxtisasCreateCommand, Result<string>>
    {

        public async Task<Result<string>> Handle(IxtisasCreateCommand request, CancellationToken cancellationToken)
        {
            var isIxtisasExists = await ixtisasRepository.AnyAsync(x => x.Name == request.Name, cancellationToken);

            if (isIxtisasExists)
            {
                return Result<string>.Failure("Bu adda ixtisas artıq mövcuddur.");
            }

            Ixtisas ixtisas = request.Adapt<Ixtisas>();

            ixtisasRepository.Add(ixtisas);

            await unitOfWork.SaveChangesAsync(cancellationToken);

            return "Ixtisas uğurla yaradıldı.";
        }
    }
}

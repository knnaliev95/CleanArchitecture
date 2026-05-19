using CleanArchitecture.Domain.Modules.Admin.Teskilats;
using FluentValidation;
using GenericRepository;
using Mapster;
using MediatR;
using TS.Result;

namespace CleanArchitecture.Application.Modules.Admin.Teskilats
{
    public sealed record TeskilatCreateCommand(
        string Ad
    ) : IRequest<Result<string>>;

    public sealed class TeskilatCreateCommandValidator : AbstractValidator<TeskilatCreateCommand>
    {
        public TeskilatCreateCommandValidator()
        {
            RuleFor(x => x.Ad)
                .NotEmpty()
                .MinimumLength(3)
                .WithMessage("Ad minimum 3 simvol olmalıdır");
        }
    }

    public sealed class TeskilatCreateCommandHandler
        (ITeskilatRepository teskilatRepository, IUnitOfWork unitOfWork) : IRequestHandler<TeskilatCreateCommand, Result<string>>
    {
        public async Task<Result<string>> Handle(TeskilatCreateCommand request, CancellationToken cancellationToken)
        {
            Teskilat teslikat = request.Adapt<Teskilat>();

            teskilatRepository.Add(teslikat);

            await unitOfWork.SaveChangesAsync(cancellationToken);

            return "Təşkilat uğurla əlavə edildi";
        }
    }
}

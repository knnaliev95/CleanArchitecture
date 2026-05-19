using CleanArchitecture.Domain.Modules.Admin.Hekims;
using FluentValidation;
using GenericRepository;
using Mapster;
using MediatR;
using TS.Result;

namespace CleanArchitecture.Application.Modules.Admin.Hekims
{
    public sealed record HekimCreateCommand(
        string Fin,
        string Ad,
        int IxtisasId,
        int SobeId,
        int? OtaqNomresi,
        double? Qiymet
        ) : IRequest<Result<string>>;
    
    public sealed class HekimCreateCommandValidator : AbstractValidator<HekimCreateCommand>
    {
        public HekimCreateCommandValidator()
        {
            RuleFor(x => x.Fin)
                .NotEmpty()
                .WithMessage("Fin boş ola bilməz")
                .MinimumLength(6)
                .WithMessage("Fin 6 simvoldan az ola bilməz")
                .MaximumLength(7)
                .WithMessage("Fin 7 simvoldan çox ola bilməz");

            RuleFor(x => x.Ad)
                .NotEmpty()
                .MinimumLength(3)
                .WithMessage("Ad 3 simvoldan az ola bilməz");

            RuleFor(x => x.IxtisasId)
                .NotEmpty()
                .WithMessage("İxtisas mütləq seçilməlidir");

            RuleFor(x => x.SobeId)
                .NotEmpty()
                .WithMessage("Şöbə mütləq seçilməlidir");
        }
    }

    public sealed class HekimCreateCommandHandler
        (IHekimRepository hekimReposiroty, IUnitOfWork unitOfWork) : IRequestHandler<HekimCreateCommand, Result<string>>
    {

        public async Task<Result<string>> Handle(HekimCreateCommand request, CancellationToken cancellationToken)
        {
            Hekim hekim = request.Adapt<Hekim>();

            hekimReposiroty.Add(hekim);

            await unitOfWork.SaveChangesAsync(cancellationToken);

            return "Həkim uğurla əlavə edildi";
        }
    }
}

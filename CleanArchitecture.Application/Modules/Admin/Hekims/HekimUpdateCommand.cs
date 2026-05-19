using CleanArchitecture.Domain.Modules.Admin.Hekims;
using FluentValidation;
using GenericRepository;
using Mapster;
using MediatR;
using TS.Result;

namespace CleanArchitecture.Application.Modules.Admin.Hekims
{
    public sealed record HekimUpdateRequest(
        string Fin,
        string Ad,
        int IxtisasId,
        int SobeId,
        int? OtaqNomresi,
        double? Qiymet
    );

    public sealed record HekimUpdateCommand(
        int Id,
        string Fin,
        string Ad,
        int IxtisasId,
        int SobeId,
        int? OtaqNomresi,
        double? Qiymet
    ) : IRequest<Result<string>>;

    public sealed class HekimUpdateCommandValidator : AbstractValidator<HekimUpdateCommand>
    {
        public HekimUpdateCommandValidator()
        {
            RuleFor(x => x.Id)
                .GreaterThan(0)
                .WithMessage("Id düzgün deyil.");

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

    internal sealed class HekimUpdateCommandHandler
        (IHekimRepository hekimRepository, IUnitOfWork unitOfWork) : IRequestHandler<HekimUpdateCommand, Result<string>>
    {
        public async Task<Result<string>> Handle(HekimUpdateCommand request, CancellationToken cancellationToken)
        {
            var hekim = await hekimRepository
                .FirstOrDefaultAsync(h => h.Id == request.Id, cancellationToken);

            if(hekim is null)
            {
                return Result<string>.Failure("Həkim tapılmadı");
            }

            request.Adapt(hekim);
            hekim.UpdatedDate = DateTime.Now;

            await unitOfWork.SaveChangesAsync(cancellationToken);

            return "Həkim məlumatları uğurla yeniləndi";
        }
    }
}

using CleanArchitecture.Domain.Modules.Admin.Teskilats;
using FluentValidation;
using GenericRepository;
using Mapster;
using MediatR;
using TS.Result;

namespace CleanArchitecture.Application.Modules.Admin.Teskilats
{
    public sealed record TeskilatUpdateRequest(
        string Ad
    );

    public sealed record TeskilatUpdateCommand(
        int Id,
        string Ad
    ) : IRequest<Result<string>>;

    public sealed class TeskilatUpdateCommandValidator : AbstractValidator<TeskilatUpdateCommand>
    {
        public TeskilatUpdateCommandValidator()
        {
            RuleFor(x => x.Id)
                .GreaterThan(0)
                .WithMessage("Id düzgün deyil.");

            RuleFor(x => x.Ad)
                .NotEmpty()
                .MinimumLength(3)
                .WithMessage("Ad 3 simvoldan az ola bilməz");
        }
    }

    internal sealed class TeskilatUpdateCommandHandler
        (ITeskilatRepository teskilatRepository, IUnitOfWork unitOfWork) : IRequestHandler<TeskilatUpdateCommand, Result<string>>
    {
        public async Task<Result<string>> Handle(TeskilatUpdateCommand request, CancellationToken cancellationToken)
        {
            var teskilat = await teskilatRepository
                .FirstOrDefaultAsync(t => t.Id == request.Id, cancellationToken);

            if(teskilat is null)
            {
                return Result<string>.Failure("Təşkilat tapılmadı");
            }

            request.Adapt(teskilat);
            teskilat.UpdatedDate = DateTime.Now;

            await unitOfWork.SaveChangesAsync(cancellationToken);

            return "Təşkilat məlumatları uğurla yeniləndi";
        }
    }
}

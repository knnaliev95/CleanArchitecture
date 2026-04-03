using CleanArchitecture.Domain.Modules.Admin.Sobeler;
using FluentValidation;
using GenericRepository;
using Mapster;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using TS.Result;

namespace CleanArchitecture.Application.Modules.Admin.Sobeler
{
    public sealed record SobeCreateCommand(
        string Ad
        ) : IRequest<Result<string>>;

    public sealed class SobeCreateCommandValidator : AbstractValidator<SobeCreateCommand>
    {
        public SobeCreateCommandValidator()
        {
            RuleFor(x => x.Ad)
                .NotEmpty()
                .WithMessage("Sobe adı boş olamaz.")
                .MinimumLength(3)
                .WithMessage("Sobe adı en az 3 simvol olmalıdır.")
                .MaximumLength(100)
                .WithMessage("Sobe adı 100 simvoldan uzun ola bilməz.");
        }
    }

    public sealed class SobeCreateCommandHandler : IRequestHandler<SobeCreateCommand, Result<string>>
    {
        private readonly ISobeRepository _SobeRepository;
        private readonly IUnitOfWork _unitOfWork;

        public SobeCreateCommandHandler(ISobeRepository SobeRepository, IUnitOfWork unitOfWork)
        {
            _SobeRepository = SobeRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Result<string>> Handle(SobeCreateCommand request, CancellationToken cancellationToken)
        {
            var isSobeExists = await _SobeRepository.AnyAsync(x => x.Ad == request.Ad, cancellationToken);

            if (isSobeExists)
            {
                return Result<string>.Failure("Bu adda Sobe artıq mövcuddur.");
            }

            Sobe Sobe = request.Adapt<Sobe>();

            _SobeRepository.Add(Sobe);

            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return "Sobe uğurla yaradıldı.";
        }
    }
}

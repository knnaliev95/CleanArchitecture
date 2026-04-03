using CleanArchitecture.Domain.Modules.Admin.Ixtisases;
using FluentValidation;
using GenericRepository;
using Mapster;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using TS.Result;

namespace CleanArchitecture.Application.Modules.Admin.Ixtisases
{
    public sealed record IxtisasUpdateRequest(
        string Name
    );
    public sealed record IxtisasUpdateCommand(
        int Id,
        string Name
    ) : IRequest<Result<string>>;

    public sealed class IxtisasUpdateCommandValidator : AbstractValidator<IxtisasUpdateCommand>
    {
        public IxtisasUpdateCommandValidator()
        {
            RuleFor(x => x.Id)
                .GreaterThan(0)
                .WithMessage("Id düzgün deyil.");

            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("Ixtisas adı boş olamaz.")
                .MinimumLength(3)
                .WithMessage("Ixtisas adı en az 3 simvol olmalıdır.")
                .MaximumLength(100)
                .WithMessage("Ixtisas adı 100 simvoldan uzun ola bilməz.");
        }
    }

    internal sealed class IxtisasUpdateCommandHandler : IRequestHandler<IxtisasUpdateCommand, Result<string>>
    {
        private readonly IIxtisasRepository _ixtisasRepository;
        private readonly IUnitOfWork _unitOfWork;

        public IxtisasUpdateCommandHandler(IIxtisasRepository ixtisasRepository, IUnitOfWork unitOfWork)
        {
            _ixtisasRepository = ixtisasRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Result<string>> Handle(IxtisasUpdateCommand request, CancellationToken cancellationToken)
        {
            var ixtisas = await _ixtisasRepository
                .FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);

            if (ixtisas is null)
            {
                return Result<string>.Failure("Ixtisas tapılmadı.");
            }

            var isNameExists = await _ixtisasRepository.AnyAsync(
                x => x.Name == request.Name && x.Id != request.Id,
                cancellationToken);

            if (isNameExists)
            {
                return Result<string>.Failure("Bu adda başqa ixtisas artıq mövcuddur.");
            }

            // Update
            request.Adapt(ixtisas);
            ixtisas.UpdatedDate = DateTime.Now;

            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return "Ixtisas uğurla yeniləndi.";
        }
    }
}

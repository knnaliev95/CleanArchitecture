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
        string Ad,
        bool IsAmbulator,
        bool IsStasionar,
        bool IsDeleted
        ) : IRequest<Result<SobeGetAllQueryResponse>>;

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

    public sealed class SobeCreateCommandHandler(ISobeRepository SobeRepository, IUnitOfWork unitOfWork) : IRequestHandler<SobeCreateCommand, Result<SobeGetAllQueryResponse>>
    {
        public async Task<Result<SobeGetAllQueryResponse>> Handle(SobeCreateCommand request, CancellationToken cancellationToken)
        {
            var isSobeExists = await SobeRepository.AnyAsync(x => x.Ad == request.Ad, cancellationToken);

            if (isSobeExists)
            {
                return Result<SobeGetAllQueryResponse>.Failure("Bu adda Sobe artıq mövcuddur.");
            }

            Sobe sobe = request.Adapt<Sobe>();
            sobe.IsDeleted = request.IsDeleted;

            SobeRepository.Add(sobe);

            await unitOfWork.SaveChangesAsync(cancellationToken);

            var response = new SobeGetAllQueryResponse
            {
                Id = sobe.Id,
                Ad = sobe.Ad,
                IsAmbulator = sobe.IsAmbulator,
                IsStasionar = sobe.IsStasionar,
                IsDeleted = sobe.IsDeleted,
                CreateUserName = sobe.CreateUser != null ? sobe.CreateUser.UserName : "none",
                CreatedDate = sobe.CreatedDate,
                UpdateUserName = sobe.UpdateUser != null ? sobe.UpdateUser.UserName : "none",
                UpdatedDate = sobe.UpdatedDate,
                DeletedUserName = sobe.DeleteUser != null ? sobe.DeleteUser.UserName : "none",
                DeletedDate = sobe.DeletedDate
            };

            return response;
        }
    }
}

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
    ) : IRequest<Result<SobeGetAllQueryResponse>>;

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
        (ISobeRepository sobeRepository, IUnitOfWork unitOfWork) : IRequestHandler<SobeUpdateCommand, Result<SobeGetAllQueryResponse>>
    {
        public async Task<Result<SobeGetAllQueryResponse>> Handle(SobeUpdateCommand request, CancellationToken cancellationToken)
        {
            var sobe = await sobeRepository
                .FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
            if (sobe is null)
            {
                return Result<SobeGetAllQueryResponse>.Failure("Sobe tapılmadı.");
            }

            var isNameExists = await sobeRepository.AnyAsync(
                x => x.Ad == request.Ad && x.Id != request.Id,
                cancellationToken);

            if (isNameExists)
            {
                return Result<SobeGetAllQueryResponse>.Failure("Bu adda başqa Sobe artıq mövcuddur.");
            }

            // Update
            request.Adapt(sobe);

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

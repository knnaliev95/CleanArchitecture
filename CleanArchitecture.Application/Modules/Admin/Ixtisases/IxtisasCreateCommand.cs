using CleanArchitecture.Domain.Modules.Admin.Ixtisases;
using FluentValidation;
using GenericRepository;
using Mapster;
using MediatR;
using TS.Result;

namespace CleanArchitecture.Application.Modules.Admin.Ixtisases
{
    public sealed record IxtisasCreateCommand(
        string Ad
        , bool IsDeleted
        ) : IRequest<Result<IxtisasGetAllQueryResponse>>;

    public sealed class IxtisasCreateCommandValidator : AbstractValidator<IxtisasCreateCommand>
    {
        public IxtisasCreateCommandValidator()
        {
            RuleFor(x => x.Ad)
                .NotEmpty()
                .WithMessage("Ixtisas adı boş olamaz.")
                .MinimumLength(3)
                .WithMessage("Ixtisas adı en az 3 simvol olmalıdır.")
                .MaximumLength(100)
                .WithMessage("Ixtisas adı 100 simvoldan uzun ola bilməz.");
        }
    }

    public sealed class IxtisasCreateCommandHandler
        (IIxtisasRepository ixtisasRepository, IUnitOfWork unitOfWork) : IRequestHandler<IxtisasCreateCommand, Result<IxtisasGetAllQueryResponse>>
    {

        public async Task<Result<IxtisasGetAllQueryResponse>> Handle(IxtisasCreateCommand request, CancellationToken cancellationToken)
        {
            var isIxtisasExists = await ixtisasRepository.AnyAsync(x => x.Ad == request.Ad, cancellationToken);

            if (isIxtisasExists)
            {
                return Result<IxtisasGetAllQueryResponse>.Failure("Bu adda ixtisas artıq mövcuddur.");
            }

            Ixtisas ixtisas = request.Adapt<Ixtisas>();
            ixtisas.IsDeleted = request.IsDeleted;

            ixtisasRepository.Add(ixtisas);

            await unitOfWork.SaveChangesAsync(cancellationToken);

            var response = new IxtisasGetAllQueryResponse
            {
                Id = ixtisas.Id,
                Ad = ixtisas.Ad,
                IsDeleted = ixtisas.IsDeleted,
                CreateUserName = ixtisas.CreateUser != null ? ixtisas.CreateUser.UserName : "none",
                CreatedDate = ixtisas.CreatedDate,
                UpdateUserName = ixtisas.UpdateUser != null ? ixtisas.UpdateUser.UserName : "none",
                UpdatedDate = ixtisas.UpdatedDate,
                DeletedUserName = ixtisas.DeleteUser != null ? ixtisas.DeleteUser.UserName : "none",
                DeletedDate = ixtisas.DeletedDate
            };

            return response;
        }
    }
}

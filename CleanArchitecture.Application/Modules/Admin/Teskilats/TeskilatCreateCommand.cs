using CleanArchitecture.Domain.Modules.Admin.Teskilats;
using FluentValidation;
using GenericRepository;
using Mapster;
using MediatR;
using TS.Result;

namespace CleanArchitecture.Application.Modules.Admin.Teskilats
{
    public sealed record TeskilatCreateCommand(
        string Ad,
        bool IsDeleted
    ) : IRequest<Result<TeskilatGetAllQueryResponse>>;

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
        (ITeskilatRepository teskilatRepository, IUnitOfWork unitOfWork) : IRequestHandler<TeskilatCreateCommand, Result<TeskilatGetAllQueryResponse>>
    {
        public async Task<Result<TeskilatGetAllQueryResponse>> Handle(TeskilatCreateCommand request, CancellationToken cancellationToken)
        {
            Teskilat teskilat = request.Adapt<Teskilat>();

            teskilatRepository.Add(teskilat);

            await unitOfWork.SaveChangesAsync(cancellationToken);

            var response = new TeskilatGetAllQueryResponse
            {
                Id = teskilat.Id,
                Ad = teskilat.Ad,
                IsDeleted = teskilat.IsDeleted,
                CreateUserName = teskilat.CreateUser?.UserName ?? "none",
                CreatedDate = teskilat.CreatedDate,
                UpdateUserName = teskilat.UpdateUser?.UserName ?? "none",
                UpdatedDate = teskilat.UpdatedDate,
                DeletedUserName = teskilat.DeleteUser?.UserName ?? "none",
                DeletedDate = teskilat.DeletedDate
            };

            return response;
        }
    }
}

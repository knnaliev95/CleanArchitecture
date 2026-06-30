using CleanArchitecture.Domain.Modules.Admin.Teskilats;
using FluentValidation;
using GenericRepository;
using Mapster;
using MediatR;
using TS.Result;

namespace CleanArchitecture.Application.Modules.Admin.Teskilats
{
    public sealed record TeskilatUpdateRequest(
        string Ad,
        bool IsDeleted
    );

    public sealed record TeskilatUpdateCommand(
        int Id,
        string Ad,
        bool IsDeleted
    ) : IRequest<Result<TeskilatGetAllQueryResponse>>;

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
        (ITeskilatRepository teskilatRepository, IUnitOfWork unitOfWork) : IRequestHandler<TeskilatUpdateCommand, Result<TeskilatGetAllQueryResponse>>
    {
        public async Task<Result<TeskilatGetAllQueryResponse>> Handle(TeskilatUpdateCommand request, CancellationToken cancellationToken)
        {
            var teskilat = await teskilatRepository
                .FirstOrDefaultAsync(t => t.Id == request.Id, cancellationToken);

            if(teskilat is null)
            {
                return Result<TeskilatGetAllQueryResponse>.Failure("Təşkilat tapılmadı");
            }

            request.Adapt(teskilat);

            await unitOfWork.SaveChangesAsync(cancellationToken);

            var response = new TeskilatGetAllQueryResponse
            {
                Id = teskilat.Id,
                Ad = teskilat.Ad,
                IsDeleted = teskilat.IsDeleted,
                CreateUserName = teskilat.CreateUser != null ? teskilat.CreateUser.UserName : "none",
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

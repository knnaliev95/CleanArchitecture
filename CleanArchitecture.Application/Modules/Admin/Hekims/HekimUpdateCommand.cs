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
    ) : IRequest<Result<HekimGetAllQueryResponse>>;

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
        (IHekimRepository hekimRepository, IUnitOfWork unitOfWork) : IRequestHandler<HekimUpdateCommand, Result<HekimGetAllQueryResponse>>
    {
        public async Task<Result<HekimGetAllQueryResponse>> Handle(HekimUpdateCommand request, CancellationToken cancellationToken)
        {
            var hekim = await hekimRepository
                .FirstOrDefaultAsync(h => h.Id == request.Id, cancellationToken);

            if(hekim is null)
            {
                return Result<HekimGetAllQueryResponse>.Failure("Həkim tapılmadı");
            }

            request.Adapt(hekim);

            await unitOfWork.SaveChangesAsync(cancellationToken);

            var response = new HekimGetAllQueryResponse
            {
                Id = hekim.Id,
                Fin = hekim.Fin,
                Ad = hekim.Ad,
                IxtisasId = hekim.IxtisasId,
                IxtisasAdi = hekim.Ixtisas != null ? hekim.Ixtisas.Ad ?? string.Empty : string.Empty,
                SobeId = hekim.SobeId,
                SobeAdi = hekim.Sobe != null ? hekim.Sobe.Ad ?? string.Empty : string.Empty,
                OtaqNomresi = hekim.OtaqNomresi,
                Qiymet = hekim.Qiymet,
                IsDeleted = hekim.IsDeleted,
                CreateUserName = hekim.CreateUser != null ? hekim.CreateUser.UserName : "none",
                CreatedDate = hekim.CreatedDate,
                UpdateUserName = hekim.UpdateUser != null ? hekim.UpdateUser.UserName : "none",
                UpdatedDate = hekim.UpdatedDate,
                DeletedUserName = hekim.DeleteUser != null ? hekim.DeleteUser.UserName : "none",
                DeletedDate = hekim.DeletedDate
            };

            return response;
        }
    }
}

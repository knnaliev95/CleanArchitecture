using CleanArchitecture.Application.Modules.Admin.Faizs;
using CleanArchitecture.Domain.Modules.Common.Pasients;
using FluentValidation;
using GenericRepository;
using Mapster;
using MediatR;
using TS.Result;

namespace CleanArchitecture.Application.Modules.Common.Pasients
{
    public sealed record PasientCreateCommand(
        string? SenedNovu,
        string? SenedNomresi,
        string? Fin,
        string Cinsi,
        string Ad,
        string Soyad,
        string AtaAdi,
        DateOnly DogumTarixi,
        string? Unvan,
        string? Telefon,
        int TeskilatId
        ) : IRequest<Result<PasientResponse>>;

    public sealed class PasientCreateCommandValidator : AbstractValidator<PasientCreateCommand>
    {
        public PasientCreateCommandValidator()
        {
            RuleFor(x => x.Cinsi)
                .NotEmpty()
                .WithMessage("Pasientin cinsiyyəti mütləq seçilməlidir");

            RuleFor(x => x.Ad)
                .NotEmpty()
                .WithMessage("Pasient adı mütləq qeyd edilməlidir")
                .MinimumLength(3)
                .WithMessage("Pasient adı ən az 3 simvol olmalıdır")
                .MaximumLength(25)
                .WithMessage("Pasient adı maksimum 25 simvol ola bilər");

            RuleFor(x => x.Soyad)
                .NotEmpty()
                .WithMessage("Pasient soyadı mütləq qeyd edilməlidir")
                .MinimumLength(3)
                .WithMessage("Pasient soyadı ən az 3 simvol olmalıdır")
                .MaximumLength(25)
                .WithMessage("Pasient soyadı maksimum 25 simvol ola bilər");

            RuleFor(x => x.AtaAdi)
                .NotEmpty()
                .WithMessage("Pasient ata adı mütləq qeyd edilməlidir")
                .MinimumLength(3)
                .WithMessage("Pasient ata adı ən az 3 simvol olmalıdır")
                .MaximumLength(25)
                .WithMessage("Pasient ata adı maksimum 25 simvol ola bilər");

            RuleFor(x => x.DogumTarixi)
                .NotEmpty()
                .WithMessage("Pasientin Doğum tarixi mütləq qeyd edilməlidir");
        }
    }

    internal sealed class PasientCreateCommandHandler
        (IPasientRepository repository, IUnitOfWork unitOfWork) : IRequestHandler<PasientCreateCommand, Result<PasientResponse>>
    {
        public async Task<Result<PasientResponse>> Handle(PasientCreateCommand request, CancellationToken cancellationToken)
        {
            var entity = request.Adapt<Pasient>();
            repository.Add(entity);
            await unitOfWork.SaveChangesAsync(cancellationToken);

            var response = new PasientResponse
            {
                Id = entity.Id,
                SenedNovu = entity.SenedNovu,
                Cinsi = entity.Cinsi,
                SenedNomresi = entity.SenedNomresi,
                Fin = entity.Fin,
                Ad = entity.Ad,
                Soyad = entity.Soyad,
                AtaAdi = entity.AtaAdi,
                DogumTarixi = entity.DogumTarixi,
                Unvan = entity.Unvan,
                Telefon = entity.Telefon,
                TeskilatId = entity.TeskilatId,
                TeskilatAdi = entity.Teskilat != null ? entity.Teskilat.Ad : string.Empty,
                IsDeleted = entity.IsDeleted,
                CreateUserName = entity.CreateUser != null ? entity.CreateUser.UserName : "none",
                CreatedDate = entity.CreatedDate,
                UpdateUserName = entity.UpdateUser != null ? entity.UpdateUser.UserName : "none",
                UpdatedDate = entity.UpdatedDate,
                DeletedUserName = entity.DeleteUser != null ? entity.DeleteUser.UserName : "none",
                DeletedDate = entity.DeletedDate
            };

            return response;
        }
    }
}
 
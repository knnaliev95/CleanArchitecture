using CleanArchitecture.Domain.Core;
using CleanArchitecture.Domain.Modules.Common.Pasients;
using MediatR;

namespace CleanArchitecture.Application.Modules.Common.Pasients
{
    public sealed record PasientSearchQuery() : IRequest<IQueryable<PasientResponse>>;

    public sealed class PasientResponse : BaseEntityDto
    {
        public string? SenedNovu { get; set; }
        public string Cinsi { get; set; } = string.Empty;
        public string? SenedNomresi { get; set; }
        public string? Fin { get; set; }
        public string Ad { get; set; } = string.Empty;
        public string Soyad { get; set; } = string.Empty;
        public string AtaAdi { get; set; } = string.Empty;
        public DateOnly DogumTarixi { get; set; }
        public string? Unvan { get; set; }
        public string? Telefon { get; set; }
        public int TeskilatId { get; set; }
        public string TeskilatAdi { get; set; } = string.Empty;
    }

    internal sealed class PasientSearchQueryHandler
        (IPasientRepository repository) : IRequestHandler<PasientSearchQuery, IQueryable<PasientResponse>>
    {
        public Task<IQueryable<PasientResponse>> Handle(PasientSearchQuery request, CancellationToken cancellationToken)
        {
            var response = repository.GetAll().Select(x => new PasientResponse
            {
                Id = x.Id,
                SenedNovu = x.SenedNovu,
                Cinsi = x.Cinsi,
                SenedNomresi = x.SenedNomresi,
                Fin = x.Fin,
                Ad = x.Ad,
                Soyad = x.Soyad,
                AtaAdi = x.AtaAdi,
                DogumTarixi = x.DogumTarixi,
                Unvan = x.Unvan,
                Telefon = x.Telefon,
                TeskilatId = x.TeskilatId,
                TeskilatAdi = x.Teskilat != null ? x.Teskilat.Ad : string.Empty,
                IsDeleted = x.IsDeleted,
                CreateUserName = x.CreateUser != null ? x.CreateUser.UserName : "none",
                CreatedDate = x.CreatedDate,
                UpdateUserName = x.UpdateUser != null ? x.UpdateUser.UserName : "none",
                UpdatedDate = x.UpdatedDate,
                DeletedUserName = x.DeleteUser != null ? x.DeleteUser.UserName : "none",
                DeletedDate = x.DeletedDate
            });

            return Task.FromResult(response);
        }
    }
}

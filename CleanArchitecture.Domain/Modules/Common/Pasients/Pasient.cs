using CleanArchitecture.Domain.Core;
using CleanArchitecture.Domain.Modules.Admin.Teskilats;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanArchitecture.Domain.Modules.Common.Pasients
{
    public sealed class Pasient : BaseEntity
    {
        public int Protokol { get; set; }
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
        [ForeignKey(nameof(TeskilatId))]
        public Teskilat? Teskilat { get; set; }
    }
}

using CleanArchitecture.Domain.Core;
using CleanArchitecture.Domain.Modules.Admin.Ixtisases;
using CleanArchitecture.Domain.Modules.Admin.Sobeler;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanArchitecture.Domain.Modules.Admin.Hekims
{
    public sealed class Hekim : BaseEntity
    {
        public string Fin { get; set; } = string.Empty;
        public string Ad { get; set; } = string.Empty;
        public int IxtisasId { get; set; }
        [ForeignKey(nameof(IxtisasId))]
        public Ixtisas? Ixtisas { get; set; }
        public int SobeId { get; set; }
        [ForeignKey(nameof(SobeId))]
        public Sobe? Sobe { get; set; }
        public int? OtaqNomresi { get; set; }
        public double? Qiymet {  get; set; }
    }
}

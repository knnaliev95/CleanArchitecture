using CleanArchitecture.Domain.Core;
using CleanArchitecture.Domain.Modules.Admin.Xidmets;
using CleanArchitecture.Domain.Modules.Laboratoriya.CavabQrupus;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanArchitecture.Domain.Modules.Laboratoriya.Parametrs
{
    public class Parametr : BaseEntity
    {
        public int XidmetId { get; set; }
        [ForeignKey(nameof(XidmetId))]
        public Xidmet? Xidmet { get; set; }
        public string Ad {  get; set; } = string.Empty;
        public string Kod { get; set; } = string.Empty;
        public string OlcuVahidi {  get; set; } = string.Empty;
        public string NeticeTipi {  get; set; } = string.Empty;
        public int Ondalik {  get; set; }
        public bool IsHesablanan { get; set; }
        public string? Formula { get; set; }
        public int? CapSirasi { get; set; }
        public int CavabQrupuId { get; set; }
        [ForeignKey(nameof(CavabQrupuId))]
        public CavabQrupu? CavabQrupu { get; set; }
    }
}

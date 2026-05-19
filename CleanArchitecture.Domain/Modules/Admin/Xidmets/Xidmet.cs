using CleanArchitecture.Domain.Core;
using CleanArchitecture.Domain.Modules.Admin.XidmetNovus;
using CleanArchitecture.Domain.Modules.Admin.XidmetQrupus;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanArchitecture.Domain.Modules.Admin.Xidmets
{
    public sealed class Xidmet : BaseEntity
    {
        public string Ad { get; set; } = string.Empty;
        public string Kod { get; set; } = string.Empty;
        public double Qiymet { get; set; }
        public double? ITSQiymeti { get; set; }
        public int XidmetNovuId { get; set; }
        [ForeignKey(nameof(XidmetNovuId))]
        public XidmetNovu? XidmetNovu { get; set; }
        public int? XidmetQrupuId { get; set; }
        [ForeignKey(nameof(XidmetQrupuId))]
        public XidmetQrupu? XidmetQrupu { get; set; }
    }
}

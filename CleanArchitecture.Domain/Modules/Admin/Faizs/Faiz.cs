using CleanArchitecture.Domain.Core;
using CleanArchitecture.Domain.Modules.Admin.Hekims;
using CleanArchitecture.Domain.Modules.Admin.Teskilats;
using CleanArchitecture.Domain.Modules.Admin.XidmetQrupus;
using CleanArchitecture.Domain.Modules.Admin.Xidmets;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanArchitecture.Domain.Modules.Admin.Faizs
{
    public class Faiz : BaseEntity
    {
        public int? HekimId { get; set; }
        [ForeignKey(nameof(HekimId))]
        public Hekim? Hekim { get; set; }
        public int? TeskilatId { get; set; }
        [ForeignKey(nameof(TeskilatId))]
        public Teskilat? Teskilat { get; set; }
        public int? XidmetQrupuId { get; set; }
        [ForeignKey(nameof(XidmetQrupuId))]
        public XidmetQrupu? XidmetQrupu { get; set; }
        public int? XidmetId { get; set; }
        [ForeignKey(nameof(XidmetId))]
        public Xidmet? Xidmet { get; set; }
        public double? Mebleg { get; set; }
        public double? Faizi { get; set; }
    }
}

using CleanArchitecture.Domain.Core;
using CleanArchitecture.Domain.Modules.Admin.Hekims;
using CleanArchitecture.Domain.Modules.Admin.XidmetQrupus;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanArchitecture.Domain.Modules.Admin.Sablons
{
    public sealed class Sablon : BaseEntity
    {
        public string Ad {  get; set; } = string.Empty;
        public int HekimId { get; set; }
        [ForeignKey(nameof(HekimId))]
        public Hekim? Hekim { get; set; }
        public int XidmetQrupuId { get; set; }
        [ForeignKey(nameof(XidmetQrupuId))]
        public XidmetQrupu? XidmetQrupu { get; set; }
        public string Data { get; set; } = string.Empty;
    }
}

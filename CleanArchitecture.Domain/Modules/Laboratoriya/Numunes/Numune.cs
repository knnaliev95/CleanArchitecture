using CleanArchitecture.Domain.Core;
using CleanArchitecture.Domain.Modules.Admin.XidmetQrupus;
using CleanArchitecture.Domain.Modules.Common.Pasients;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanArchitecture.Domain.Modules.Laboratoriya.Numunes
{
    public class Numune : BaseEntity
    {
        public int PasientId { get; set; }
        [ForeignKey(nameof(PasientId))]
        public Pasient? Pasient { get; set; }
        public int XidmetQrupuId { get; set; }
        [ForeignKey(nameof(XidmetQrupuId))]
        public XidmetQrupu? XidmetQrupu { get; set; }
    }
}

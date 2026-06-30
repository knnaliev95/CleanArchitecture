using CleanArchitecture.Domain.Core;
using CleanArchitecture.Domain.Modules.Admin.Hekims;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanArchitecture.Domain.Modules.Common.OdenenFaizlers
{
    public class OdenenFaizler : BaseEntity
    {
        public int HekimId { get; set; }
        [ForeignKey(nameof(HekimId))]
        public Hekim? Hekim { get; set; }
        public double Mebleg {  get; set; }
        public DateOnly Tarix { get; set; }
    }
}

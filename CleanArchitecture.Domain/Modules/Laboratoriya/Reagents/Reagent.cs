using CleanArchitecture.Domain.Core;
using CleanArchitecture.Domain.Modules.Laboratoriya.Cihazs;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanArchitecture.Domain.Modules.Laboratoriya.Reagents
{
    public class Reagent : BaseEntity
    {
        public int CihazId { get; set; }
        [ForeignKey(nameof(CihazId))]
        public Cihaz? Cihaz { get; set; }
        public string LotNumber { get; set; } = string.Empty;
        public DateTime? BitmeTarixi { get; set; }
    }
}

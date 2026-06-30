using CleanArchitecture.Domain.Core;
using CleanArchitecture.Domain.Modules.Admin.Sobeler;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanArchitecture.Domain.Modules.Aptek.Telebnames
{
    public class Telebname : BaseEntity
    {
        public int SobeId { get; set; }
        [ForeignKey(nameof(SobeId))]
        public Sobe? Sobe { get; set; }
        public bool Tesdiq { get; set; } = false;
        public bool Legv { get; set; } = false;
        public DateOnly Tarix { get; set; } = DateOnly.FromDateTime(DateTime.Now);
    }
}

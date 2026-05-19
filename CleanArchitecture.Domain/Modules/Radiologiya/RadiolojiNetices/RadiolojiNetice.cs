using CleanArchitecture.Domain.Core;
using CleanArchitecture.Domain.Modules.Ambulator.AmbulatorXidmets;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanArchitecture.Domain.Modules.Radiologiya.RadiolojiNetices
{
    public class RadiolojiNetice : BaseEntity
    {
        public int XidmetId { get; set; }
        [ForeignKey(nameof(XidmetId))]
        public AmbulatorXidmet? Xidmet { get; set; }
        public string Netice { get; set; } = string.Empty;
        public bool Tesdiq { get; set; } = true;
        public DateTime Tarix { get; set; } = DateTime.Now;
    }
}

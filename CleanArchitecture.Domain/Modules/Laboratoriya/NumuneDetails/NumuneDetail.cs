using CleanArchitecture.Domain.Core;
using CleanArchitecture.Domain.Modules.Ambulator.AmbulatorXidmets;
using CleanArchitecture.Domain.Modules.Laboratoriya.Numunes;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanArchitecture.Domain.Modules.Laboratoriya.NumuneDetails
{
    public class NumuneDetail : BaseEntity
    {
        public int NumuneId { get; set; }
        [ForeignKey(nameof(NumuneId))]
        public Numune? Numune { get; set; }
        public int AXidmetId { get; set; }
        [ForeignKey(nameof(AXidmetId))]
        public AmbulatorXidmet? AmbulatorXidmet { get; set; }
    }
}

using CleanArchitecture.Domain.Core;
using CleanArchitecture.Domain.Modules.Admin.Teskilats;
using CleanArchitecture.Domain.Modules.Common.Pasients;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanArchitecture.Domain.Modules.Ambulator.AmbulatorMuraciets
{
    public sealed class AmbulatorMuraciet : BaseEntity
    {
        public int PasientId { get; set; }
        [ForeignKey(nameof(PasientId))]
        public Pasient? Pasient { get; set; }
        public int TeskilatId { get; set; }
        [ForeignKey(nameof(TeskilatId))]
        public Teskilat? Teskilat { get; set; }
        public DateOnly Tarix {  get; set; }
    }
}

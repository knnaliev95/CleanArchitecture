using CleanArchitecture.Domain.Core;
using CleanArchitecture.Domain.Modules.Accounts.Users;
using CleanArchitecture.Domain.Modules.Admin.Hekims;
using CleanArchitecture.Domain.Modules.Admin.MuracietSebebis;
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
        public int MuracietSebebiId { get; set; }
        [ForeignKey(nameof(MuracietSebebiId))]
        public MuracietSebebi? MuracietSebebi { get; set; }
        public int? GonderenId { get; set; }
        [ForeignKey(nameof(GonderenId))]
        public Hekim? Gonderen { get; set; }
        public int HekimId { get; set; }
        [ForeignKey(nameof(HekimId))]
        public Hekim? Hekim { get; set; }
        public DateOnly Tarix {  get; set; }
        public DateTime Saat {  get; set; }
        public int UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public AppUser? User { get; set; }
    }
}

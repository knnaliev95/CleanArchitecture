using CleanArchitecture.Domain.Core;
using CleanArchitecture.Domain.Modules.Accounts.Users;
using CleanArchitecture.Domain.Modules.Admin.EndirimTipis;
using CleanArchitecture.Domain.Modules.Admin.Hekims;
using CleanArchitecture.Domain.Modules.Admin.Xidmets;
using CleanArchitecture.Domain.Modules.Ambulator.AmbulatorMuraciets;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanArchitecture.Domain.Modules.Ambulator.AmbulatorXidmets
{
    public class AmbulatorXidmet : BaseEntity
    {
        public int MuracietId { get; set; }
        [ForeignKey(nameof(MuracietId))]
        public AmbulatorMuraciet? Muraciet { get; set; }
        public int XidmetId { get; set; }
        [ForeignKey(nameof(XidmetId))]
        public Xidmet? Xidmet { get; set; }
        public int HekimId { get; set; }
        [ForeignKey(nameof(HekimId))]
        public Hekim? Hekim { get; set; }
        public double Qiymet {  get; set; }
        public double Mebleg {  get; set; }
        public int? EndirimTipiId { get; set; }
        [ForeignKey(nameof(EndirimTipiId))]
        public EndirimTipi? EndirimTipi { get; set; }
        public double? EndirimMeblegi { get; set; }
        public double? EndirimFaizi { get; set; }
        public bool Barkod { get; set; } = false;
        public bool Netice { get; set; } = false;
        public DateOnly Tarix { get; set; }
        public TimeOnly Saat { get; set; }
        public int? Sira { get; set; }
        public int? AnestezioloqId { get; set; }
        [ForeignKey("AnestezioloqId")]
        public Hekim? Anestezioloq { get; set; }
        public string? AnesteziyaNovu { get; set; }
        public int UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public AppUser? User { get; set; }
    }
}

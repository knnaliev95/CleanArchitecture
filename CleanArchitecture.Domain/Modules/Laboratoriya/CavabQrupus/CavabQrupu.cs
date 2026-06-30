using CleanArchitecture.Domain.Core;

namespace CleanArchitecture.Domain.Modules.Laboratoriya.CavabQrupus
{
    public class CavabQrupu : BaseEntity
    {
        public string Ad {  get; set; } = string.Empty;
        public int? CapSirasi { get; set; }
    }
}

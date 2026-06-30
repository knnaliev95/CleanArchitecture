using CleanArchitecture.Domain.Core;

namespace CleanArchitecture.Domain.Modules.Teserrufat.TTedarukcus
{
    public class TTedarukcu : BaseEntity
    {
        public string Ad { get; set; } = string.Empty;
        public string Telefon { get; set; } = string.Empty;
    }
}

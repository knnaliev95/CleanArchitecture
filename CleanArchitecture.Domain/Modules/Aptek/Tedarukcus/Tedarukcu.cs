using CleanArchitecture.Domain.Core;

namespace CleanArchitecture.Domain.Modules.Aptek.Tedarukcus
{
    public class Tedarukcu : BaseEntity
    {
        public string Ad { get; set; } = string.Empty;
        public string Telefon { get; set; } = string.Empty;
    }
}

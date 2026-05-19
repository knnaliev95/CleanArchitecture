using CleanArchitecture.Domain.Core;

namespace CleanArchitecture.Domain.Modules.Laboratoriya.Tubes
{
    public class Tube : BaseEntity
    {
        public string Ad {  get; set; } = string.Empty;
        public int? Kod { get; set; }
        public string Reng { get; set; } = string.Empty;
        public int BarkodSayi { get; set; }
    }
}

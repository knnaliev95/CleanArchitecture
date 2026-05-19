using CleanArchitecture.Domain.Core;

namespace CleanArchitecture.Domain.Modules.Admin.Diaqnozs
{
    public sealed class Diaqnoz : BaseEntity
    {
        public string Kod { get; set; } = string.Empty;
        public string Aciqlama {  get; set; } = string.Empty;
    }
}

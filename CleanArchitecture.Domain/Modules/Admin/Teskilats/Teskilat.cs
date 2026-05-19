using CleanArchitecture.Domain.Core;

namespace CleanArchitecture.Domain.Modules.Admin.Teskilats
{
    public sealed class Teskilat: BaseEntity
    {
        public string Ad { get; set; } = string.Empty;
    }
}

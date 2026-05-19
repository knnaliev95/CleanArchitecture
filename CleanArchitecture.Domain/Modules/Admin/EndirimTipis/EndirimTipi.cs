using CleanArchitecture.Domain.Core;

namespace CleanArchitecture.Domain.Modules.Admin.EndirimTipis
{
    public sealed class EndirimTipi : BaseEntity
    {
        public string Ad {  get; set; } = string.Empty;
    }
}

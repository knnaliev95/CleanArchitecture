using CleanArchitecture.Domain.Core;

namespace CleanArchitecture.Domain.Modules.Admin.Sobeler
{
    public sealed class Sobe : BaseEntity
    {
        public string Ad {  get; set; }
        public bool? IsAmbulator {  get; set; }
        public bool? IsStasionar { get; set; }
    }
}

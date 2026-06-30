using CleanArchitecture.Domain.Core;
using CleanArchitecture.Domain.Modules.Aptek.Tedarukcus;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanArchitecture.Domain.Modules.Aptek.Qaimes
{
    public class Qaime : BaseEntity
    {
        public string Nomre { get; set; } = string.Empty;
        public DateOnly Tarix { get; set; }
        public int TedarukcuId { get; set; }
        [ForeignKey(nameof(TedarukcuId))]
        public Tedarukcu? Tedarukcu { get; set; }
    }
}

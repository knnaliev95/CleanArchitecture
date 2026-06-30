using CleanArchitecture.Domain.Core;
using CleanArchitecture.Domain.Modules.Teserrufat.TTedarukcus;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanArchitecture.Domain.Modules.Teserrufat.TQaimes
{
    public class TQaime : BaseEntity
    {
        public string Nomre { get; set; } = string.Empty;
        public DateOnly Tarix { get; set; }
        public int TedarukcuId { get; set; }
        [ForeignKey(nameof(TedarukcuId))]
        public TTedarukcu? Tedarukcu { get; set; }
    }
}

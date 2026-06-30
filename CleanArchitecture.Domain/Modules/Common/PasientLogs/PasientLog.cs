using CleanArchitecture.Domain.Core;
using CleanArchitecture.Domain.Modules.Common.Pasients;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanArchitecture.Domain.Modules.Common.PasientLogs
{
    public class PasientLog : BaseEntity
    {
        public int PasientId { get; set; }
        [ForeignKey(nameof(PasientId))]
        public Pasient? Pasient { get; set; }
        public string Qeyd { get; set; } = string.Empty;
        public DateTime Tarix { get; set; }
    }
}

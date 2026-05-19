using CleanArchitecture.Domain.Core;
using CleanArchitecture.Domain.Modules.Common.Pasients;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanArchitecture.Domain.Modules.Common.Kassas
{
    public class Kassa : BaseEntity
    {
        public int PasientId { get; set; }
        [ForeignKey(nameof(PasientId))]
        public Pasient? Pasient { get; set; }
        public double Mebleg {  get; set; }
        public bool Status { get; set; } = false;
        public string OdenisNovu { get; set; } = string.Empty;
        public DateOnly? OdenisTarixi { get; set; }
    }
}

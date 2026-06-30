using CleanArchitecture.Domain.Core;
using CleanArchitecture.Domain.Modules.Aptek.Stocks;
using CleanArchitecture.Domain.Modules.Common.Pasients;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanArchitecture.Domain.Modules.Aptek.SobeMexarics
{
    public class SobeMexaric : BaseEntity
    {
        public int? PasientId { get; set; }
        [ForeignKey(nameof(PasientId))]
        public Pasient? Pasient { get; set; }
        public int StockId { get; set; }
        [ForeignKey(nameof(StockId))]
        public Stock? Stock { get; set; }
        public double Miqdar {  get; set; }
        public DateTime Tarix { get; set; } = DateTime.Now;
    }
}

using CleanArchitecture.Domain.Core;
using CleanArchitecture.Domain.Modules.Common.Pasients;
using CleanArchitecture.Domain.Modules.Teserrufat.TStocks;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanArchitecture.Domain.Modules.Teserrufat.TSobeMexarics
{
    public class TSobeMexaric : BaseEntity
    {
        public int? PasientId { get; set; }
        [ForeignKey(nameof(PasientId))]
        public Pasient? Pasient { get; set; }
        public int StockId { get; set; }
        [ForeignKey(nameof(StockId))]
        public TStock? Stock { get; set; }
        public double Miqdar {  get; set; }
        public DateTime Tarix { get; set; } = DateTime.Now;
    }
}

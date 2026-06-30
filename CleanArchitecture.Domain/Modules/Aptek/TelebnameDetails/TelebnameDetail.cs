using CleanArchitecture.Domain.Core;
using CleanArchitecture.Domain.Modules.Aptek.Stocks;
using CleanArchitecture.Domain.Modules.Aptek.Telebnames;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanArchitecture.Domain.Modules.Aptek.TelebnameDetails
{
    public class TelebnameDetail : BaseEntity
    {
        public int TelebnameId { get; set; }
        [ForeignKey(nameof(TelebnameId))]
        public Telebname? Telebname { get; set; }
        public int StockId { get; set; }
        public Stock? Stock { get; set; }
        public double TelebMiqdari { get; set; }
        public double BuraxilanMiqdar { get; set; }
    }
}

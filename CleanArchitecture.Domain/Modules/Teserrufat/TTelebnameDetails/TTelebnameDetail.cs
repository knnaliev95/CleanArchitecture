using CleanArchitecture.Domain.Core;
using CleanArchitecture.Domain.Modules.Teserrufat.TStocks;
using CleanArchitecture.Domain.Modules.Teserrufat.TTelebnames;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanArchitecture.Domain.Modules.Teserrufat.TTelebnameDetails
{
    public class TTelebnameDetail : BaseEntity
    {
        public int TelebnameId { get; set; }
        [ForeignKey(nameof(TelebnameId))]
        public TTelebname? Telebname { get; set; }
        public int StockId { get; set; }
        public TStock? Stock { get; set; }
        public double TelebMiqdari { get; set; }
        public double BuraxilanMiqdar { get; set; }
    }
}

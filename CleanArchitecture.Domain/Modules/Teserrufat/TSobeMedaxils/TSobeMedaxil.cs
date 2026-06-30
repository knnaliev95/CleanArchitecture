using CleanArchitecture.Domain.Core;
using CleanArchitecture.Domain.Modules.Admin.Sobeler;
using CleanArchitecture.Domain.Modules.Teserrufat.TStocks;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanArchitecture.Domain.Modules.Teserrufat.TSobeMedaxils
{
    public class TSobeMedaxil : BaseEntity
    {
        public int SobeId { get; set; }
        [ForeignKey(nameof(SobeId))]
        public Sobe? Sobe { get; set; }
        public int StockId { get; set; }
        [ForeignKey(nameof(StockId))]
        public TStock? Stock { get; set; }
        public double Miqdar { get; set; }
        public DateTime Tarix { get; set; } = DateTime.Now;
    }
}

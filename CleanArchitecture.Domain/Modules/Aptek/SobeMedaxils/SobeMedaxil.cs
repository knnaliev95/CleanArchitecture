using CleanArchitecture.Domain.Core;
using CleanArchitecture.Domain.Modules.Admin.Sobeler;
using CleanArchitecture.Domain.Modules.Aptek.Stocks;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanArchitecture.Domain.Modules.Aptek.SobeMedaxils
{
    public class SobeMedaxil : BaseEntity
    {
        public int SobeId { get; set; }
        [ForeignKey(nameof(SobeId))]
        public Sobe? Sobe { get; set; }
        public int StockId { get; set; }
        [ForeignKey(nameof(StockId))]
        public Stock? Stock { get; set; }
        public double Miqdar { get; set; }
        public DateTime Tarix { get; set; } = DateTime.Now;
    }
}

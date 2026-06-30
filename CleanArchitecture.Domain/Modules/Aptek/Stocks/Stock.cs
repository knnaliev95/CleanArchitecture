using CleanArchitecture.Domain.Core;
using CleanArchitecture.Domain.Modules.Aptek.OlcuVahidis;
using CleanArchitecture.Domain.Modules.Aptek.Sinifs;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanArchitecture.Domain.Modules.Aptek.Stocks
{
    public class Stock : BaseEntity
    {
        public string Ad { get; set; } = string.Empty;
        public int SinifId { get; set; }
        [ForeignKey(nameof(SinifId))]
        public Sinif? Sinif { get; set; }
        public int OlcuVahidiId { get; set; }
        [ForeignKey(nameof(OlcuVahidiId))]
        public OlcuVahidi? OlcuVahidi { get; set; }
        public int CixisVahidiId { get; set; }
        [ForeignKey(nameof(CixisVahidiId))]
        public OlcuVahidi? CixisVahidi { get; set; }
        public double Miqdar { get; set; }
        public double QutuMiqdari { get; set; }
        public double Qiymet { get; set; }
        public double? Edv { get; set; }
        public double Mebleg { get; set; }
        public double CixisQiymeti { get; set; }
    }
}

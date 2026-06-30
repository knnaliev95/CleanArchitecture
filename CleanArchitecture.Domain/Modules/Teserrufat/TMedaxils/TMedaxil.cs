using CleanArchitecture.Domain.Core;
using CleanArchitecture.Domain.Modules.Teserrufat.TOlcuVahidis;
using CleanArchitecture.Domain.Modules.Teserrufat.TSinifs;
using CleanArchitecture.Domain.Modules.Teserrufat.TQaimes;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanArchitecture.Domain.Modules.Teserrufat.TMedaxils
{
    public class TMedaxil : BaseEntity
    {
        public int QaimeId { get; set; }
        [ForeignKey(nameof(QaimeId))]
        public TQaime? Qaime { get; set; }
        public string Ad {  get; set; } = string.Empty;
        public int SinifId { get; set; }
        [ForeignKey(nameof(SinifId))]
        public TSinif? Sinif { get; set; }
        public int OlcuVahidiId { get; set; }
        [ForeignKey(nameof(OlcuVahidiId))]
        public TOlcuVahidi? OlcuVahidi { get; set; }
        public int CixisVahidiId { get; set; }
        [ForeignKey(nameof(CixisVahidiId))]
        public TOlcuVahidi? CixisVahidi { get; set; }
        public double Miqdar {  get; set; }
        public double QutuMiqdari { get; set; }
        public double Qiymet { get; set; }
        public double? Edv { get; set; }
        public double Mebleg { get; set; }
        public double CixisQiymeti { get; set; }
    }
}

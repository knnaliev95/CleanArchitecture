using CleanArchitecture.Domain.Core;
using CleanArchitecture.Domain.Modules.Common.Pasients;
using CleanArchitecture.Domain.Modules.Laboratoriya.Parametrs;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanArchitecture.Domain.Modules.Laboratoriya.LisNetices
{
    public class LisNetice : BaseEntity
    {
        public int NumuneId { get; set; }
        [ForeignKey(nameof(NumuneId))]
        public int PasientId { get; set; }
        [ForeignKey(nameof(PasientId))]
        public Pasient? Pasient { get; set; }
        public int ParametrId { get; set; }
        [ForeignKey(nameof(ParametrId))]
        public Parametr? Parametr { get; set; }
        public string Netice {  get; set; } = string.Empty;
        public string Referans {  get; set; } = string.Empty;
        public DateTime ElaveEdilmeTarixi { get; set; } = DateTime.Now;
        public DateTime TesdiqlenmeTarixi { get; set; }
        public NeticeStatusu Status { get; set; } = NeticeStatusu.Unknown;
    }

    public enum NeticeStatusu
    {
        Normal = 0,
        Low = 1,
        High = 2,
        Unknown = 3
    }
}

using CleanArchitecture.Domain.Core;
using CleanArchitecture.Domain.Modules.Laboratoriya.Cihazs;
using CleanArchitecture.Domain.Modules.Laboratoriya.Parametrs;
using CleanArchitecture.Domain.Modules.Laboratoriya.Reagents;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanArchitecture.Domain.Modules.Laboratoriya.Referanses
{
    public class Referans : BaseEntity
    {
        public int? CihazId { get; set; }
        [ForeignKey(nameof(CihazId))]
        public Cihaz? Cihaz { get; set; }
        public int? ReagentId { get; set; }
        [ForeignKey(nameof(ReagentId))]
        public Reagent? Reagent { get; set; }
        public int ParametrId { get; set; }
        [ForeignKey(nameof(ParametrId))]
        public Parametr? Parametr { get; set; }
        public Gender Cins { get; set; } = Gender.Both;
        public int MinYas { get; set; }
        public int MaxYas { get; set; }
        public double? MinQiymet { get; set; }
        public double? MaxQiymet { get; set; }
        public string? Norma { get; set; }
        public int? Priority { get; set; }
    }

    public enum Gender
    {
        Both = 0,
        Male = 1,
        Female = 2
    }
}

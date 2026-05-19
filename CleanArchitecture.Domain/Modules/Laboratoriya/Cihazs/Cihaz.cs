using CleanArchitecture.Domain.Core;

namespace CleanArchitecture.Domain.Modules.Laboratoriya.Cihazs
{
    public class Cihaz : BaseEntity
    {
        public string Ad {  get; set; } = string.Empty;
        public string? ComPort { get; set; }
        public string? IpAddress { get; set; }
        public int? BaudRate { get; set; }
        public int? DataBit { get; set; }
        public int? StopBit { get; set; }
    }
}

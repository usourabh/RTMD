using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RTMDOTProject.Models
{
    public partial class StreetLightDetail
    {
        public int StreetLightDetailId { get; set; }
        public string BV { get; set; }
        public string SV { get; set; }
        public string CC { get; set; }
        public string Temp { get; set; }
        public string LowBatteryFlag { get; set; }
        public string ChargingFlag { get; set; }
        public string ReserveByte1 { get; set; }
        public string ReserveByte2 { get; set; }
        public DateTime Tdate { get; set; }
        public string DeviceId { get; set; }
    }
}

using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RTMDOTProject.Models
{
    public partial class SmartLightDetail
    {
        public int SmartLightId { get; set; }
        public string DeviceId { get; set; }
        public string Status { get; set; }
        public DateTime Tdate { get; set; }
        public string Lat { get; set; }
        public string Lng { get; set; }
        public string BatteryVolt { get; set; }
        public string SolarVolt { get; set; }
        public string BatteryCharge { get; set; }
        public string BatteryDischarge { get; set; }
        public string SolarCharge { get; set; }
    }
}

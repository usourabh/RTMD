using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RTMDOTProject.Models
{
    public partial class FlowMeterTransaction
    {
        public int Fmtid { get; set; }
        public string DeviceId { get; set; }
        public string Velocity { get; set; }
        public string NetTotalizer { get; set; }
        public string TodayTotal { get; set; }
        public string MonthlyFlow { get; set; }
        public string FlowRate { get; set; }
        public string WorkingTimer { get; set; }
        public string WorkingTime { get; set; }
        public string TotalPower { get; set; }
        public DateTime Tdate { get; set; }
        public DateTime Dtime { get; set; }
        public string ExtVal { get; set; }
        public string DataMode { get; set; }
    }
}

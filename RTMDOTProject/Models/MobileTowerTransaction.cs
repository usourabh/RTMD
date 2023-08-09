using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RTMDOTProject.Models
{
    public partial class MobileTowerTransaction
    {
        public int MobileTransactionId { get; set; }
        public string DeviceId { get; set; }
        public string PhaseAvailability { get; set; }
        public string DgisOn { get; set; }
        public string DgOutput { get; set; }
        public string LowVoltageAlarms { get; set; }
        public string RoomTemperatureAlarms { get; set; }
        public string BatteryCharge { get; set; }
        public string FireAlarm { get; set; }
        public string LowFuelLevelAlarm { get; set; }
        public string NoFuelAlarm { get; set; }
        public string DbBatteryLowAlarm { get; set; }
        public string SiteDcLoad { get; set; }
        public string DoorOpenAlarm { get; set; }
        public DateTime TDate { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RTMDOTProject.Models
{
    public partial class BgpsTransaction
    {
        public int GpsTid { get; set; }
        public string Imei { get; set; }
        public string Speed { get; set; }
        public string Lat { get; set; }
        public string Lng { get; set; }
        public string Odo { get; set; }
        public string Ignition { get; set; }
        public string Ipower { get; set; }
        public string TempDetect { get; set; }
        public string FuelDetect { get; set; }
        public string VibAlarm { get; set; }
        public string OverSpeedAlarm { get; set; }
        public DateTime DatedOn { get; set; }
        public DateTime SyncOn { get; set; }
    }
}

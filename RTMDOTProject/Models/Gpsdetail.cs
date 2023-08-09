using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RTMDOTProject.Models
{
    public partial class Gpsdetail
    {
        public int GpsdetailId { get; set; }
        public string DeviceId { get; set; }
        public string Lat { get; set; }
        public string Lng { get; set; }
        public decimal Speed { get; set; }
        public string Status { get; set; }
        public DateTime TrackDate { get; set; }
        public DateTime CurrentDate { get; set; }
        public string Tdate { get; set; }
        public string Tutc { get; set; }
        public string Location { get; set; }
    }
}

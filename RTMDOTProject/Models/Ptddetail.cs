using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RTMDOTProject.Models
{
    public partial class Ptddetail
    {
        public int Ptdid { get; set; }
        public string DeviceId { get; set; }
        public string PhVal { get; set; }
        public string Temp { get; set; }
        public DateTime Tdate { get; set; }
        public string T1 { get; set; }
        public string Lat { get; set; }
        public string Lng { get; set; }
        public DateTime? DeviceDate { get; set; }
    }
}

using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RTMDOTProject.Models
{
    public partial class Dtutransaction
    {
        public int Dtuid { get; set; }
        public string DeviceId { get; set; }
        public string DataMode { get; set; }
        public string AlertMsg { get; set; }
        public string ExtVal { get; set; }
        public DateTime Dtime { get; set; }
        public DateTime Tdate { get; set; }
    }
}

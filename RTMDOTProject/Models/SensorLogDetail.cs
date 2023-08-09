using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RTMDOTProject.Models
{
    public partial class SensorLogDetail
    {
        public int Sldid { get; set; }
        public string InputData { get; set; }
        public DateTime Tdate { get; set; }
        public int DeviceTypeId { get; set; }
    }
}

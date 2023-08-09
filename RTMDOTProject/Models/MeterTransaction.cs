using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RTMDOTProject.Models
{
    public partial class MeterTransaction
    {
        public int Mtid { get; set; }
        public string ImeiNo { get; set; }
        public string Voltage { get; set; }
        public string Icurrent { get; set; }
        public string Frequency { get; set; }
        public string Pf { get; set; }
        public string ActivePower { get; set; }
        public string KwhMultiplier { get; set; }
        public string Kwh { get; set; }
        public string ReserveData1 { get; set; }
        public string ReserveData2 { get; set; }
        public DateTime Tdate { get; set; }
    }
}

using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RTMDOTProject.Models
{
    public partial class AlertsDetail
    {
        public int AlertId { get; set; }
        public int Tmpsid { get; set; }
        public decimal Temp { get; set; }
        public string Imei { get; set; }
        public string Value1 { get; set; }
        public string Value2 { get; set; }
        public string Value3 { get; set; }
        public DateTime Tdate { get; set; }
    }
}

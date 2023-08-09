using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RTMDOTProject.Models
{
    public partial class VwAlertTransaction
    {
        public int DeviceId { get; set; }
        public string Ieminumber { get; set; }
        public string DeviceType { get; set; }
        public string DeviceName { get; set; }
        public string MinimumValue { get; set; }
        public string MaximumValue { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Description { get; set; }
        public string DeviceNumber { get; set; }
        public string Branch { get; set; }
        public string RegionName { get; set; }
        public string Asmarea { get; set; }
        public string Soterritory { get; set; }
        public string Rdcode { get; set; }
        public string Rdname { get; set; }
        public string TownClassName { get; set; }
        public string Rdtown { get; set; }
        public string Imei { get; set; }
        public DateTime Tdate { get; set; }
        public decimal Temp { get; set; }
        public string DatedOn { get; set; }
    }
}

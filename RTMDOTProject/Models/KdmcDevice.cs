using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RTMDOTProject.Models
{
    public partial class KdmcDevice
    {
        public int KdmcDeviceId { get; set; }
        public string DeviceId { get; set; }
        public string DeviceType { get; set; }
        public string Location { get; set; }
        public string Lat { get; set; }
        public string Lng { get; set; }
        public bool Status { get; set; }
        public string DeviceTypeId { get; set; }
        public DateTime DateOfInstallation { get; set; }
        public bool? IsRain { get; set; }
    }
}

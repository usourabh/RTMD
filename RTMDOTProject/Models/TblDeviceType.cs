using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RTMDOTProject.Models
{
    public partial class TblDeviceType
    {
        public int DeviceTypeId { get; set; }
        public string DeviceName { get; set; }
        public string DeviceType { get; set; }
        public string Remarks { get; set; }
        public bool? IsPrimary { get; set; }
    }
}

using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RTMDOTProject.Models
{
    public partial class DeviceMaster
    {
        public int DeviceMasterId { get; set; }
        public int DeviceTypeId { get; set; }
        public string ImeiNo { get; set; }
        public string SerialNo { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
        public decimal? RangeMax { get; set; }
        public decimal? RangeMin { get; set; }
        public bool IsActive { get; set; }
        public string Lat { get; set; }
        public string Lng { get; set; }
        public string CreatedBy { get; set; }
    }
}

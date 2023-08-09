using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RTMDOTProject.Models
{
    public partial class GpsMaster
    {
        public int GpsMid { get; set; }
        public string ImeiNo { get; set; }
        public string ChasisNo { get; set; }
        public string EngineNo { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public string VehicleNo { get; set; }
    }
}

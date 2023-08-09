using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RTMDOTProject.Models
{
    public partial class MeterStatus
    {
        public int Msid { get; set; }
        public string ImeiNo { get; set; }
        public bool IsActive { get; set; }
        public string Status { get; set; }
        public DateTime LastUpdatedOn { get; set; }
    }
}

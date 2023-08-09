using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RTMDOTProject.Models
{
    public partial class Weight
    {
        public int Trno { get; set; }
        public string Vehicleno { get; set; }
        public double? Firstweight { get; set; }
        public DateTime? Dateout { get; set; }
        public DateTime? Timeout { get; set; }
        public double? Secondweight { get; set; }
        public string SiteId { get; set; }
        public int? NetWt { get; set; }
    }
}

using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RTMDOTProject.Models
{
    public partial class MeterReadingDetail
    {
        public int ReadingId { get; set; }
        public decimal GridReading { get; set; }
        public decimal DgReading { get; set; }
        public DateTime LastUpdatedOn { get; set; }
        public string DeviceId { get; set; }
    }
}

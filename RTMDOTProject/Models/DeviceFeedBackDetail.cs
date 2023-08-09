using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RTMDOTProject.Models
{
    public partial class DeviceFeedBackDetail
    {
        public int FeedBackDetailId { get; set; }
        public string DeviceId { get; set; }
        public DateTime Tdate { get; set; }
        public string Status { get; set; }
    }
}

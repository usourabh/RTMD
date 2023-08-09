using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RTMDOTProject.Models
{
    public partial class TblVoltage
    {
        public int Id { get; set; }
        public string DeviceId { get; set; }
        public bool? Buttonstatus { get; set; }
        public string Batteryvoltage { get; set; }
        public DateTime? Datet { get; set; }
    }
}

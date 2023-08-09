using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RTMDOTProject.Models
{
    public partial class DeviceAssociation
    {
        public int DeviceAssociationId { get; set; }
        public string PrimaryDeviceId { get; set; }
        public int DeviceId { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public bool IsAssociated { get; set; }
    }
}

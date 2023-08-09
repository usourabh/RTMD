using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RTMDOTProject.Models
{
    public partial class UserDetail
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public int SocietyId { get; set; }
        public string FlatNo { get; set; }
        public DateTime LastRecharge { get; set; }
        public decimal CurrentBalance { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string DeviceId { get; set; }
    }
}

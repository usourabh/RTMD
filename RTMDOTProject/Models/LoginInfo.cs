using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RTMDOTProject.Models
{
    public partial class LoginInfo
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public int? LoginFailedCount { get; set; }
        public string LoginIpaddress { get; set; }
        public string CustomerTimeZone { get; set; }
        public DateTime? LastAccessedDate { get; set; }
        public bool? AccountLocked { get; set; }
    }
}

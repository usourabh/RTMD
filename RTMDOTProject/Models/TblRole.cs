using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RTMDOTProject.Models
{
    public partial class TblRole
    {
        public int FnRoleId { get; set; }
        public string FtRoleName { get; set; }
        public bool FbIsActive { get; set; }
        public string Ccode { get; set; }
    }
}

using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RTMDOTProject.Models
{
    public partial class TblSubMenuInRole
    {
        public int FnSubmenuInRoleId { get; set; }
        public int FnCompanyId { get; set; }
        public int FnSubMenuId { get; set; }
        public int FnRoleId { get; set; }
        public bool FbIsAllow { get; set; }
        public bool FbIsAllowAdd { get; set; }
        public bool FbIsAllowEdit { get; set; }
        public bool FbIsAllowDelete { get; set; }
    }
}

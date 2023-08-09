using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RTMDOTProject.Models
{
    public partial class TblSubMenu
    {
        public int FnSubMenuId { get; set; }
        public int FnMenuId { get; set; }
        public string FtSubMenuName { get; set; }
        public int FnOrderId { get; set; }
        public string FtControllerName { get; set; }
        public string FtActionName { get; set; }
        public string FtArea { get; set; }
        public string FtScssIcon { get; set; }
        public bool FbIsActive { get; set; }
    }
}

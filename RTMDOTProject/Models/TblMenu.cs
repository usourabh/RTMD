using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RTMDOTProject.Models
{
    public partial class TblMenu
    {
        public int FnMenuId { get; set; }
        public int FnParentId { get; set; }
        public string FtMenuName { get; set; }
        public int FnOrderId { get; set; }
        public string FtMcssIcon { get; set; }
        public bool FbIsActive { get; set; }
    }
}

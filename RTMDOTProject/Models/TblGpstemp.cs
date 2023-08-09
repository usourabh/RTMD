using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RTMDOTProject.Models
{
    public partial class TblGpstemp
    {
        public int TblId { get; set; }
        public string LatText { get; set; }
        public string LangText { get; set; }
        public DateTime? Dated { get; set; }
    }
}

using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RTMDOTProject.Models
{
    public partial class CircleMaster
    {
        public int CircleId { get; set; }
        public string CircleName { get; set; }
        public bool IsActive { get; set; }
        public string Ccode { get; set; }
    }
}

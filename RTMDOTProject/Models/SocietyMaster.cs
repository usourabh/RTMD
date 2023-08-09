using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RTMDOTProject.Models
{
    public partial class SocietyMaster
    {
        public int SocietyId { get; set; }
        public string SocietyName { get; set; }
        public bool IsActive { get; set; }
    }
}

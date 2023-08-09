using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RTMDOTProject.Models
{
    public partial class RdMaster
    {
        public int Id { get; set; }
        public string Rdcode { get; set; }
        public string Rdname { get; set; }
        public string Rdtype { get; set; }
        public string Town { get; set; }
        public string State { get; set; }
        public string Soterritory { get; set; }
        public string Asmarea { get; set; }
        public string RegionName { get; set; }
        public string BranchName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string ContactPerson { get; set; }
        public string MobileNo { get; set; }
        public string EmailId { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}

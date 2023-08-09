using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RTMDOTProject.Models
{
    public partial class QrMaster
    {
        public int Id { get; set; }
        public string Qrid { get; set; }
        public string TextHeader { get; set; }
        public string TextBody { get; set; }
        public string ImageUrl { get; set; }
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string Rdtype { get; set; }
        public string State { get; set; }
        public string Asmarea { get; set; }
        public string RegionName { get; set; }
        public string BranchName { get; set; }
        public string Rdname { get; set; }
        public string Address { get; set; }
    }
}

using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RTMDOTProject.Models
{
    public partial class UhfTransaction
    {
        public int Uhftid { get; set; }
        public string TagId { get; set; }
        public string ImeiNo { get; set; }
        public string Lat { get; set; }
        public string Lng { get; set; }
        public DateTime Tdate { get; set; }
        public string UserId { get; set; }
    }
}

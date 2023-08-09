using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RTMDOTProject.Models
{
    public partial class SurveyTransaction
    {
        public int Id { get; set; }
        public string DeviceCode { get; set; }
        public string Rdcode { get; set; }
        public string Lat { get; set; }
        public string Lng { get; set; }
        public string ApprovedBy { get; set; }
        public string ApprovedPersonMobileNo { get; set; }
        public string Remark { get; set; }
        public string Img1 { get; set; }
        public string Img2 { get; set; }
        public string Img3 { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}

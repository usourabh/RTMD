using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RTMDOTProject.Models
{
    public partial class TblRegistration
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public DateTime? Dob { get; set; }
        public string Gmail { get; set; }
        public string Mobile { get; set; }
        public string Pass { get; set; }
        public string Confpass { get; set; }
    }
}

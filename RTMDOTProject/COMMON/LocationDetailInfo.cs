using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RTMDOTProject.COMMON
{
    public class LocationDetailInfo
    {
        public int ContactId { get; set; }
        public string ContactPersonName { get; set; }
        public string ContactPersonNumber { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Pin { get; set; }
        public string Country { get; set; }
        public string Descriptions { get; set; }
    }
}

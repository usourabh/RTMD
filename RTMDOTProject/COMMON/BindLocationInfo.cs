using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RTMDOTProject.COMMON
{
    public class BindLocationInfo
    {
        public int BindId { get; set; }
        public int? ContactId { get; set; }
        public int? DeviceId { get; set; }
        public string Remarks { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }

       
    }

    public class BindLocation1
    {
       
        public string DeviceName { get; set; }
        public string lat { get; set; }
        public string lng { get; set; }
        public string contactpersonname { get; set; }


    }
}

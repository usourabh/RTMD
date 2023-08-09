using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RTMDOTProject.COMMON
{
    public class DeviceAssoinfo
    {
        public int DeviceAssociationId { get; set; }
        public string PrimaryDeviceId { get; set; }
        public int DeviceId { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public bool IsAssociated { get; set; }
    }
}

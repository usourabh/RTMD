using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RTMDOTProject.COMMON
{
    public class QrInfo
    {
        public int Id { get; set; }
        public string QRId { get; set; }
        public string TextHeader { get; set; }
        public string TextBody { get; set; }
        public string ImageUrl { get; set; }
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

    }
}

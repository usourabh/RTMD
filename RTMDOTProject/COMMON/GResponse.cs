using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RTMDOTProject.COMMON
{
    public class GResposnse
    {
        [Key]
        public int Result { get; set; }
        public string Msg { get; set; }
        public string Code { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RTMDOTProject.COMMON
{
    public class UserLoginInfo
    {
        public int Result { get; set; }
        public string Msg { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string LoginId { get; set; }
        public string FullName { get; set; }
        public string CCode { get; set; }
        public int LevelId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RTMDOTProject.COMMON
{
    public class SencerData
    {
        public int id { get; set; }
        public string Imei { get; set; }
        public string Temp { get; set; }
        public string DatedOn { get; set; }
    }
    public class SencerData1
    {    
       
        public string Temp { get; set; }
        public string DatedOn { get; set; }
    }

    public class tmdata
    {
        public string Imei { get; set; }
        public string Temp { get; set; }
        public string DatedOn { get; set; }
        public DateTime TDate { get; set; }
        public string DeviceName { get; set; }
        public string DeviceType { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
    }
    public class graphdata
    {
        
        public string Temp { get; set; }
        public string DatedOn { get; set; }
        
    }
}

using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RTMDOTProject.Models
{
    public partial class TblTakyAlert
    {
        public int TakyId { get; set; }
        public string ImeiNo { get; set; }
        public int? PacketType { get; set; }
        public int? ButtonId { get; set; }
        public int? LoctionType { get; set; }
        public string Loction { get; set; }
        public string Lat { get; set; }
        public string Long { get; set; }
        public string Speed { get; set; }
        public string BattryVolt { get; set; }
        public string ReservedData1 { get; set; }
        public string ReservedData2 { get; set; }
        public string ReservedData3 { get; set; }
        public DateTime? DateT { get; set; }
    }
}

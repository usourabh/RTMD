using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RTMDOTProject.Models
{
    public partial class EnergyMonitorDetail
    {
        public int EnergyId { get; set; }
        public string DeviceId { get; set; }
        public string RphaseVolt { get; set; }
        public string YphaseVolt { get; set; }
        public string BphaseVolt { get; set; }
        public string RphaseCurnt { get; set; }
        public string YphaseCurnt { get; set; }
        public string BphaseCurnt { get; set; }
        public string RphaseKw { get; set; }
        public string YphaseKw { get; set; }
        public string BphaseKw { get; set; }
        public string TotalKwhUnit { get; set; }
        public string TotalKwhLoad { get; set; }
        public string PwrFactor { get; set; }
        public string PresentFrqncy { get; set; }
        public int TypeOfData { get; set; }
        public string FuelSensor1Val { get; set; }
        public string FuelSensor2Val { get; set; }
        public string Reserved1 { get; set; }
        public string Reserved2 { get; set; }
        public DateTime Tdate { get; set; }
        public int? TypeId { get; set; }
        public string DgUnit { get; set; }
    }
}

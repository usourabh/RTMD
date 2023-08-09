using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RTMDOTProject.Models
{
    public partial class SensorMaster
    {
        public int Smid { get; set; }
        public string ImeiNo { get; set; }
        public bool IsActive { get; set; }
        public string Location { get; set; }
        public string Lat { get; set; }
        public string Lng { get; set; }
        public DateTime DateOfInstallation { get; set; }
        public DateTime? DateOfExpiry { get; set; }
        public double? Pm10thval { get; set; }
        public string Pm10unit { get; set; }
        public double? Pm25thval { get; set; }
        public string Pm25unit { get; set; }
        public double? Vocthval { get; set; }
        public string Vocunit { get; set; }
        public double? Co2thval { get; set; }
        public string Co2unit { get; set; }
        public double? HumidityThval { get; set; }
        public string HumidityUnit { get; set; }
        public double? TempThval { get; set; }
        public string TempUnit { get; set; }
        public double? So2thval { get; set; }
        public string So2unit { get; set; }
        public double? No2thval { get; set; }
        public string No2unit { get; set; }
        public double? O3thval { get; set; }
        public string O3unit { get; set; }
        public double? Cothval { get; set; }
        public string Counit { get; set; }
        public double? NoiseThval { get; set; }
        public string NoiseUnit { get; set; }
        public double? Uvthval { get; set; }
        public string Uvunit { get; set; }
        public double? LightThval { get; set; }
        public string LightUnit { get; set; }
        public double? Ch2othval { get; set; }
        public string Ch2ounit { get; set; }
    }
}

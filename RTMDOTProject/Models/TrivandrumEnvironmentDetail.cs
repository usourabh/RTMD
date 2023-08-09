using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RTMDOTProject.Models
{
    public partial class TrivandrumEnvironmentDetail
    {
        public int EnvId { get; set; }
        public string DeviceId { get; set; }
        public string Pm10 { get; set; }
        public string Pm25 { get; set; }
        public string Voc { get; set; }
        public string Co2 { get; set; }
        public string Humidity { get; set; }
        public string Temperature { get; set; }
        public string Aqi { get; set; }
        public DateTime Timstamp { get; set; }
        public string So2 { get; set; }
        public string No2 { get; set; }
        public string O3 { get; set; }
        public string Co { get; set; }
        public string Noise { get; set; }
        public string Uv { get; set; }
        public DateTime SyncOn { get; set; }
        public string BatteryLevel { get; set; }
        public string Rain { get; set; }
        public string AlertDesc { get; set; }
        public string WindSpeed { get; set; }
        public string Light { get; set; }
    }
}

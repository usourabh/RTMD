using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RTMDOTProject.Models
{
    public partial class AjeeviOperationDetail
    {
        public int Aodid { get; set; }
        public string OperationType { get; set; }
        public int TsrefId { get; set; }
        public string VehicleNo { get; set; }
        public string VehicleType { get; set; }
        public string ContainerCode { get; set; }
        public string ContainerType { get; set; }
        public int Tsid { get; set; }
        public string Tsname { get; set; }
        public string Tszone { get; set; }
        public string Tscircle { get; set; }
        public string Tsward { get; set; }
        public DateTime Tdate { get; set; }
        public string Status { get; set; }
        public DateTime Syncon { get; set; }
        public string CreatedBy { get; set; }
        public bool IsSynced { get; set; }
        public DateTime? SyncedOutOn { get; set; }
        public int? TRno { get; set; }
        public int? OperationTypeId { get; set; }
    }
}

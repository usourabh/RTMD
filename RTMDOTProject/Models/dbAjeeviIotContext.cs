using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RTMDOTProject.Models
{
    public partial class dbAjeeviIotContext : DbContext
    {
        public dbAjeeviIotContext()
        {
        }

        public dbAjeeviIotContext(DbContextOptions<dbAjeeviIotContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AjeeviOperationDetail> AjeeviOperationDetail { get; set; }
        public virtual DbSet<BgpsTransaction> BgpsTransaction { get; set; }
        public virtual DbSet<DeviceFeedBackDetail> DeviceFeedBackDetail { get; set; }
        public virtual DbSet<DigiLockTrans> DigiLockTrans { get; set; }
        public virtual DbSet<Dtutransaction> Dtutransaction { get; set; }
        public virtual DbSet<EnergyMonitorDetail> EnergyMonitorDetail { get; set; }
        public virtual DbSet<EntityFuelDetail> EntityFuelDetail { get; set; }
        public virtual DbSet<EnvironmentDetail> EnvironmentDetail { get; set; }
        public virtual DbSet<FlowMeterTransaction> FlowMeterTransaction { get; set; }
        public virtual DbSet<FuelLevelDetail> FuelLevelDetail { get; set; }
        public virtual DbSet<GpsMaster> GpsMaster { get; set; }
        public virtual DbSet<GpsRamkyTransaction> GpsRamkyTransaction { get; set; }
        public virtual DbSet<GpsTransaction> GpsTransaction { get; set; }
        public virtual DbSet<Gpsdetail> Gpsdetail { get; set; }
        public virtual DbSet<KdmcDevice> KdmcDevice { get; set; }
        public virtual DbSet<LoginInfo> LoginInfo { get; set; }
        public virtual DbSet<MeterReadingDetail> MeterReadingDetail { get; set; }
        public virtual DbSet<MeterStatus> MeterStatus { get; set; }
        public virtual DbSet<MeterTransaction> MeterTransaction { get; set; }
        public virtual DbSet<MobileTowerTransaction> MobileTowerTransaction { get; set; }
        public virtual DbSet<MrechargeDetail> MrechargeDetail { get; set; }
        public virtual DbSet<Ptddetail> Ptddetail { get; set; }
        public virtual DbSet<SensorLogDetail> SensorLogDetail { get; set; }
        public virtual DbSet<SensorMaster> SensorMaster { get; set; }
        public virtual DbSet<SmartLightDetail> SmartLightDetail { get; set; }
        public virtual DbSet<SocietyMaster> SocietyMaster { get; set; }
        public virtual DbSet<StatusDetail> StatusDetail { get; set; }
        public virtual DbSet<StreetLightDetail> StreetLightDetail { get; set; }
        public virtual DbSet<TblBinReports> TblBinReports { get; set; }
        public virtual DbSet<TblDevice> TblDevice { get; set; }
        public virtual DbSet<TblGpstemp> TblGpstemp { get; set; }
        public virtual DbSet<TblRegistration> TblRegistration { get; set; }
        public virtual DbSet<TblTakyAlert> TblTakyAlert { get; set; }
        public virtual DbSet<TblVoltage> TblVoltage { get; set; }
        public virtual DbSet<TempSensorDetail> TempSensorDetail { get; set; }
        public virtual DbSet<TrivandrumEnvironmentDetail> TrivandrumEnvironmentDetail { get; set; }
        public virtual DbSet<UhfTransaction> UhfTransaction { get; set; }
        public virtual DbSet<UserDetail> UserDetail { get; set; }
        public virtual DbSet<WaterDetail> WaterDetail { get; set; }
        public virtual DbSet<Weight> Weight { get; set; }
        public virtual DbSet<WifiDetail> WifiDetail { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=122.176.105.30;Database=dbAjeeviIot;User ID=sa;Password=S9p5dvutk8;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AjeeviOperationDetail>(entity =>
            {
                entity.HasKey(e => e.Aodid)
                    .HasName("PK__AjeeviOp__A3A57B0868F1C2B9");

                entity.Property(e => e.Aodid).HasColumnName("AODId");

                entity.Property(e => e.ContainerCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContainerType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OperationType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SyncedOutOn).HasColumnType("datetime");

                entity.Property(e => e.Syncon).HasColumnType("datetime");

                entity.Property(e => e.TRno).HasColumnName("tRNO");

                entity.Property(e => e.Tdate)
                    .HasColumnName("TDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tscircle)
                    .HasColumnName("TSCircle")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tsid).HasColumnName("TSId");

                entity.Property(e => e.Tsname)
                    .HasColumnName("TSName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TsrefId).HasColumnName("TSRefId");

                entity.Property(e => e.Tsward)
                    .HasColumnName("TSWard")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tszone)
                    .HasColumnName("TSZone")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BgpsTransaction>(entity =>
            {
                entity.HasKey(e => e.GpsTid)
                    .HasName("PK__BGpsTran__465D41C692E5C481");

                entity.ToTable("BGpsTransaction");

                entity.Property(e => e.GpsTid).HasColumnName("GpsTId");

                entity.Property(e => e.DatedOn).HasColumnType("datetime");

                entity.Property(e => e.FuelDetect)
                    .HasColumnName("Fuel_Detect")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Ignition)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Imei)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ipower)
                    .HasColumnName("IPower")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Lat)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Lng)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Odo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OverSpeedAlarm)
                    .HasColumnName("Over_Speed_Alarm")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Speed)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SyncOn).HasColumnType("datetime");

                entity.Property(e => e.TempDetect)
                    .HasColumnName("Temp_Detect")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.VibAlarm)
                    .HasColumnName("Vib_Alarm")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DeviceFeedBackDetail>(entity =>
            {
                entity.HasKey(e => e.FeedBackDetailId)
                    .HasName("PK__DeviceFe__06A14AF0B875C370");

                entity.Property(e => e.DeviceId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tdate)
                    .HasColumnName("TDate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<DigiLockTrans>(entity =>
            {
                entity.HasKey(e => e.Dltid)
                    .HasName("PK__DigiLock__8DD38EC98C7C63A7");

                entity.Property(e => e.Dltid).HasColumnName("DLTId");

                entity.Property(e => e.InputTxt).HasMaxLength(1000);

                entity.Property(e => e.Tdate)
                    .HasColumnName("TDate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Dtutransaction>(entity =>
            {
                entity.HasKey(e => e.Dtuid)
                    .HasName("PK__DTUTrans__FCCB406DB82E467C");

                entity.ToTable("DTUTransaction");

                entity.Property(e => e.Dtuid).HasColumnName("DTUId");

                entity.Property(e => e.AlertMsg)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DataMode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dtime)
                    .HasColumnName("DTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.ExtVal)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Tdate)
                    .HasColumnName("TDate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<EnergyMonitorDetail>(entity =>
            {
                entity.HasKey(e => e.EnergyId)
                    .HasName("PK__EnergyMo__6B3E95CBC1029375");

                entity.Property(e => e.BphaseCurnt)
                    .HasColumnName("BPhaseCurnt")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BphaseKw)
                    .HasColumnName("BPhaseKw")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BphaseVolt)
                    .HasColumnName("BPhaseVolt")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DgUnit)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FuelSensor1Val)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FuelSensor2Val)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PresentFrqncy)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PwrFactor)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Reserved1)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Reserved2)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RphaseCurnt)
                    .HasColumnName("RPhaseCurnt")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RphaseKw)
                    .HasColumnName("RPhaseKw")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RphaseVolt)
                    .HasColumnName("RPhaseVolt")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Tdate)
                    .HasColumnName("TDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.TotalKwhLoad)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TotalKwhUnit)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.YphaseCurnt)
                    .HasColumnName("YPhaseCurnt")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.YphaseKw)
                    .HasColumnName("YPhaseKw")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.YphaseVolt)
                    .HasColumnName("YPhaseVolt")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EntityFuelDetail>(entity =>
            {
                entity.HasKey(e => e.EntityId)
                    .HasName("PK__EntityFu__9C892F9D70AED235");

                entity.Property(e => e.CalibrationLevel).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeviceId)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EntityName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<EnvironmentDetail>(entity =>
            {
                entity.HasKey(e => e.EnvId)
                    .HasName("PK__Environm__1B5CF0D937288628");

                entity.Property(e => e.AlertDesc)
                    .HasColumnName("Alert_Desc")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Aqi)
                    .HasColumnName("AQI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BatteryLevel)
                    .HasColumnName("Battery_Level")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Co)
                    .HasColumnName("CO")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Co2)
                    .HasColumnName("CO2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Humidity)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Light)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.No2)
                    .HasColumnName("NO2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Noise)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.O3)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Pm10)
                    .HasColumnName("PM10")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Pm25)
                    .HasColumnName("PM2_5")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Rain)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.So2)
                    .HasColumnName("SO2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SyncOn).HasColumnType("datetime");

                entity.Property(e => e.Temperature)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Timstamp).HasColumnType("datetime");

                entity.Property(e => e.Uv)
                    .HasColumnName("UV")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Voc)
                    .HasColumnName("VOC")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.WindSpeed)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FlowMeterTransaction>(entity =>
            {
                entity.HasKey(e => e.Fmtid)
                    .HasName("PK__FlowMete__8893FC5723BF884C");

                entity.Property(e => e.Fmtid).HasColumnName("FMTId");

                entity.Property(e => e.DataMode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceId)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Dtime)
                    .HasColumnName("DTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.ExtVal)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FlowRate)
                    .HasColumnName("Flow_Rate")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MonthlyFlow)
                    .HasColumnName("Monthly_Flow")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NetTotalizer)
                    .HasColumnName("Net_Totalizer")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Tdate)
                    .HasColumnName("TDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.TodayTotal)
                    .HasColumnName("Today_Total")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TotalPower)
                    .HasColumnName("Total_Power")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Velocity)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.WorkingTime)
                    .HasColumnName("Working_Time")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.WorkingTimer)
                    .HasColumnName("Working_Timer")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FuelLevelDetail>(entity =>
            {
                entity.HasKey(e => e.FuelLevelId)
                    .HasName("PK__FuelLeve__2E3162058E2C2F4B");

                entity.Property(e => e.DeviceId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Level)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tdate)
                    .HasColumnName("TDate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<GpsMaster>(entity =>
            {
                entity.HasKey(e => e.GpsMid)
                    .HasName("PK__GpsMaste__472BE8CBC62268B9");

                entity.Property(e => e.GpsMid).HasColumnName("GpsMId");

                entity.Property(e => e.ChasisNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EngineNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImeiNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GpsRamkyTransaction>(entity =>
            {
                entity.HasKey(e => e.GpsTid)
                    .HasName("PK__GpsRamky__465D41C6D3B609E6");

                entity.Property(e => e.GpsTid).HasColumnName("GpsTId");

                entity.Property(e => e.DatedOn).HasColumnType("datetime");

                entity.Property(e => e.FuelDetect)
                    .HasColumnName("Fuel_Detect")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Ignition)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Imei)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IoffSec).HasColumnName("IOffSec");

                entity.Property(e => e.IonSec).HasColumnName("IOnSec");

                entity.Property(e => e.Ipower)
                    .HasColumnName("IPower")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Lat)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Lng)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Odo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OverSpeedAlarm)
                    .HasColumnName("Over_Speed_Alarm")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PoffSec).HasColumnName("POffSec");

                entity.Property(e => e.PonSec).HasColumnName("POnSec");

                entity.Property(e => e.Speed)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SyncOn).HasColumnType("datetime");

                entity.Property(e => e.TempDetect)
                    .HasColumnName("Temp_Detect")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.VibAlarm)
                    .HasColumnName("Vib_Alarm")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GpsTransaction>(entity =>
            {
                entity.HasKey(e => e.GpsTid)
                    .HasName("PK__GpsTrans__465D41C6CD0AC326");

                entity.Property(e => e.GpsTid).HasColumnName("GpsTId");

                entity.Property(e => e.DatedOn).HasColumnType("datetime");

                entity.Property(e => e.FuelDetect)
                    .HasColumnName("Fuel_Detect")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Ignition)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Imei)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ipower)
                    .HasColumnName("IPower")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Lat)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Lng)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Odo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OverSpeedAlarm)
                    .HasColumnName("Over_Speed_Alarm")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Speed)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SyncOn).HasColumnType("datetime");

                entity.Property(e => e.TempDetect)
                    .HasColumnName("Temp_Detect")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.VibAlarm)
                    .HasColumnName("Vib_Alarm")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Gpsdetail>(entity =>
            {
                entity.ToTable("GPSDetail");

                entity.Property(e => e.GpsdetailId).HasColumnName("GPSDetailId");

                entity.Property(e => e.CurrentDate).HasColumnType("datetime");

                entity.Property(e => e.DeviceId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lat)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lng)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Location).HasMaxLength(200);

                entity.Property(e => e.Speed).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Status)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Tdate)
                    .HasColumnName("TDate")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TrackDate).HasColumnType("datetime");

                entity.Property(e => e.Tutc)
                    .HasColumnName("TUtc")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<KdmcDevice>(entity =>
            {
                entity.Property(e => e.DateOfInstallation).HasColumnType("datetime");

                entity.Property(e => e.DeviceId)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceTypeId)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Lat)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Lng)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LoginInfo>(entity =>
            {
                entity.Property(e => e.CustomerTimeZone).HasMaxLength(20);

                entity.Property(e => e.LastAccessedDate).HasColumnType("datetime");

                entity.Property(e => e.LastLoginDate).HasColumnType("datetime");

                entity.Property(e => e.LoginIpaddress)
                    .HasColumnName("LoginIPAddress")
                    .HasMaxLength(20);

                entity.Property(e => e.Password).HasMaxLength(20);

                entity.Property(e => e.UserName).HasMaxLength(20);
            });

            modelBuilder.Entity<MeterReadingDetail>(entity =>
            {
                entity.HasKey(e => e.ReadingId)
                    .HasName("PK__MeterRea__C80F9C4E7502492C");

                entity.Property(e => e.DeviceId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DgReading).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.GridReading).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.LastUpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<MeterStatus>(entity =>
            {
                entity.HasKey(e => e.Msid)
                    .HasName("PK__MeterSta__6CB36023577636C8");

                entity.Property(e => e.Msid).HasColumnName("MSId");

                entity.Property(e => e.ImeiNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MeterTransaction>(entity =>
            {
                entity.HasKey(e => e.Mtid)
                    .HasName("PK__MeterTra__26F49124F299A0A0");

                entity.Property(e => e.Mtid).HasColumnName("MTId");

                entity.Property(e => e.ActivePower)
                    .HasColumnName("Active_Power")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Frequency)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Icurrent)
                    .HasColumnName("ICurrent")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImeiNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Kwh)
                    .HasColumnName("KWH")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.KwhMultiplier)
                    .HasColumnName("KWH_Multiplier")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pf)
                    .HasColumnName("PF")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReserveData1)
                    .HasColumnName("Reserve_Data1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReserveData2)
                    .HasColumnName("Reserve_Data2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tdate)
                    .HasColumnName("TDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Voltage)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MobileTowerTransaction>(entity =>
            {
                entity.HasKey(e => e.MobileTransactionId);

                entity.Property(e => e.BatteryCharge)
                    .HasColumnName("Battery_charge")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DbBatteryLowAlarm)
                    .HasColumnName("DB_Battery_low_alarm")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DgOutput)
                    .HasColumnName("DG_Output")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DgisOn)
                    .HasColumnName("DGIsOn")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DoorOpenAlarm)
                    .HasColumnName("Door_open_alarm")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FireAlarm)
                    .HasColumnName("Fire_Alarm")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LowFuelLevelAlarm)
                    .HasColumnName("Low_fuel_level_alarm")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LowVoltageAlarms)
                    .HasColumnName("Low_Voltage_Alarms")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoFuelAlarm)
                    .HasColumnName("No_Fuel_Alarm")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhaseAvailability)
                    .HasColumnName("Phase_Availability")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RoomTemperatureAlarms)
                    .HasColumnName("Room_Temperature_Alarms")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SiteDcLoad)
                    .HasColumnName("Site_DC_Load")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TDate)
                    .HasColumnName("tDate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<MrechargeDetail>(entity =>
            {
                entity.HasKey(e => e.Rcdid)
                    .HasName("PK__MRecharg__5851B56E2DB2AE27");

                entity.ToTable("MRechargeDetail");

                entity.Property(e => e.Rcdid).HasColumnName("RCDId");

                entity.Property(e => e.Amount).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ImeiNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Ptddetail>(entity =>
            {
                entity.HasKey(e => e.Ptdid)
                    .HasName("PK__PTDDetai__752F9F161D63E971");

                entity.ToTable("PTDDetail");

                entity.Property(e => e.Ptdid).HasColumnName("PTDId");

                entity.Property(e => e.DeviceDate).HasColumnType("datetime");

                entity.Property(e => e.DeviceId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lat)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Lng)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PhVal)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.T1)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Tdate)
                    .HasColumnName("TDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Temp)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SensorLogDetail>(entity =>
            {
                entity.HasKey(e => e.Sldid)
                    .HasName("PK__SensorLo__2E9CCC3DD29C7108");

                entity.Property(e => e.Sldid).HasColumnName("SLDId");

                entity.Property(e => e.Tdate)
                    .HasColumnName("TDate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<SensorMaster>(entity =>
            {
                entity.HasKey(e => e.Smid)
                    .HasName("PK__SensorMa__A47B2F766DF52C7F");

                entity.Property(e => e.Smid).HasColumnName("SMId");

                entity.Property(e => e.Ch2othval).HasColumnName("CH2OTHVal");

                entity.Property(e => e.Ch2ounit)
                    .HasColumnName("CH2OUnit")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Co2thval).HasColumnName("CO2THVal");

                entity.Property(e => e.Co2unit)
                    .HasColumnName("CO2Unit")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Cothval).HasColumnName("COTHVal");

                entity.Property(e => e.Counit)
                    .HasColumnName("COUnit")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DateOfExpiry).HasColumnType("datetime");

                entity.Property(e => e.DateOfInstallation).HasColumnType("datetime");

                entity.Property(e => e.HumidityThval).HasColumnName("HumidityTHVal");

                entity.Property(e => e.HumidityUnit)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ImeiNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lat)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LightThval).HasColumnName("LightTHVal");

                entity.Property(e => e.LightUnit)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Lng)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.No2thval).HasColumnName("NO2THVal");

                entity.Property(e => e.No2unit)
                    .HasColumnName("NO2Unit")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NoiseThval).HasColumnName("NoiseTHVal");

                entity.Property(e => e.NoiseUnit)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.O3thval).HasColumnName("O3THVal");

                entity.Property(e => e.O3unit)
                    .HasColumnName("O3Unit")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Pm10thval).HasColumnName("PM10THVal");

                entity.Property(e => e.Pm10unit)
                    .HasColumnName("PM10Unit")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Pm25thval).HasColumnName("PM2_5THVal");

                entity.Property(e => e.Pm25unit)
                    .HasColumnName("PM2_5Unit")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.So2thval).HasColumnName("SO2THVal");

                entity.Property(e => e.So2unit)
                    .HasColumnName("SO2Unit")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TempThval).HasColumnName("TempTHVal");

                entity.Property(e => e.TempUnit)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Uvthval).HasColumnName("UVTHVal");

                entity.Property(e => e.Uvunit)
                    .HasColumnName("UVUnit")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Vocthval).HasColumnName("VOCTHVal");

                entity.Property(e => e.Vocunit)
                    .HasColumnName("VOCUnit")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SmartLightDetail>(entity =>
            {
                entity.HasKey(e => e.SmartLightId)
                    .HasName("PK__SmartLig__08EDFD1A80C2E68C");

                entity.Property(e => e.BatteryCharge)
                    .HasColumnName("Battery_charge")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.BatteryDischarge)
                    .HasColumnName("Battery_Discharge")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.BatteryVolt)
                    .HasColumnName("Battery_Volt")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lat)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Lng)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SolarCharge)
                    .HasColumnName("Solar_Charge")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SolarVolt)
                    .HasColumnName("Solar_Volt")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tdate)
                    .HasColumnName("TDate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<SocietyMaster>(entity =>
            {
                entity.HasKey(e => e.SocietyId)
                    .HasName("PK__SocietyM__2D7C79FBEF61710A");

                entity.Property(e => e.SocietyName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StatusDetail>(entity =>
            {
                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StreetLightDetail>(entity =>
            {
                entity.Property(e => e.StreetLightDetailId).HasColumnName("StreetLightDetailID");

                entity.Property(e => e.BV)
                    .HasColumnName("b_v")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CC)
                    .HasColumnName("c_c")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ChargingFlag)
                    .HasColumnName("charging_flag")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LowBatteryFlag)
                    .HasColumnName("low_battery_flag")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReserveByte1)
                    .HasColumnName("reserve_byte1")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReserveByte2)
                    .HasColumnName("reserve_byte2")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SV)
                    .HasColumnName("s_v")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tdate)
                    .HasColumnName("TDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Temp)
                    .HasColumnName("temp")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBinReports>(entity =>
            {
                entity.ToTable("tblBinReports");

                entity.Property(e => e.DeviceId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lvl)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SiteNameLoc)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblDevice>(entity =>
            {
                entity.ToTable("tbl_Device");

                entity.Property(e => e.DeviceId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeviceName).HasMaxLength(50);
            });

            modelBuilder.Entity<TblGpstemp>(entity =>
            {
                entity.HasKey(e => e.TblId);

                entity.ToTable("tblGPSTemp");

                entity.Property(e => e.TblId).HasColumnName("tblId");

                entity.Property(e => e.Dated).HasColumnType("datetime");

                entity.Property(e => e.LangText)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.LatText)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblRegistration>(entity =>
            {
                entity.ToTable("tbl_Registration");

                entity.Property(e => e.Confpass)
                    .HasColumnName("confpass")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("date");

                entity.Property(e => e.FatherName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gmail)
                    .HasColumnName("gmail")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasColumnName("mobile")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pass)
                    .HasColumnName("pass")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblTakyAlert>(entity =>
            {
                entity.HasKey(e => e.TakyId)
                    .HasName("PK__tbl_Taky__B88AD5371268E284");

                entity.ToTable("tbl_TakyAlert");

                entity.Property(e => e.BattryVolt)
                    .HasColumnName("battryVolt")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DateT).HasColumnType("datetime");

                entity.Property(e => e.ImeiNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lat)
                    .HasColumnName("lat")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Loction)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Long)
                    .HasColumnName("long")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReservedData1)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReservedData2)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReservedData3)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Speed)
                    .HasColumnName("speed")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblVoltage>(entity =>
            {
                entity.ToTable("tbl_Voltage");

                entity.Property(e => e.Batteryvoltage)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Datet)
                    .HasColumnName("datet")
                    .HasColumnType("datetime");

                entity.Property(e => e.DeviceId)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TempSensorDetail>(entity =>
            {
                entity.HasKey(e => e.Tmpsid)
                    .HasName("PK__TempSens__85F024535E4EECE3");

                entity.Property(e => e.Tmpsid).HasColumnName("TMPSId");

                entity.Property(e => e.Tdate)
                    .HasColumnName("TDate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TrivandrumEnvironmentDetail>(entity =>
            {
                entity.HasKey(e => e.EnvId)
                    .HasName("PK__trivandr__1B5CF0D95AA0DD59");

                entity.ToTable("trivandrumEnvironmentDetail");

                entity.Property(e => e.AlertDesc)
                    .HasColumnName("Alert_Desc")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Aqi)
                    .HasColumnName("AQI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BatteryLevel)
                    .HasColumnName("Battery_Level")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Co)
                    .HasColumnName("CO")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Co2)
                    .HasColumnName("CO2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Humidity)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Light)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.No2)
                    .HasColumnName("NO2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Noise)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.O3)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Pm10)
                    .HasColumnName("PM10")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Pm25)
                    .HasColumnName("PM2_5")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Rain)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.So2)
                    .HasColumnName("SO2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SyncOn).HasColumnType("datetime");

                entity.Property(e => e.Temperature)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Timstamp).HasColumnType("datetime");

                entity.Property(e => e.Uv)
                    .HasColumnName("UV")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Voc)
                    .HasColumnName("VOC")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.WindSpeed)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UhfTransaction>(entity =>
            {
                entity.HasKey(e => e.Uhftid)
                    .HasName("PK__UhfTrans__B96BA33EA7A31551");

                entity.Property(e => e.Uhftid).HasColumnName("UHFTId");

                entity.Property(e => e.ImeiNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lat)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Lng)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TagId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tdate)
                    .HasColumnName("TDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserDetail>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__UserDeta__1788CC4C30387907");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CurrentBalance).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.DeviceId)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FlatNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LastRecharge).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WaterDetail>(entity =>
            {
                entity.HasKey(e => e.WaterId)
                    .HasName("PK__WaterDet__C4F18E8FF76CE44E");

                entity.Property(e => e.DeviceId)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Level)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Tdate)
                    .HasColumnName("TDate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Weight>(entity =>
            {
                entity.HasKey(e => e.Trno)
                    .HasName("PK__weight__FA7774FB16D1A6E9");

                entity.ToTable("weight");

                entity.Property(e => e.Dateout).HasColumnType("datetime");

                entity.Property(e => e.NetWt).HasColumnName("NetWT");

                entity.Property(e => e.SiteId)
                    .IsRequired()
                    .HasColumnName("SiteID")
                    .HasMaxLength(50);

                entity.Property(e => e.Timeout).HasColumnType("datetime");

                entity.Property(e => e.Vehicleno).HasMaxLength(50);
            });

            modelBuilder.Entity<WifiDetail>(entity =>
            {
                entity.HasKey(e => e.WifiId)
                    .HasName("PK__WifiDeta__E4AC91D4C91BFAE8");

                entity.Property(e => e.Tdate)
                    .HasColumnName("TDate")
                    .HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        internal object GetSaTempSensor()
        {
            throw new NotImplementedException();
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

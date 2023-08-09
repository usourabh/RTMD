using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RTMDOTProject.Models
{
    public partial class MonIOTContext : DbContext
    {
        public MonIOTContext()
        {
        }

        public MonIOTContext(DbContextOptions<MonIOTContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AlertsDetail> AlertsDetail { get; set; }
        public virtual DbSet<AsignLocation> AsignLocation { get; set; }
        public virtual DbSet<BindLocation> BindLocation { get; set; }
        public virtual DbSet<CircleMaster> CircleMaster { get; set; }
        public virtual DbSet<DeviceAssociation> DeviceAssociation { get; set; }
        public virtual DbSet<DeviceDetail> DeviceDetail { get; set; }
        public virtual DbSet<DeviceMaster> DeviceMaster { get; set; }
        public virtual DbSet<DeviceTransaction> DeviceTransaction { get; set; }
        public virtual DbSet<Location> Location { get; set; }
        public virtual DbSet<PageAssignationMaster> PageAssignationMaster { get; set; }
        public virtual DbSet<QrMaster> QrMaster { get; set; }
        public virtual DbSet<RdMaster> RdMaster { get; set; }
        public virtual DbSet<RegionMaster> RegionMaster { get; set; }
        public virtual DbSet<SurveyTransaction> SurveyTransaction { get; set; }
        public virtual DbSet<TblDeviceType> TblDeviceType { get; set; }
        public virtual DbSet<TblMenu> TblMenu { get; set; }
        public virtual DbSet<TblRole> TblRole { get; set; }
        public virtual DbSet<TblSubMenu> TblSubMenu { get; set; }
        public virtual DbSet<TblSubMenuInRole> TblSubMenuInRole { get; set; }
        public virtual DbSet<TblUser> TblUser { get; set; }
        public virtual DbSet<TblUserInRole> TblUserInRole { get; set; }
        public virtual DbSet<TempSensorDetail> TempSensorDetail { get; set; }
        public virtual DbSet<UserAreaDetail> UserAreaDetail { get; set; }
        public virtual DbSet<UserClientIdDetail> UserClientIdDetail { get; set; }
        public virtual DbSet<VwAlertTransaction> VwAlertTransaction { get; set; }
        public virtual DbSet<VwRecentTransaction> VwRecentTransaction { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=ecosmartdc.com;Database=MonIOT;User ID=sa;Password=S9p5dvutk8;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AlertsDetail>(entity =>
            {
                entity.HasKey(e => e.AlertId);

                entity.Property(e => e.Imei)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tdate)
                    .HasColumnName("TDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Temp).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Tmpsid).HasColumnName("TMPSId");

                entity.Property(e => e.Value1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Value2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Value3)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AsignLocation>(entity =>
            {
                entity.HasKey(e => e.AsignId)
                    .HasName("PK__AsignLoc__6D54B2023C286900");

                entity.Property(e => e.AsignLocation1)
                    .HasColumnName("AsignLocation")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<BindLocation>(entity =>
            {
                entity.HasKey(e => e.BindId)
                    .HasName("PK__BindLoca__694394705A8E4460");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Remarks).HasMaxLength(50);
            });

            modelBuilder.Entity<CircleMaster>(entity =>
            {
                entity.HasKey(e => e.CircleId);

                entity.Property(e => e.Ccode)
                    .HasColumnName("CCode")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CircleName)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DeviceAssociation>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.PrimaryDeviceId)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<DeviceDetail>(entity =>
            {
                entity.HasKey(e => e.DeviceId)
                    .HasName("PK__DeviceDe__49E12311778A07BB");

                entity.Property(e => e.Asmarea)
                    .HasColumnName("ASMArea")
                    .HasMaxLength(50);

                entity.Property(e => e.Branch).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.DeviceName).HasMaxLength(50);

                entity.Property(e => e.DeviceNumber).HasMaxLength(50);

                entity.Property(e => e.DeviceType).HasMaxLength(50);

                entity.Property(e => e.Ieminumber)
                    .HasColumnName("IEMINumber")
                    .HasMaxLength(50);

                entity.Property(e => e.Latitude).HasMaxLength(50);

                entity.Property(e => e.Longitude).HasMaxLength(50);

                entity.Property(e => e.MaximumValue).HasMaxLength(50);

                entity.Property(e => e.MinimumValue).HasMaxLength(50);

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Rdcode)
                    .HasColumnName("RDCode")
                    .HasMaxLength(50);

                entity.Property(e => e.Rdname)
                    .HasColumnName("RDName")
                    .HasMaxLength(50);

                entity.Property(e => e.Rdtown)
                    .HasColumnName("RDTown")
                    .HasMaxLength(50);

                entity.Property(e => e.RegionName).HasMaxLength(50);

                entity.Property(e => e.Soterritory).HasMaxLength(50);

                entity.Property(e => e.TownClassName).HasMaxLength(50);
            });

            modelBuilder.Entity<DeviceMaster>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.ImeiNo).HasMaxLength(50);

                entity.Property(e => e.Lat).HasMaxLength(50);

                entity.Property(e => e.Lng).HasMaxLength(50);

                entity.Property(e => e.Make).HasMaxLength(50);

                entity.Property(e => e.Model).HasMaxLength(50);

                entity.Property(e => e.RangeMax).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RangeMin).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SerialNo).HasMaxLength(50);
            });

            modelBuilder.Entity<DeviceTransaction>(entity =>
            {
                entity.HasKey(e => e.Tmpsid);

                entity.Property(e => e.Tmpsid).HasColumnName("TMPSId");

                entity.Property(e => e.Imei).HasMaxLength(20);

                entity.Property(e => e.Tdate)
                    .HasColumnName("TDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Temp).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Value1).HasMaxLength(50);

                entity.Property(e => e.Value2).HasMaxLength(50);

                entity.Property(e => e.Value3).HasMaxLength(50);
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.HasKey(e => e.ContactId)
                    .HasName("PK__Location__5C66259B209FCEDC");

                entity.Property(e => e.Address1).HasMaxLength(150);

                entity.Property(e => e.Address2).HasMaxLength(150);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.ContactPersonName).HasMaxLength(50);

                entity.Property(e => e.ContactPersonNumber).HasMaxLength(50);

                entity.Property(e => e.Country).HasMaxLength(50);

                entity.Property(e => e.Descriptions).HasMaxLength(50);

                entity.Property(e => e.Latitude).HasMaxLength(50);

                entity.Property(e => e.Longitude).HasMaxLength(50);

                entity.Property(e => e.Pin).HasMaxLength(50);

                entity.Property(e => e.State).HasMaxLength(50);
            });

            modelBuilder.Entity<PageAssignationMaster>(entity =>
            {
                entity.HasKey(e => e.PageAssignId);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FromQr).HasColumnName("FromQR");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Qrcode)
                    .HasColumnName("QRCode")
                    .HasMaxLength(50);

                entity.Property(e => e.RegionName).HasMaxLength(50);

                entity.Property(e => e.ToQr).HasColumnName("ToQR");
            });

            modelBuilder.Entity<QrMaster>(entity =>
            {
                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.Asmarea)
                    .HasColumnName("ASMArea")
                    .HasMaxLength(50);

                entity.Property(e => e.BranchName).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ImageUrl)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Qrid)
                    .IsRequired()
                    .HasColumnName("QRId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rdname)
                    .HasColumnName("RDName")
                    .HasMaxLength(50);

                entity.Property(e => e.Rdtype)
                    .HasColumnName("RDType")
                    .HasMaxLength(50);

                entity.Property(e => e.RegionName).HasMaxLength(50);

                entity.Property(e => e.State).HasMaxLength(50);

                entity.Property(e => e.TextBody)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.TextHeader)
                    .IsRequired()
                    .HasColumnType("text");
            });

            modelBuilder.Entity<RdMaster>(entity =>
            {
                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.Asmarea)
                    .HasColumnName("ASMArea")
                    .HasMaxLength(50);

                entity.Property(e => e.BranchName).HasMaxLength(50);

                entity.Property(e => e.ContactPerson).HasMaxLength(100);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.EmailId).HasMaxLength(150);

                entity.Property(e => e.MobileNo).HasMaxLength(100);

                entity.Property(e => e.Phone).HasMaxLength(100);

                entity.Property(e => e.Rdcode)
                    .IsRequired()
                    .HasColumnName("RDCode")
                    .HasMaxLength(50);

                entity.Property(e => e.Rdname)
                    .IsRequired()
                    .HasColumnName("RDName")
                    .HasMaxLength(50);

                entity.Property(e => e.Rdtype)
                    .HasColumnName("RDType")
                    .HasMaxLength(50);

                entity.Property(e => e.RegionName).HasMaxLength(50);

                entity.Property(e => e.Soterritory)
                    .HasColumnName("SOTerritory")
                    .HasMaxLength(50);

                entity.Property(e => e.State).HasMaxLength(50);

                entity.Property(e => e.Town).HasMaxLength(50);
            });

            modelBuilder.Entity<RegionMaster>(entity =>
            {
                entity.HasKey(e => e.RegionId)
                    .HasName("PK__RegionMa__ACD844A38B2E260F");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('Ajeevi')");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.RegionName).HasMaxLength(50);

                entity.Property(e => e.Remarks).HasMaxLength(100);
            });

            modelBuilder.Entity<SurveyTransaction>(entity =>
            {
                entity.Property(e => e.ApprovedBy).HasMaxLength(50);

                entity.Property(e => e.ApprovedPersonMobileNo).HasMaxLength(20);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DeviceCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Img1).HasMaxLength(1000);

                entity.Property(e => e.Img2).HasMaxLength(1000);

                entity.Property(e => e.Img3).HasMaxLength(1000);

                entity.Property(e => e.Lat)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Lng)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Rdcode)
                    .IsRequired()
                    .HasColumnName("RDCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remark).HasMaxLength(150);
            });

            modelBuilder.Entity<TblDeviceType>(entity =>
            {
                entity.HasKey(e => e.DeviceTypeId)
                    .HasName("PK__TblDevic__07A6C7F6D410948B");

                entity.Property(e => e.DeviceName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeviceType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Remarks).HasMaxLength(150);
            });

            modelBuilder.Entity<TblMenu>(entity =>
            {
                entity.HasKey(e => e.FnMenuId);

                entity.ToTable("tbl_Menu");

                entity.Property(e => e.FnMenuId).HasColumnName("fnMenuId");

                entity.Property(e => e.FbIsActive).HasColumnName("fbIsActive");

                entity.Property(e => e.FnOrderId).HasColumnName("fnOrderId");

                entity.Property(e => e.FnParentId).HasColumnName("fnParentId");

                entity.Property(e => e.FtMcssIcon)
                    .HasColumnName("ftMCssIcon")
                    .HasMaxLength(150);

                entity.Property(e => e.FtMenuName)
                    .IsRequired()
                    .HasColumnName("ftMenuName")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblRole>(entity =>
            {
                entity.HasKey(e => e.FnRoleId)
                    .HasName("PK__tbl_Role__9FDC2B1B0F1BE201");

                entity.ToTable("tbl_Role");

                entity.Property(e => e.FnRoleId).HasColumnName("fnRoleId");

                entity.Property(e => e.Ccode)
                    .HasColumnName("CCode")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FbIsActive).HasColumnName("fbIsActive");

                entity.Property(e => e.FtRoleName)
                    .IsRequired()
                    .HasColumnName("ftRoleName")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblSubMenu>(entity =>
            {
                entity.HasKey(e => e.FnSubMenuId);

                entity.ToTable("tbl_SubMenu");

                entity.Property(e => e.FnSubMenuId).HasColumnName("fnSubMenuId");

                entity.Property(e => e.FbIsActive).HasColumnName("fbIsActive");

                entity.Property(e => e.FnMenuId).HasColumnName("fnMenuId");

                entity.Property(e => e.FnOrderId).HasColumnName("fnOrderId");

                entity.Property(e => e.FtActionName)
                    .IsRequired()
                    .HasColumnName("ftActionName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FtArea)
                    .IsRequired()
                    .HasColumnName("ftArea")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FtControllerName)
                    .IsRequired()
                    .HasColumnName("ftControllerName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FtScssIcon)
                    .HasColumnName("ftSCssIcon")
                    .HasMaxLength(150);

                entity.Property(e => e.FtSubMenuName)
                    .IsRequired()
                    .HasColumnName("ftSubMenuName")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblSubMenuInRole>(entity =>
            {
                entity.HasKey(e => e.FnSubmenuInRoleId);

                entity.ToTable("tbl_SubMenuInRole");

                entity.Property(e => e.FnSubmenuInRoleId).HasColumnName("fnSubmenuInRoleId");

                entity.Property(e => e.FbIsAllow).HasColumnName("fbIsAllow");

                entity.Property(e => e.FbIsAllowAdd).HasColumnName("fbIsAllowAdd");

                entity.Property(e => e.FbIsAllowDelete).HasColumnName("fbIsAllowDelete");

                entity.Property(e => e.FbIsAllowEdit).HasColumnName("fbIsAllowEdit");

                entity.Property(e => e.FnCompanyId).HasColumnName("fnCompanyId");

                entity.Property(e => e.FnRoleId).HasColumnName("fnRoleId");

                entity.Property(e => e.FnSubMenuId).HasColumnName("fnSubMenuId");
            });

            modelBuilder.Entity<TblUser>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__tbl_User__1788CC4C195BBEB9");

                entity.ToTable("tbl_User");

                entity.Property(e => e.Ccode)
                    .HasColumnName("CCode")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClientId).IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EmailId).HasMaxLength(500);

                entity.Property(e => e.EmpCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastLogin).HasColumnType("datetime");

                entity.Property(e => e.Mobile).HasMaxLength(20);

                entity.Property(e => e.Pwd).HasMaxLength(2000);
            });

            modelBuilder.Entity<TblUserInRole>(entity =>
            {
                entity.HasKey(e => e.FnUserInRoleId)
                    .HasName("PK__tbl_User__A9DC91C1B71729B6");

                entity.ToTable("tbl_UserInRole");

                entity.Property(e => e.FnUserInRoleId).HasColumnName("fnUserInRoleId");

                entity.Property(e => e.Ccode)
                    .HasColumnName("CCode")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FnRoleId).HasColumnName("fnRoleId");

                entity.Property(e => e.FtLoginId)
                    .IsRequired()
                    .HasColumnName("ftLoginId")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TempSensorDetail>(entity =>
            {
                entity.HasKey(e => e.Tmpsid);

                entity.Property(e => e.Tmpsid).HasColumnName("TMPSId");

                entity.Property(e => e.Tdate)
                    .HasColumnName("TDate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<UserAreaDetail>(entity =>
            {
                entity.HasKey(e => e.UserAreaId)
                    .HasName("PK__UserArea__F030C7675B10B592");

                entity.Property(e => e.CircleId)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LoginId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WardId)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserClientIdDetail>(entity =>
            {
                entity.HasKey(e => e.UserClientId)
                    .HasName("PK__UserClie__A5FB1175FF118A05");

                entity.Property(e => e.ClientId).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.LoginId)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwAlertTransaction>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_AlertTransaction");

                entity.Property(e => e.Asmarea)
                    .HasColumnName("ASMArea")
                    .HasMaxLength(50);

                entity.Property(e => e.Branch).HasMaxLength(50);

                entity.Property(e => e.DatedOn).HasMaxLength(4000);

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.DeviceName).HasMaxLength(50);

                entity.Property(e => e.DeviceNumber).HasMaxLength(50);

                entity.Property(e => e.DeviceType).HasMaxLength(50);

                entity.Property(e => e.Ieminumber)
                    .HasColumnName("IEMINumber")
                    .HasMaxLength(50);

                entity.Property(e => e.Imei)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Latitude).HasMaxLength(50);

                entity.Property(e => e.Longitude).HasMaxLength(50);

                entity.Property(e => e.MaximumValue).HasMaxLength(50);

                entity.Property(e => e.MinimumValue).HasMaxLength(50);

                entity.Property(e => e.Rdcode)
                    .HasColumnName("RDCode")
                    .HasMaxLength(50);

                entity.Property(e => e.Rdname)
                    .HasColumnName("RDName")
                    .HasMaxLength(50);

                entity.Property(e => e.Rdtown)
                    .HasColumnName("RDTown")
                    .HasMaxLength(50);

                entity.Property(e => e.RegionName).HasMaxLength(50);

                entity.Property(e => e.Soterritory).HasMaxLength(50);

                entity.Property(e => e.Tdate)
                    .HasColumnName("TDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Temp).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TownClassName).HasMaxLength(50);
            });

            modelBuilder.Entity<VwRecentTransaction>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_RecentTransaction");

                entity.Property(e => e.Asmarea)
                    .HasColumnName("ASMArea")
                    .HasMaxLength(50);

                entity.Property(e => e.Branch).HasMaxLength(50);

                entity.Property(e => e.DatedOn).HasMaxLength(4000);

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.DeviceName).HasMaxLength(50);

                entity.Property(e => e.DeviceNumber).HasMaxLength(50);

                entity.Property(e => e.DeviceType).HasMaxLength(50);

                entity.Property(e => e.Ieminumber)
                    .HasColumnName("IEMINumber")
                    .HasMaxLength(50);

                entity.Property(e => e.Imei).HasMaxLength(20);

                entity.Property(e => e.Latitude).HasMaxLength(50);

                entity.Property(e => e.Longitude).HasMaxLength(50);

                entity.Property(e => e.MaximumValue).HasMaxLength(50);

                entity.Property(e => e.MinimumValue).HasMaxLength(50);

                entity.Property(e => e.Rdcode)
                    .HasColumnName("RDCode")
                    .HasMaxLength(50);

                entity.Property(e => e.Rdname)
                    .HasColumnName("RDName")
                    .HasMaxLength(50);

                entity.Property(e => e.Rdtown)
                    .HasColumnName("RDTown")
                    .HasMaxLength(50);

                entity.Property(e => e.RegionName).HasMaxLength(50);

                entity.Property(e => e.Soterritory).HasMaxLength(50);

                entity.Property(e => e.Tdate)
                    .HasColumnName("TDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Temp).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.TownClassName).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using RTMDOTProject.COMMON;
using RTMDOTProject.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace RTMDOTProject.Controllers
{
    public class AsignToLocationController : Controller
    {
        private MonIOTContext context;
        public AsignToLocationController(MonIOTContext context)
        {
            this.context = context;
        }
        //public Dictionary<string, string> GetDepotName()
        //{
        //    Dictionary<string, string> dict = new Dictionary<string, string>();
        //    //    IEnumerable<StockInRegister> list = null;
        //    try
        //    {
        //        using (FMS_DBEntities dbContext = new FMS_DBEntities())
        //        {
        //            //          list = from i in dbContext.VendorTypeMasters
        //            dict = dbContext.DepoNames.Where(e => e.Active == true).ToDictionary(i => i.DepoCode, i => i.DepotName);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        this.LogException("GetVendorCode()", ex);
        //    }
        //    return dict;
        //}
        //public IActionResult Index()
        //{
        //    //var data
        //        List<SelectListItem> data = new() { context.DeviceDetail.ToList().Select(e => e.DeviceName) };
        //   // var data = context.DeviceDetail.ToDictionary(i => i.DeviceName, i => i.DeviceId);
        //  //dynamic viewBag = ViewBag;
        //    viewBag.DeviceName = data;
        //    return View();
        //}

        [HttpGet]
        public IActionResult Index()
        {
            List<DeviceDetail> li = new List<DeviceDetail>();
            li = context.DeviceDetail.ToList();
            ViewBag.data1 = li;

            List<Location> list = new List<Location>();
            list = context.Location.ToList();
            ViewBag.data2 = list;
            //    return View();
            //}

            //public IActionResult Location()           
            //{
            string markers = "[";
            string conString = @"Data Source=LAPTOP-GNREPRGR;Initial Catalog=MonIOT;integrated security=true";
            SqlCommand cmd = new SqlCommand("SELECT LL.ContactPersonName,DD.DeviceName,LL.Latitude,LL.Longitude,DD.DeviceNumber,DD.IEMINumber FROM [MonIOT].[dbo].[BindLocation] BL left join [dbo].[DeviceDetail] DD on DD.deviceId=BL.deviceId left join [dbo].[Location] LL on LL.ContactId=BL.ContactId ");
            //  SqlCommand cmd = new SqlCommand("SELECT LL.ContactPersonName,DD.DeviceName,LL.Latitude,LL.Longitude FROM [MonIOT].[dbo].[BindLocation] BL left join [dbo].[DeviceDetail] DD on DD.deviceId=BL.deviceId left join [dbo].[Location] LL on LL.ContactId=BL.ContactId where deviceId=");
            //SqlCommand cmd = new SqlCommand("SELECT * FROM Location");
            using (SqlConnection con = new SqlConnection(conString))
            {
                cmd.Connection = con;
                con.Open();
                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        markers += "{";
                        markers += string.Format("'title': '{0}',", sdr["ContactPersonName"]);
                        markers += string.Format("'lat': '{0}',", sdr["Latitude"]);
                        markers += string.Format("'lng': '{0}',", sdr["Longitude"]);
                        markers += string.Format("'description': '{0}'", sdr["DeviceName"]);
                        markers += "},";
                    }
                }
                con.Close();
            }

            markers += "];";
            ViewBag.Markers = markers;
            return View();
        }
        [HttpGet]
        public IActionResult BindDevice()
        {
            List<DeviceDetail> li = new List<DeviceDetail>();
            li = context.DeviceDetail.ToList();
            ViewBag.data1 = li;

            List<Location> list = new List<Location>();
            list = context.Location.ToList();
            ViewBag.data2 = list;
            return View();
        }

        [HttpPost]

        public JsonResult Bind(BindLocationInfo obj)
        {
            var data = new BindLocation()
            {
                DeviceId = obj.DeviceId,
                ContactId = obj.ContactId,             
            };
            context.BindLocation.Add(data);
            context.SaveChanges();
            // return new JsonResult("Device Data is Save ");
           //  RedirectToAction("Index", "Location");
            return new JsonResult("Device Data is Save ");
        }
        [HttpGet]
        public JsonResult Locationdata(int DeviceId)
        {
            List<DeviceDetail> li = new List<DeviceDetail>();
            li = context.DeviceDetail.ToList();
            ViewBag.data1 = li;
            List<Location> list = new List<Location>();
            list = context.Location.ToList();
            ViewBag.data2 = list;
            //    return View();
            //}
            BindLocation1 bd = new BindLocation1();
            //public IActionResult Location()           
            //{
            string markers ="";
            string conString = @"Data Source=LAPTOP-GNREPRGR;Initial Catalog=MonIOT;integrated security=true";
            //SqlCommand cmd = new SqlCommand("SELECT LL.ContactPersonName,DD.DeviceName,LL.Latitude,LL.Longitude FROM [MonIOT].[dbo].[BindLocation] BL left join [dbo].[DeviceDetail] DD on DD.deviceId=BL.deviceId left join [dbo].[Location] LL on LL.ContactId=BL.ContactId ");
            SqlCommand cmd = new SqlCommand("SELECT LL.ContactPersonName,DD.DeviceName,LL.Latitude,LL.Longitude,DD.DeviceNumber,DD.IEMINumber FROM [MonIOT].[dbo].[BindLocation] BL left join [dbo].[DeviceDetail] DD on DD.deviceId=BL.deviceId left join [dbo].[Location] LL on LL.ContactId=BL.ContactId where DD.deviceId=" + DeviceId);
            //SqlCommand cmd = new SqlCommand("SELECT * FROM Location");
            using (SqlConnection con = new SqlConnection(conString))
            {
                cmd.Connection = con;
                con.Open();
                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        bd.DeviceName = sdr["DeviceName"].ToString();
                        bd.lat = sdr["Latitude"].ToString();
                        bd.lng = sdr["Longitude"].ToString();
                        bd.contactpersonname = "ContactPersonName : "+ sdr["ContactPersonName"].ToString()+ " <br/> DeviceNumber : " + sdr["DeviceNumber"].ToString()+ " <br/> IEMINumber :" + sdr["IEMINumber"].ToString();
                        //markers += "{";
                        //markers += string.Format("'title': '{0}',", sdr["DeviceName"]);
                        //markers += string.Format("'lat': '{0}',", sdr["Latitude"]);
                        //markers += string.Format("'lng': '{0}',", sdr["Longitude"]);
                        //markers += string.Format("'description': '{0}'", sdr["ContactPersonName"]);
                        //markers += "},";
                    }
                }
                con.Close();
            }

          //  markers += "];";
            ViewBag.Markers = bd;
            return new JsonResult(ViewBag.Markers);
        }
    
 
        //public JsonResult Index(int DeviceId)
        //{
        //    List<DeviceDetail> li = new List<DeviceDetail>();
        //    li = context.DeviceDetail.ToList();
        //    ViewBag.data1 = li;

        //    List<Location> list = new List<Location>();
        //    list = context.Location.ToList();
        //    ViewBag.data2 = list;
        //    //    return View();
        //    //}

        //    //public IActionResult Location()           
        //    //{
        //    string markers = "[";
        //    string conString = @"Data Source=DESKTOP-7JMD36P;Initial Catalog=MonIOT;integrated security=true";
        //    //SqlCommand cmd = new SqlCommand("SELECT LL.ContactPersonName,DD.DeviceName,LL.Latitude,LL.Longitude FROM [MonIOT].[dbo].[BindLocation] BL left join [dbo].[DeviceDetail] DD on DD.deviceId=BL.deviceId left join [dbo].[Location] LL on LL.ContactId=BL.ContactId ");
        //   SqlCommand cmd = new SqlCommand("SELECT LL.ContactPersonName,DD.DeviceName,LL.Latitude,LL.Longitude FROM [MonIOT].[dbo].[BindLocation] BL left join [dbo].[DeviceDetail] DD on DD.deviceId=BL.deviceId left join [dbo].[Location] LL on LL.ContactId=BL.ContactId where deviceId=" + DeviceId);
        //    //SqlCommand cmd = new SqlCommand("SELECT * FROM Location");
        //    using (SqlConnection con = new SqlConnection(conString))
        //    {
        //        cmd.Connection = con;
        //        con.Open();
        //        using (SqlDataReader sdr = cmd.ExecuteReader())
        //        {
        //            while (sdr.Read())
        //            {
        //                markers += "{";
        //                markers += string.Format("'title': '{0}',", sdr["ContactPersonName"]);
        //                markers += string.Format("'lat': '{0}',", sdr["Latitude"]);
        //                markers += string.Format("'lng': '{0}',", sdr["Longitude"]);
        //                markers += string.Format("'description': '{0}'", sdr["DeviceName"]);
        //                markers += "},";
        //            }
        //        }
        //        con.Close();
        //    }

        //    markers += "];";
        //    ViewBag.Markers = markers;
        //    return new JsonResult("done");
        //}
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RTMDOTProject.COMMON;
using RTMDOTProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using RTMDOTProject.INTERFACE;

namespace RTMDOTProject.Controllers
{
    public class DashboardController : Controller
    {



        private MonIOTContext context;
        private IDataBase<GResposnse> _dataRepository;

        public DashboardController(MonIOTContext _context, IDataBase<GResposnse> dataRepository)
        {
            this.context = _context;
            this._dataRepository = dataRepository;
        }

        public IActionResult Index()
        {
            try
            {
                var dd = HttpContext.Session.GetString("IsFirstTimeLogin");
                if (dd == "0" || dd == null)
                {
                    return RedirectToAction("Index", "Login");
                }
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Login");
            }

            
            ViewBag.Title = "ACTIVE DEVICE";
            return View();
        }

        public JsonResult getMaxDevice()
        {
            List<SencerData> lst = new List<SencerData>();
            var data = context.TempSensorDetail.ToList().OrderByDescending(e => e.Tmpsid).ToList();
            foreach (var item in data)
            {
                SencerData obj = new SencerData();
                if (item.InsertText.ToCharArray().Count(x => x == ',') == 4)
                {
                    string[] sry = item.InsertText.Split(',');
                    obj.Imei = sry[1];
                    obj.id = item.Tmpsid;
                    obj.Temp = sry[0];
                    obj.DatedOn = item.Tdate.ToString("dd-MMM-yyyy hh:mm tt");
                    lst.Add(obj);
                }
            }
            var Newdata = context.DeviceDetail.Where(x => x.Status == true).AsEnumerable().Select(x => new tmdata
            {

                Imei = x.DeviceNumber,
                Temp = lst.Any(r => r.Imei == x.DeviceNumber) ? lst.Where(r => r.Imei == x.DeviceNumber).OrderByDescending(x => x.id).FirstOrDefault().Temp : "",
                DatedOn = lst.Any(r => r.Imei == x.DeviceNumber) ? lst.Where(r => r.Imei == x.DeviceNumber).OrderByDescending(x => x.id).FirstOrDefault().DatedOn : "",
                DeviceName = x.DeviceName,
                DeviceType = x.DeviceType,
                Latitude = x.Latitude,
                Longitude = x.Longitude
            });
            var ff = Newdata.Where(i => Convert.ToDecimal(i.Temp) > 22 || Convert.ToDecimal(i.Temp) < 18).Count();

            return new JsonResult("");
        }
        public JsonResult GetDeviceDetail()
        {
            var data = context.DeviceDetail.ToList().OrderByDescending(e => e.DeviceId);
            return new JsonResult(data);
        }
        public JsonResult GetActiveDeviceDetail()
        {
            var data = context.DeviceDetail.Where(e => e.CreatedOn < DateTime.Today).ToList().OrderByDescending(e => e.DeviceId);

            return new JsonResult(data);
        }

        [HttpPost]
        public JsonResult DashboardNotification()
        {
            object[] parameters = {

                                         0
                                        };

            string Result = _dataRepository.ExcuteSingleRowSqlCommand(StoredProcedureHelper.spDashboardNotification, parameters);
            return new JsonResult(Result);
        }
        public IActionResult chart()
        {
            List<QrMaster> li = new List<QrMaster>();
            li = context.QrMaster.ToList();
            ViewBag.data = li;
            return View();
        }
        public IActionResult graph()
        {
            return View();
        }

        public JsonResult GetInActiveDeviceDetail()
        {
            //var data = context.DeviceDetail.Where(e => e.CreatedOn < DateTime.Today).ToList().OrderByDescending(e => e.DeviceId);
            //return new JsonResult(data);

            object[] parameters = {
                                       "",
                                          "",
                                          "",
                                          0,
                                          20
                                        };

            string Result = _dataRepository.ExcuteRowSqlCommand(StoredProcedureHelper.sp_GetInActiveDevice, parameters);

            return new JsonResult(Result);

        }

    }
}

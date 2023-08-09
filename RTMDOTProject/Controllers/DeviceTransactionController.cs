using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RTMDOTProject.COMMON;
using RTMDOTProject.INTERFACE;
using RTMDOTProject.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RTMDOTProject.Controllers
{
    public class DeviceTransactionController : Controller
    {
        private MonIOTContext db;
        private IDataBase<GResposnse> _dataRepository;

        public DeviceTransactionController(MonIOTContext _db, IDataBase<GResposnse> dataRepository)
        {
            this.db = _db;
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
            return View();
        }
        public IActionResult ActiveDevices()
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
            return View();
        }

        public JsonResult Transaction()
        {

            object[] parameters = {

                                          "",
                                          "",
                                          "",
                                          0,
                                          500,
                                        };

            string Result = _dataRepository.ExcuteRowSqlCommand(StoredProcedureHelper.spGetDevice_WithPaging, parameters);

            return new JsonResult(Result);

        }
        public JsonResult ActiveDeviceTransaction()
        {

            object[] parameters = {

                                          "",
                                          "",
                                          "",
                                          0,
                                          500,
                                        };

            string Result = _dataRepository.ExcuteRowSqlCommand(StoredProcedureHelper.spGetActiveDevice_WithPaging, parameters);

            return new JsonResult(Result);

        }
        public JsonResult InActiveDeviceTransaction()
        {

            object[] parameters = {

                                          "",
                                          "",
                                          "",
                                          0,
                                          500,
                                        };

            string Result = _dataRepository.ExcuteRowSqlCommand(StoredProcedureHelper.spGetInActiveDevice_WithPaging, parameters);

            return new JsonResult(Result);
        }

        public JsonResult ActiveAlarmDeviceTransaction()
        {

            object[] parameters = {

                                          "",
                                          "",
                                          "",
                                          0,
                                          500,
                                        };

            string Result = _dataRepository.ExcuteRowSqlCommand(StoredProcedureHelper.ActiveAlarmDevice_WithPaging, parameters);

            return new JsonResult(Result);
        }

        [HttpPost]
        public JsonResult GetChartData(string imei)
        {
            List<CharData> lst = new List<CharData>();
            object[] parameters = {

                                          DateTime.Now.AddDays(-6).ToString("dd-MMM-yyyy"),
                                           DateTime.Now.AddDays(1).ToString("dd-MMM-yyyy"),
                                          imei
                                        };

            string Result = _dataRepository.ExcuteRowSqlCommand(StoredProcedureHelper.sp_GetHistrory, parameters);

            List<DataSample> lstMaster = JsonConvert.DeserializeObject<List<DataSample>>(Result);

            foreach (var item in lstMaster)
            {
                item.yy = item.Tdate.Year;
                item.mm = (item.Tdate.Month - 1);
                item.dd = item.Tdate.Day;
            }

            //CharData objBarMax = new CharData();
            //CharData objLineAverage = new CharData();
            //CharData objLineLow = new CharData();


            //objBarMax.Type = "column";
            //objBarMax.Name = "Maximum Temp";
            //objBarMax.ShowInLegend = true;
            //objBarMax.DataPoints = lstMaster.Select(x => new dap()
            //{
            //    X = "new Date(" + x.Tdate.Year + ", " + (x.Tdate.Month - 1) + ", " + x.Tdate.Day + ")",
            //    y = (float)x.Tmax
            //}).ToList();

            //objLineAverage.Type = "line";
            //objLineAverage.Name = "Average Temp";
            //objLineAverage.ShowInLegend = true;
            //objLineAverage.DataPoints = lstMaster.Select(x => new dap()
            //{
            //    X = "new Date(" + x.Tdate.Year + ", " + (x.Tdate.Month - 1) + ", " + x.Tdate.Day + ")",
            //    y = (float)x.Tavg
            //}).ToList();

            //objLineLow.Name = "";
            //objLineLow.Type = "area";
            //objLineLow.Name = "Low Temp";
            //objLineLow.ShowInLegend = true;
            //objLineLow.MarkerBorderThickness = 2;
            //objLineLow.MarkerBorderColor = "white";
            //objLineLow.DataPoints = lstMaster.Select(x => new dap()
            //{
            //    X = "new Date(" + x.Tdate.Year + ", " + (x.Tdate.Month - 1) + ", " + x.Tdate.Day + ")",
            //    y = (float)x.TMin
            //}).ToList();


            //lst.Add(objBarMax);
            //lst.Add(objLineAverage);
            //lst.Add(objLineLow);

            return new JsonResult(lstMaster);

        }
        [HttpPost]
        public JsonResult TransactionById(string imei)
        {
            //var data = (from x in db.DeviceTransaction
            //            join d in db.DeviceDetail on x.Imei equals d.Ieminumber
            //            where d.Ieminumber == imei
            //            select new tmdata()
            //            {
            //                DatedOn = Convert.ToDateTime(x.Tdate).ToString("dd-MMM-yyyy hh:mm tt"),
            //                DeviceName = d.DeviceName,
            //                DeviceType = d.DeviceType,
            //                Imei = d.Ieminumber,
            //                Latitude = d.Latitude,
            //                Longitude = d.Longitude,
            //                TDate = x.Tdate,
            //                Temp = x.Temp.ToString()
            //            }
            //            ).OrderByDescending(x => x.TDate).Take(50).ToList();

            object[] parameters = {
                                          imei
                                        };
            string data = _dataRepository.ExcuteRowSqlCommand(StoredProcedureHelper.spGetDeviceRecentTransactionByImei, parameters);

            return new JsonResult(data);
        }
        public IActionResult InActiveDevices()
        {
            return View();
        }

        public IActionResult AlarmDevices()
        {
            return View();
        }

    }
}

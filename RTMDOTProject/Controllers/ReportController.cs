using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RTMDOTProject.COMMON;
using RTMDOTProject.INTERFACE;
using RTMDOTProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RTMDOTProject.Controllers
{
    public class ReportController : Controller
    {
        private MonIOTContext db;
        private IDataBase<GResposnse> _dataRepository;

        public ReportController(MonIOTContext _db, IDataBase<GResposnse> dataRepository)
        {
            this.db = _db;
            this._dataRepository = dataRepository;
        }

        public IActionResult Index()
        {
            return View();
        }
        public JsonResult GetReportDetails()
        {

            object[] parameters = {
                                  };
            string Result = _dataRepository.ExcuteRowSqlCommand(StoredProcedureHelper.spQRdetail, parameters);
            return new JsonResult(Result);

        }

        public IActionResult TimeWiseReport()
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

        [HttpPost]
        public JsonResult TransactionDurationWiseReport(string dFrom,string dTo)
        {
            

            object[] parameters = {

                                          "",
                                          "",
                                          "",
                                          0,
                                          500,
                                          dFrom,
                                          dTo
                                        };

            string Result = _dataRepository.ExcuteRowSqlCommand(StoredProcedureHelper.ReportByDuration, parameters);
            return new JsonResult(Result);

        }
        [HttpPost]
        public JsonResult TransactionById(string dF,string dT,string imei,int minutes)
        {
            object[] parameters = {
                                          imei,
                                          dF,
                                          dT,
                                          minutes,
                                        };
            string Result = _dataRepository.ExcuteRowSqlCommand(StoredProcedureHelper.spGetDeviceTransactionByRange, parameters);

            return new JsonResult(Result);
        }

    }
}

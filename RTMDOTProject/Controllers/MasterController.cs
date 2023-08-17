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
    public class MasterController : Controller
    {
        private MonIOTContext db;
        private IDataBase<GResposnse> _dataRepository;
        public MasterController(MonIOTContext _db, IDataBase<GResposnse> dataRepository)
        {
            this.db = _db;
            this._dataRepository = dataRepository;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult RDMaster()
        {
            return View();
        }

        public IActionResult Survey()
        {
            return View();

        }
        public JsonResult GetRDDetail()
        {

            //object[] parameters = {
            //                              "",
            //                              "",
            //                              "",
            //                              0,
            //                              -1,
            //                            };
            object[] parameters = {

                                          "",
                                          "",
                                          "",
                                          0,
                                          500,
                                        };
           

            // string Result = _dataRepository.ExcuteRowSqlCommand(StoredProcedureHelper.spGetRDMasterData, parameters);
            string Result = _dataRepository.ExcuteRowSqlCommand(StoredProcedureHelper.spGetDevice_WithPaging, parameters);

            return new JsonResult(Result);

        }

        public JsonResult GetSurveyDetail()
        {
            object[] parameters = {

                                          "",
                                          "",
                                          "",
                                          0,
                                          -1,
                                        };

            string Result = _dataRepository.ExcuteRowSqlCommand(StoredProcedureHelper.spGetSurveyTransData, parameters);

            return new JsonResult(Result);

        }

        public JsonResult AddRDDetails(RDMasterInfo obj)
        {
            var data = new RdMaster()
            {
                Id = obj.Id,
                Rdcode = obj.Rdcode,
                Rdname = obj.Rdname,
                BranchName = obj.BranchName,
                RegionName = obj.RegionName,
                Asmarea = obj.Asmarea,
                Soterritory = obj.Soterritory,
                Town = obj.Town,
                State = obj.State,
                Address = obj.Address,
                Phone = obj.Phone,
                ContactPerson = obj.ContactPerson,
                MobileNo = obj.MobileNo,
                EmailId = obj.EmailId,
                Description = obj.Description,
                IsActive = obj.IsActive,            
            };
            db.RdMaster.Add(data);
            db.SaveChanges();
            return new JsonResult("Device Data is Save ");
        }
        public JsonResult Editdata(int Id)
        {
            var data = db.RdMaster.Where(e => e.Id == Id).SingleOrDefault();
            return new JsonResult(data);
        }

        public JsonResult Deletedata(int Id)
        {
            var data = db.RdMaster.Where(e => e.Id == Id).SingleOrDefault();
            db.Remove(data);
            db.SaveChanges();
            return new JsonResult("Removed");
        }

        public JsonResult UpdateData(RdMaster rdMaster)
        {
            db.RdMaster.Update(rdMaster);
            db.SaveChanges();
            return new JsonResult("Record Updated");
        }
    }
}

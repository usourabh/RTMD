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
    public class LoginController : Controller
    {
        private MonIOTContext db;
        private IDataBase<GResposnse> _dataRepository;

        public LoginController(MonIOTContext _db, IDataBase<GResposnse> dataRepository)
        {
            this.db = _db;
            this._dataRepository = dataRepository;
        }
        public IActionResult Index()
        {
            ViewBag.msg = "";
            return View();
        }
        [HttpPost]
        public IActionResult Index(string loginId,string password)
        {
            object[] parameters = { loginId, PasswordHelper.EncryptPwd(password), CommonHelper.IndianStandard(DateTime.UtcNow), String.Empty };
            string usr = _dataRepository.ExcuteSingleRowSqlCommand(StoredProcedureHelper.spGetValidateLogin, parameters);

            UserLoginInfo UserInfoResult = JsonConvert.DeserializeObject<UserLoginInfo>(usr);

            if (UserInfoResult.Result==1)
            {
                HttpContext.Session.SetString("IsFirstTimeLogin","1");
                return RedirectToAction("Index", "Dashboard");
            }
            else
            {
                HttpContext.Session.SetString("IsFirstTimeLogin", "0");
                ViewBag.msg = "invalid login/password";
                return View();
            }
        }
    }
}

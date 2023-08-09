using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RTMDOTProject.COMMON;
using RTMDOTProject.INTERFACE;
using RTMDOTProject.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.AspNetCore.Authorization;

namespace RTMDOTProject.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class SurveyController : ControllerBase
    {
        private MonIOTContext db;
        private IDataBase<GResposnse> _dataRepository;
        private readonly IWebHostEnvironment HostingEnvironment;

        public SurveyController(MonIOTContext _db, IDataBase<GResposnse> dataRepository, IWebHostEnvironment hostingEnvironment)
        {
            this.db = _db;
            this._dataRepository = dataRepository;
            this.HostingEnvironment = hostingEnvironment;
        }

        [HttpGet]
        [Route("Login")]
        public IActionResult Login(string userName, string password)
        {
            object[] parameters = { userName, PasswordHelper.EncryptPwd(password), CommonHelper.IndianStandard(DateTime.UtcNow), String.Empty };
            string usr = _dataRepository.ExcuteSingleRowSqlCommand(StoredProcedureHelper.spGetValidateLogin, parameters);
            return Ok(usr);
        }
        [HttpPost]
        [Route("SurveyAppLogin")]
        public IActionResult SurveyAppLogin(JObject obj)
        {
            string LoginId = obj.GetValue("LoginId").Value<string>();
            string Pwd = obj.GetValue("Pwd").Value<string>();
            string ClientId = obj.GetValue("ClientId").Value<string>();
            object[] parameters = { LoginId, PasswordHelper.EncryptPwd(Pwd), CommonHelper.IndianStandard(DateTime.UtcNow), ClientId };
            string usr = _dataRepository.ExcuteSingleRowSqlCommand(StoredProcedureHelper.spGetValidateSurveyLogin, parameters);
            return Ok(usr);
        }
        [HttpPost]
        [Route("SaveSurvey")]
        [DisableRequestSizeLimit]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> SaveSurvey([FromForm] IFormCollection value)
        {
            string FName = string.Empty;
            var filePath = "";

            string FName2 = string.Empty;
            var filePath2 = "";

            string FName3 = string.Empty;
            var filePath3 = "";

            string Result = "";
            string inputval = value["Input"].ToString();
            SurveyInfo cinfo = JsonConvert.DeserializeObject<SurveyInfo>(inputval);

            if (value.Files.Count > 0)
            {
                if (value.Files[0].Length > 0)
                {
                    FName = CommonHelper.generateID() + Path.GetExtension(value.Files[0].FileName);
                    filePath = Path.Combine(HostingEnvironment.WebRootPath + "/images", FName);
                }
            }
            if (value.Files.Count >= 1)
            {
                if (value.Files[1].Length > 0)
                {
                    FName2 = CommonHelper.generateID() + Path.GetExtension(value.Files[1].FileName);
                    filePath2 = Path.Combine(HostingEnvironment.WebRootPath + "/images", FName2);
                }
            }
            if (value.Files.Count >= 2)
            {
                if (value.Files[2].Length > 0)
                {
                    FName3 = CommonHelper.generateID() + Path.GetExtension(value.Files[2].FileName);
                    filePath3 = Path.Combine(HostingEnvironment.WebRootPath + "/images", FName3);
                }
            }


            object[] parameters = { cinfo.DeviceCode,
                cinfo.RDCode,
                cinfo.Lat,
                cinfo.Lng,
                cinfo.ApprovedBy,
                cinfo.ApprovedPersonMobileNo,
                cinfo.Remark,
                cinfo.CreatedBy,
                cinfo.ContactPerson,
                cinfo.ContactPersonMobile,
                FName,
                FName2,
                FName3,
                cinfo.QrCodeNumber,
                cinfo.VisicoolerSerialNo
            };
            string usr = _dataRepository.ExcuteSingleRowSqlCommand(StoredProcedureHelper.spSurveyInsert, parameters);

            if (value.Files.Count > 0)
                if (value.Files[0].Length > 0)
                {
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        await value.Files[0].CopyToAsync(fileStream);
                    }
                }
            if (value.Files.Count >= 1)
                if (value.Files[1].Length > 0)
                {
                    using (var fileStream = new FileStream(filePath2, FileMode.Create))
                    {
                        await value.Files[1].CopyToAsync(fileStream);
                    }
                }
            if (value.Files.Count >= 2)
                if (value.Files[2].Length > 0)
                {
                    using (var fileStream = new FileStream(filePath3, FileMode.Create))
                    {
                        await value.Files[2].CopyToAsync(fileStream);
                    }
                }



            return Ok(usr);
        }
        [HttpGet]
        [Route("GetRdByCode")]
        public IActionResult GetRdByCode(string rdCode)
        {
            object[] parameters = { rdCode };
            string usr = _dataRepository.ExcuteSingleRowSqlCommand(StoredProcedureHelper.spGetRdByCode, parameters);
            return Ok(usr);
        }
        [HttpGet]
        [Route("GetAllDevices")]
        public IActionResult GetAllDevices()
        {
            object[] parameters = {

                                          "",
                                          "",
                                          "",
                                          0,
                                          500,
                                        };

            string Result = _dataRepository.ExcuteRowSqlCommand(StoredProcedureHelper.spGetDevice_WithPaging, parameters);

            return Ok(Result);
        }
        [HttpGet]
        [Route("GetDeviceByid")]
        public IActionResult GetDeviceByid(string id)
        {
            object[] parameters = {id};

            string Result = _dataRepository.ExcuteSingleRowSqlCommand(StoredProcedureHelper.spGetDeviceByid, parameters);

            return Ok(Result);
        }
        [HttpPost]
        [Route("InsertVaccineBoxTransaction")]
        public IActionResult InsertVaccineBoxTransaction(JObject obj)
        {
            string Imei = obj.GetValue("Imei").Value<string>();
            string LoginId = obj.GetValue("LoginId").Value<string>();
            string Lat = obj.GetValue("Lat").Value<string>();
            string Lng = obj.GetValue("Lng").Value<string>();
            object[] parameters = {Lat,Lng, LoginId, Imei};
            string usr = _dataRepository.ExcuteSingleRowSqlCommand(StoredProcedureHelper.spInsertVaccineBoxTransaction, parameters);
            return Ok(usr);
        }
    }
}

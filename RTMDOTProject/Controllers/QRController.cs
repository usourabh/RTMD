using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RTMDOTProject.COMMON;
using RTMDOTProject.INTERFACE;
using RTMDOTProject.Models;
using Newtonsoft.Json;
using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace RTMDOTProject.Controllers
{
    public class QRController : Controller
    {
        private MonIOTContext context;
        private IDataBase<GResposnse> _dataRepository;

        public QRController(MonIOTContext context, IDataBase<GResposnse> dataRepository)
        {
            this.context = context;
            this._dataRepository = dataRepository;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult app(string id)
        {
            QrInfo Qrdata = new QrInfo();


            if (!string.IsNullOrEmpty(id))
            {
                object[] parameters = {
                                    id
                                  };
                string Result = _dataRepository.ExcuteSingleRowSqlCommand(StoredProcedureHelper.SpGetQrByQrId, parameters);
                Qrdata = JsonConvert.DeserializeObject<QrInfo>(Result);
            }
            return View(Qrdata);
        }
        
        public JsonResult GetQRDetails()
        {

            object[] parameters = {
                                  };

            string Result = _dataRepository.ExcuteRowSqlCommand(StoredProcedureHelper.spQRdetail, parameters);

            return new JsonResult(Result);

        }
        //public JsonResult QRDetailByQrid(string QrId)
        //{
        //    object[] parameters = {
        //                            QrId
        //                          };
        //    string Result = _dataRepository.ExcuteRowSqlCommand(StoredProcedureHelper.SpGetQrByQrId, parameters);
        //    return new JsonResult(Result);
        //}

        [HttpPost]
        public JsonResult AddQR(QrMasterInfo obj)
        {
            string txtMsg = "";
            string Qrid = obj.Qrid.Trim().ToUpper();
            var data = new QrMaster()
            {
                //  Id = obj.Id,
                Qrid = obj.Qrid,
                TextHeader = obj.TextHeader,
                TextBody = obj.TextBody,
                ImageUrl = obj.ImageUrl,
                IsActive = obj.IsActive,
                //CreatedBy=obj.CreatedBy,
                //CreatedOn = DateTime.Now,
                //ModifiedBy=obj.ModifiedBy,
                //ModifiedOn = DateTime.Now
            };
            if (!context.QrMaster.Any(x => x.Qrid == Qrid && x.Id != obj.Id))
            {
                context.QrMaster.Add(data);
                context.SaveChanges();
                txtMsg = "Record added";
            }
            else
            {
                txtMsg = "Record alredy exist";
            }
            return new JsonResult(txtMsg);
        }
        public JsonResult Edit(int Id)
        {
            var data = context.QrMaster.Where(e => e.Id == Id).SingleOrDefault();
            return new JsonResult(data);
        }
        //public JsonResult QRUpdate( qrMaster)
        //{

        //    context.QrMaster.Update(qrMaster);

        //    context.SaveChanges();

        //    return new JsonResult("Record Updated");
        //}
        [HttpPost]
        public async Task<JsonResult> QRUpdate([FromForm] IFormCollection formData)
        {
            return Json("Record Updated");
        }

        [HttpGet]
        public IActionResult CreateQRCode(string id)
        {
            using (var stream = new MemoryStream())
            {
                string WebUri = "http://tsen.ecosmartdc.com/Qr/app?id=" + id;
                //string WebUri = new Url(qRCode.QRCodeText);
                string UriPayload = WebUri.ToString();
                QRCodeGenerator QrGenerator = new QRCodeGenerator();
                QRCodeData QrCodeInfo = QrGenerator.CreateQrCode(UriPayload, QRCodeGenerator.ECCLevel.Q);
                QRCode QrCode = new QRCode(QrCodeInfo);
                Bitmap QrBitmap = QrCode.GetGraphic(60);

                QrBitmap.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                byte[] BitmapArray = stream.ToArray();
                string QrUri = string.Format("data:image/png;base64,{0}", Convert.ToBase64String(BitmapArray));
                ViewBag.QrCodeUri = QrUri;
                ViewBag.fname = id+".png";
            }

            return View();
        }
    }
}

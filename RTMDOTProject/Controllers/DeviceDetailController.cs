using Effort.Internal.TypeGeneration;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using RTMDOTProject.COMMON;
using RTMDOTProject.INTERFACE;
using RTMDOTProject.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace RTMDOTProject.Controllers
{
    public class DeviceDetailController : Controller
    {

        private MonIOTContext context;
        private IDataBase<GResposnse> _dataRepository;

        public DeviceDetailController(MonIOTContext _context, IDataBase<GResposnse> dataRepository)
        {
            this.context = _context;
            this._dataRepository = dataRepository;
        }


        [HttpGet]

        public JsonResult GetDeviceDetail()
        {
            var data = context.DeviceDetail.ToList().OrderByDescending(e => e.DeviceId).ToList();
            return new JsonResult(data);
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
            List<TblDeviceType> li = new List<TblDeviceType>();
            li = context.TblDeviceType.ToList();
            ViewBag.data = li;
            return View();
        }
        public JsonResult AddDevice(DeviceDetailInfo obj)
        {
            string txtMsg = "";
            string Ieminumber = obj.Ieminumber.Trim().ToUpper();
            var data = new DeviceDetail()
            {
                DeviceId = obj.DeviceId,
                Ieminumber = obj.Ieminumber,
                DeviceNumber = obj.DeviceNumber,
                DeviceName = obj.DeviceName,
                DeviceType = obj.DeviceType,
                MaximumValue = obj.MaximumValue,
                MinimumValue = obj.MinimumValue,
                Latitude = obj.Latitude,
                CreatedOn= DateTime.Now,
                Longitude = obj.Longitude,
                Branch = obj.Branch,
                RegionName= obj.RegionName,
                Asmarea = obj.Asmarea,
                Soterritory= obj.Soterritory,
                Rdcode = obj.Rdcode,
                Rdname = obj.Rdname,
                TownClassName = obj.TownClassName,
                Rdtown = obj.Rdtown,
              // Status = true,
                 Status = obj.Status,
                Description = obj.Description,
            };

            if (!context.DeviceDetail.Any(x => x.Ieminumber == Ieminumber && x.DeviceId != obj.DeviceId))
            {
                context.DeviceDetail.Add(data);
                context.SaveChanges();

                txtMsg = "Record added";
            }
            else
            {
                txtMsg = "Record alredy exist";
            }
            return new JsonResult(txtMsg);
        }

        //public JsonResult AddDevice(string devicejS)
        //{
        //    DataTable dt = JsonConvert.DeserializeObject<DataTable>(devicejS);
        //    List<COMMON.DeviceDetailInfo> lst = new List<COMMON.DeviceDetailInfo>();
        //    foreach (System.Data.DataRow dr in dt.Rows)
        //    {
        //        COMMON.DeviceDetailInfo obj = new COMMON.DeviceDetailInfo();
        //        lst.Add(new COMMON.DeviceDetailInfo
        //        {
        //          //  DeviceId = Convert.ToInt32(dr["DeviceId"].ToString()),
        //            Ieminumber = dr["IEMINumber"].ToString(),
        //            DeviceType = dr["DeviceType"].ToString(),
        //            DeviceName = dr["DeviceName"].ToString(),
        //            MaximumValue = dr["MaximumValue"].ToString(),
        //            MinimumValue = dr["MinimumValue"].ToString(),
        //           Latitude = dr["Latitude"].ToString(),
        //             Longitude = dr["Longitude"].ToString(),
        //            Status = dr["Status"].ToString(),
        //           Description = dr["Description"].ToString(),
        //        });
        //    }
        //    try
        //    {
        //        using (MonIOTContext dbcontext = new MonIOTContext())
        //        {
        //            foreach (COMMON.DeviceDetailInfo _request in lst)
        //            {
        //                bool isupdated = true;
        //                DeviceDetail objinfo = null;
        //                objinfo = context.DeviceDetail.Where(i => i.DeviceId == _request.DeviceId).FirstOrDefault();
        //                if (objinfo == null)
        //                {
        //                    isupdated = false;
        //                    objinfo = new DeviceDetail();
        //                }

        //                objinfo.DeviceId = _request.DeviceId;
        //                objinfo.Ieminumber = _request.Ieminumber;
        //                objinfo.DeviceType = _request.DeviceType;
        //                objinfo.DeviceName = _request.DeviceName;
        //                objinfo.MaximumValue = _request.MaximumValue;
        //                objinfo.MinimumValue = _request.MinimumValue;
        //                objinfo.Latitude = _request.Latitude;
        //                objinfo.Longitude = _request.Longitude;
        //                objinfo.Status = _request.Status;
        //                objinfo.Description = _request.Description;
        //                if (!isupdated)
        //                    dbcontext.DeviceDetail.Add(objinfo);
        //                dbcontext.SaveChanges();
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return new JsonResult("please enter valid data");
        //    }
        //    return new JsonResult("product data is save ");
        //}

        public IActionResult AllDeviceDetails()
        {
            List<TblDeviceType> li = new List<TblDeviceType>();
            li = context.TblDeviceType.ToList();
            ViewBag.data = li;

            return View();
        }
        public JsonResult getPrimaryDevice()
        {
            var data = context.DeviceMaster.ToList().Where(s => s.DeviceTypeId == 3);

            return new JsonResult(data);
        } 
        public JsonResult GetMasterData()
        {
            object[] parameters = {
                                          "",
                                          "",
                                          "",
                                          0,
                                          -1,
                                        };

            string Result = _dataRepository.ExcuteRowSqlCommand(StoredProcedureHelper.GetDeviceData, parameters);

            return new JsonResult(Result);

        }
        public JsonResult DeviceDetails(DeviceDetailInfo obj)
        {

            var data = new DeviceDetail()
            {
                DeviceId = obj.DeviceId,
                Ieminumber = obj.Ieminumber,
                DeviceNumber = obj.DeviceNumber,
                DeviceName = obj.DeviceName,
                DeviceType = obj.DeviceType,
                MaximumValue = obj.MaximumValue,
                MinimumValue = obj.MinimumValue,
                Latitude = obj.Latitude,
                Longitude = obj.Longitude,
                Branch = obj.Branch,
                RegionName = obj.RegionName,
                Asmarea = obj.Asmarea,
                Soterritory = obj.Soterritory,
                Rdcode = obj.Rdcode,
                Rdname = obj.Rdname,
                TownClassName = obj.TownClassName,
                Rdtown = obj.Rdtown,
                Status = obj.Status,
                Description = obj.Description,

            };
            context.DeviceDetail.Add(data);
            context.SaveChanges();
            return new JsonResult("Device Data is Save ");
        }

        [HttpPost]
        //  public JsonResult DeviceInfo(DeviceMasterInfo obj)
        public JsonResult DeviceInfo(DeviceMasterInfo obj, DeviceAssoinfo obj1)
        {
            string txtMsg = "";
            string ImeiNo = obj.ImeiNo.Trim().ToUpper();
            var data = new DeviceMaster()
            {
                DeviceMasterId = obj.DeviceMasterId,
                DeviceTypeId = obj.DeviceTypeId,
                ImeiNo = obj.ImeiNo,
                SerialNo = obj.SerialNo,
                Make = obj.Make,
                Model = obj.Model,
                RangeMax = obj.RangeMax,
                RangeMin = obj.RangeMin,
                IsActive = obj.IsActive,
                Lat = obj.Lat,
                Lng = obj.Lng,
                Description = obj.Description,
                CreatedBy = "",
            };

            var data1 = new DeviceAssociation()
            {
                PrimaryDeviceId = obj1.PrimaryDeviceId,
                DeviceId = obj1.DeviceId,
                IsAssociated = obj1.IsAssociated,
                CreatedBy = "",
                CreatedOn = DateTime.Now

            };
            if (!context.DeviceMaster.Any(x => x.ImeiNo == ImeiNo && x.DeviceMasterId != obj.DeviceMasterId))
            {
                context.DeviceMaster.Add(data);
                context.SaveChanges();
                txtMsg = "Record added";
            }
            else
            {
                txtMsg = "Record alredy exist";
            }
            if (!context.DeviceAssociation.Any(x => x.DeviceAssociationId == obj1.DeviceAssociationId))
            {
                context.DeviceAssociation.Add(data1);
                context.SaveChanges();
                txtMsg = "Record added";
            }
            else
            {
                txtMsg = "Record alredy exist";
            }


            return new JsonResult(txtMsg);
        }


        public JsonResult Edit(int DeviceId)
        {
            var data = context.DeviceDetail.Where(e => e.DeviceId == DeviceId).SingleOrDefault();
            return new JsonResult(data);
        }

        public JsonResult Delete(int DeviceId)
        {
            var data = context.DeviceDetail.Where(e => e.DeviceId == DeviceId).SingleOrDefault();
            context.Remove(data);
            context.SaveChanges();
            return new JsonResult("Removed");
        }
       
        public JsonResult UpdateDevice(DeviceDetail deviceDetail)
        {
            context.DeviceDetail.Update(deviceDetail);
            context.SaveChanges();
            return new JsonResult("Record Updated");
        }


        public IActionResult MaxMinDeviceDetail() 
        {
            return View();
        }


        //public JsonResult Transaction()
        //{
        //    //var data = context.TempSensorDetail.ToList().OrderByDescending(e => e.Tmpsid);

        //    List<SencerData> lst = new List<SencerData>();
        //    var data = context.TempSensorDetail.ToList().OrderByDescending(e => e.Tmpsid).ToList();
        //    foreach (var item in data)
        //    {
        //        SencerData obj = new SencerData();
        //        if (item.InsertText.ToCharArray().Count(x => x == ',') == 4)
        //        {
        //            string[] sry = item.InsertText.Split(',');
        //            obj.Imei = sry[1];
        //            obj.id = item.Tmpsid;
        //            obj.Temp = sry[0];
        //            obj.DatedOn = item.Tdate.ToString("dd-MMM-yyyy hh:mm tt");
        //            lst.Add(obj);
        //        }
        //    }

        //    var Newdata = db.DeviceDetail.Where(x => x.Status == true).AsEnumerable().Select(x => new tmdata
        //    {
        //        Imei = x.DeviceNumber,
        //        Temp = lst.Any(r => r.Imei == x.DeviceNumber) ? lst.Where(r => r.Imei == x.DeviceNumber).OrderByDescending(x => x.id).FirstOrDefault().Temp : "",
        //        DatedOn = lst.Any(r => r.Imei == x.DeviceNumber) ? lst.Where(r => r.Imei == x.DeviceNumber).OrderByDescending(x => x.id).FirstOrDefault().DatedOn : "",
        //        DeviceName = x.DeviceName,
        //        DeviceType = x.DeviceType,
        //        Latitude = x.Latitude,
        //        Longitude = x.Longitude
        //    });
        //    //var Newdata = (from x in db.DeviceDetail
        //    //               select new
        //    //               {
        //    //                   Imei = x.DeviceNumber,
        //    //                   Temp = lst.Any(r => r.Imei == x.DeviceNumber) ? lst.Where(r => r.Imei == x.DeviceNumber).OrderByDescending(x => x.id).FirstOrDefault().Temp : "",
        //    //                   DatedOn = lst.Any(r => r.Imei == x.DeviceNumber) ? lst.Where(r => r.Imei == x.DeviceNumber).OrderByDescending(x => x.id).FirstOrDefault().DatedOn : "",
        //    //                   DeviceName = x.DeviceName,
        //    //                   DeviceType = x.DeviceType,
        //    //               }
        //    //               ).ToList();
        //    return new JsonResult(Newdata);

        //}


        //device master crud
        public JsonResult Editdata(int DeviceMasterId)
        {
            var data = context.DeviceMaster.Where(e => e.DeviceMasterId == DeviceMasterId).SingleOrDefault();
            return new JsonResult(data);
        }

        public JsonResult Deletedata(int DeviceMasterId)
        {
            var data = context.DeviceMaster.Where(e => e.DeviceMasterId == DeviceMasterId).SingleOrDefault();
            context.Remove(data);
            context.SaveChanges();
            return new JsonResult("Removed");
        }

        public JsonResult UpdateData(DeviceMaster deviceMaster)
        {
            context.DeviceMaster.Update(deviceMaster);
            context.SaveChanges();
            return new JsonResult("Record Updated");
        }



    }
}

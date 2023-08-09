using Microsoft.AspNetCore.Mvc;
using RTMDOTProject.COMMON;
using RTMDOTProject.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace RTMDOTProject.Controllers
{
    public class LocationController : Controller
    {
        private MonIOTContext context;
        public LocationController(MonIOTContext context)
        {
            this.context = context;
        }
        [HttpGet]

        public JsonResult GetLocationDetail()
        {
            var data = context.Location.ToList().OrderByDescending(i => i.ContactId);
            return new JsonResult(data);
        }

        public IActionResult Index()
        {
            return View();
        }
     
        public JsonResult LocationDetails(LocationDetailInfo obj)
        {
            var data = new Location()
            {
                ContactId = obj.ContactId,
                ContactPersonName = obj.ContactPersonName,
                ContactPersonNumber = obj.ContactPersonNumber,
                Address1 = obj.Address1,
                Address2 = obj.Address2,
                Longitude = obj.Longitude,
                Latitude = obj.Latitude,
                City = obj.City,
                State = obj.State,
                Pin = obj.Pin,
                Country = obj.Country,
            };
            context.Location.Add(data);
            context.SaveChanges();
            return new JsonResult("Location Data is Save ");
        }

        [HttpGet]
        public JsonResult Edit(int contactId)
        {
            var data = context.Location.Where(e => e.ContactId == contactId).SingleOrDefault();
            return new JsonResult(data);
        }
        [HttpPost]
        public JsonResult AddLocation(LocationDetailInfo location)
        {
           // DateTime localDate = DateTime.Now;

            var cmp = new Location()
            {
                ContactPersonName = location.ContactPersonName,
                ContactPersonNumber = location.ContactPersonNumber,
                Address1  = location.Address1,
                Address2 = location.Address2,
                Longitude= location.Longitude,
                Latitude = location.Latitude,
                City = location.City,
                State = location.State,
                Pin = location.Pin,
                Country = location.Country,
                Descriptions  = location.Descriptions
                //CreatedOn = localDate,
                //ModifiedOn = localDate

            };
            context.Location.Add(cmp);
            context.SaveChanges();
            return new JsonResult("Location Data is Save ");
        }

        public JsonResult UpdateLocation(Location location)
        {
            context.Location.Update(location);
            context.SaveChanges();
            return new JsonResult("Record Updated");
        }

    }
}

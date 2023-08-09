using Microsoft.AspNetCore.Hosting;
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
    [Route("api/[controller]")]
    [ApiController]
    public class SetLocationController : ControllerBase
    {
        private MonIOTContext db;
        private IDataBase<GResposnse> _dataRepository;
        private readonly IWebHostEnvironment HostingEnvironment;

        public SetLocationController(MonIOTContext _db, IDataBase<GResposnse> dataRepository, IWebHostEnvironment hostingEnvironment)
        {
            this.db = _db;
            this._dataRepository = dataRepository;
            this.HostingEnvironment = hostingEnvironment;
        }

        [HttpGet]
        [Route("Change")]
        public IActionResult Change(int type)
        {
            object[] parameters = { type };
            string usr = _dataRepository.ExcuteSingleRowSqlCommand(StoredProcedureHelper.spInsertGspTransactionAuto, parameters);
            return Ok("Record Added");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CoreWebAPIApp.API.Models;
using CoreWebAPIApp.API.Data;

namespace CoreWebAPIApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DBLoanController : ControllerBase
    {
        private readonly IDataProvider dataAccessProvider;

        public DBLoanController(IDataProvider dataAccessProvider)
        {
            this.dataAccessProvider = dataAccessProvider;
        }

        [HttpPost]
        public IActionResult Create([FromBody]DBLoan loan)
        {
            if (ModelState.IsValid)
            {
                Guid obj = Guid.NewGuid();
                loan.ID = obj.ToString();
                this.dataAccessProvider.CreateRecord(loan);
                return Ok();
            }
            return BadRequest();
        }

        [HttpGet("{id}")]
        public DBLoan Read(string id)
        {
            return this.dataAccessProvider.ReadRecord(id);
        }

        [HttpPut]
        public IActionResult Update([FromBody]DBLoan loan)
        {
            if (ModelState.IsValid)
            {               
                this.dataAccessProvider.UpdateRecord(loan);
                return Ok();
            }
            return BadRequest();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            var recordToDelete = this.dataAccessProvider.ReadRecord(id);
            if (recordToDelete == null)
            {
                return NotFound();
            }
            this.dataAccessProvider.DeleteRecord(id);
            return Ok();
        }

        [HttpGet]
        public IEnumerable<DBLoan> Get()
        {
            return this.dataAccessProvider.GetAllRecords();
        }
    }
}

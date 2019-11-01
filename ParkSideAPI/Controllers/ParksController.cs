using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ParkSideAPI.Models;

namespace ParkSideAPI.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/[controller]")]
    [ApiController]
    public class ParksController : ControllerBase
    {
        private ParkSideAPIContext _db;

        public ParksController(ParkSideAPIContext db)
        {
        _db = db;
        }

        // GET api/parks
        [HttpGet]
        public ActionResult<IEnumerable<Park>> Get()
        {
            
        }

        // GET api/parks/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/parks
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/parks/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/parks/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

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
        public ActionResult<IEnumerable<Park>> Get(string name, string governingBody, string stateLocation, int established)
        {
            var query = _db.Parks.AsQueryable();
            if (name != null)
            {
                query = query.Where(entry => entry.Name.ToLower().Contains(name.ToLower()));
            }
            if (governingBody != null)
            {
                query = query.Where(entry => entry.GoverningBody.ToLower().Contains(governingBody.ToLower()));
            }
            if (stateLocation != null)
            {
                query = query.Where(entry => entry.StateLocation.ToLower().Contains(stateLocation.ToLower()));
            }
            if (established != 0)
            {
                query = query.Where(entry => entry.Established == established);
            }
            return query.ToList();
        }

        // GET api/parks/5
        [HttpGet("{id}")]
        public ActionResult<Park> Get(int id)
        {
            return _db.Parks.FirstOrDefault(entry => entry.ParkId == id);
        }

        // POST api/parks
        [HttpPost]
        public void Post([FromBody] Park park)
        {
            _db.Parks.Add(park);
            _db.SaveChanges();
        }

        // PUT api/parks/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Park park)
        {
            park.ParkId = id;
            _db.Entry(park).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _db.SaveChanges();
        }

        // DELETE api/parks/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var parkToDelete = _db.Parks.FirstOrDefault(entry => entry.ParkId == id);
            _db.Parks.Remove(parkToDelete);
            _db.SaveChanges();
        }
    }
}

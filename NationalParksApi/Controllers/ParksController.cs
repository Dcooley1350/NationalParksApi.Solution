using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using NationalParksApi.Models;
using Microsoft.EntityFrameworkCore;

namespace NationalParksApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParksController : ControllerBase
    {
        private NationalParksApiContext _db;
        public ParksController(NationalParksApiContext db)
        {
            _db = db;
        }

        [HttpPost]
        public void Post([FromBody] Park park)
        {
            _db.Parks.Add(park);
            _db.SaveChanges();
        }
        [HttpGet("{id}")]
        public ActionResult<Park> Get(int id)
        {
            return _db.Parks.FirstOrDefault(entry => entry.ParkId == id);
        }
        // [HttpGet]
        // public ActionResult<IEnumerable<Park>> Get()
        // {
        //     return _db.Parks.ToList();
        // }
        [HttpGet]
        public ActionResult<IEnumerable<Park>> GetAction(string name, string description, string location)
        {
            var query = _db.Parks.AsQueryable();

            if (name != null)
            {
                query = query.Where(entry => entry.Name == name);
            }
            if (description != null)
            {
                query = query.Where(entry => entry.Description == description);
            }
            if (location != null)
            {
                query = query.Where(entry => entry.Location == location);
            }
            return query.ToList();
        
        }
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Park park)
        {
            park.ParkId = id;
            _db.Entry(park).State = EntityState.Modified;
            _db.SaveChanges();
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var parkToDelete = _db.Parks.FirstOrDefault(entry => entry.ParkId == id);
            _db.Parks.Remove(parkToDelete);
            _db.SaveChanges();
        }
    }
}
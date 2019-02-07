using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace TourOfHeroesApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeroesController : ControllerBase
    {
        private readonly HeroContext _heroContext;

        public HeroesController(HeroContext heroContext)
        {
            _heroContext = heroContext;

            if (_heroContext.Heroes.Count() == 0)
            {
                _heroContext.Heroes.Add(new Hero { Id = 1, Name = "Storm" });
                _heroContext.Heroes.Add(new Hero { Id = 2, Name = "Magneto" });
                _heroContext.Heroes.Add(new Hero { Id = 3, Name = "Wolverine" });
                _heroContext.Heroes.Add(new Hero { Id = 4, Name = "Psylock" });
                _heroContext.Heroes.Add(new Hero { Id = 5, Name = "Deadpool" });
                _heroContext.Heroes.Add(new Hero { Id = 6, Name = "Cyclops" });
                _heroContext.Heroes.Add(new Hero { Id = 7, Name = "Cable" });
                _heroContext.Heroes.Add(new Hero { Id = 8, Name = "Rogue" });
                _heroContext.Heroes.Add(new Hero { Id = 9, Name = "Juggernaut" });
                _heroContext.Heroes.Add(new Hero { Id = 10, Name = "Night Crawler" });
                _heroContext.SaveChanges();
            }
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Hero>> GetAll()
        {
            return _heroContext.Heroes.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Hero> Get(int id)
        {
            var item = _heroContext.Heroes.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return item;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

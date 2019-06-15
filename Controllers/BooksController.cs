using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using pda_backend.Models;

namespace pda_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            // return new string[] { "u1", "u2" };
            // Book book = new Book(1, "Пятая гора", "icon", 1, 1);
            // SerializeObject
            return new string[] { 
                new Book(1, "Пятая гора", "icon", 1, 1).toJson(), 
                new Book(2, "Война и мир", "icon", 1, 1).toJson(),
                new Book(3, "Духхлес", "icon", 1, 1).toJson()
            };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value id: " + id;
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using pda_backend.Models;
using Microsoft.AspNetCore.Cors;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace pda_backend.Controllers
{
    // [DisableCors]
    [Route("api/[controller]")]
    [ApiController]
    public class GoalsController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public string Get()
        {
            Goal goal1 = new Goal(1, "Цель 1", "Защитить диплом", 0);
            Goal goal2 = new Goal(2, "Цель 2", "Научится играть на фортепиано", 0);
            Goal[] goals = new Goal[] { goal1, goal2 };
            return JsonConvert.SerializeObject(goals);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            Goal goal1 = new Goal(1, "Цель 1", "Защитить диплом", 80);
            Goal goal2 = new Goal(2, "Цель 2", "Научится играть на фортепиано", 30);
            Goal[] goals = new Goal[] { goal1, goal2 };
            foreach (Goal goal in goals) 
            {
                if (goal.Id == id)
                {
                    return JsonConvert.SerializeObject(goal);
                }
            }
            return "no items";
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
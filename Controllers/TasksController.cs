using System;
using System.Collections.Generic;
using System.Linq;
// using System.Threading.Tasks;
using pda_backend.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace pda_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        public static Task task1 = new Task(1, 1, "Задача 1", "Написать пояснительную записку", "Высокий", "done",1);
        public static Task task2 = new Task(2, 2, "Задача 2", "Смоделировать базу данных", "Высокий", "done",1);
        public static Task task3 = new Task(3, 3, "Задача 3", "Написать речь для выступления", "Высокий", "work",1);
        public static Task task4 = new Task(4, 4, "Задача 4", "Сделать презентацию", "Низкий", "work",1);
        public static Task task5 = new Task(5, 1, "Задача 1", "Выучить гамму до-мажор", "Высокий", "work",2);
        public Task[] tasks = new Task[] { task1, task2, task3, task4, task5 };
        // GET api/values
        [HttpGet]
        public string Get()
        {
            return "";
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            foreach (Task task in this.tasks)
            {
                if (task.Id == id)
                {
                    return JsonConvert.SerializeObject(task);
                }
            }
            return "no items";
        }

        [HttpGet("goalid/{id}")]
        public string GetByGoalId(int id)
        {
            List<Task> _tasks = new List<Task>();
            foreach (Task task in this.tasks)
            {
                if (task.GoalId == id)
                {
                    _tasks.Add(task);
                }
            }
            return JsonConvert.SerializeObject(_tasks);
        }
        
        [HttpGet("getmaxid/{goalId}")]
        public string GetMaxId(int goalId)
        {
            int maxId = 0;
            foreach (Task task in this.tasks)
            {
                if (task.GoalId == goalId && task.TaskTitleNum > maxId)
                {
                    maxId = task.TaskTitleNum;
                }
            }
            return JsonConvert.SerializeObject(maxId);
        }

        [HttpGet("statistic/{goalId}")]
        public string GetGoalStats(int goalId)
        {
            List<Task> _tasks = new List<Task>();
            int doneCount = 0;
            int workCount = 0;
            int totalCount = 0;
            foreach (Task task in this.tasks)
            {
                if (task.GoalId == goalId)
                {
                    // _tasks.Add(task);
                    if (task.Status == "done")
                    {
                        doneCount++;
                    }
                    if (task.Status == "work")
                    {
                        workCount++;
                    }
                    totalCount++;
                }
            }
            return JsonConvert.SerializeObject(new GoalStats(totalCount, workCount, doneCount, doneCount/totalCount));
        }

        [HttpGet("taskstatus/{id}/{status}")]
        public string GetByStatus(int id, string status)
        {
            List<Task> _tasks = new List<Task>();
            foreach (Task task in this.tasks)
            {
                if (task.GoalId == id && task.Status == status)
                {
                    _tasks.Add(task);
                }
            }
            return JsonConvert.SerializeObject(_tasks);
        }

        // POST api/values
        [HttpPost]
        public string Post([FromBody] string jsonData)
        {
            return JsonConvert.SerializeObject(jsonData);
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

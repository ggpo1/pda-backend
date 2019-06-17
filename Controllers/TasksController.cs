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
        public static Task task2 = new Task(2, 2, "Задача 2", "Смоделировать базу данных", "Низкий", "done",1);
        public static Task task3 = new Task(3, 3, "Задача 3", "Написать речь для выступления", "Высокий", "work",1);
        public static Task task4 = new Task(4, 4, "Задача 4", "Сделать презентацию", "Высокий", "work",1);
        public static Task task8 = new Task(8, 5, "Задача 5", "Сделать базу данных", "Высокий", "work",1);
        public static Task task9 = new Task(9, 6, "Задача 6", "Завести будильник", "Высокий", "work",1);
        public static Task task10 = new Task(9, 7, "Задача 7", "Погладить костюм", "Высокий", "done",1);
        public static Task task5 = new Task(5, 1, "Задача 1", "Выучить гамму ми-мажор", "Высокий", "work",2);
        public static Task task6 = new Task(6, 2, "Задача 2", "Выучить гамму до-мажор", "Высокий", "done",2);
        public static Task task7 = new Task(7, 3, "Задача 3", "Выучить гамму ре-мажор", "Низкий", "done",2);
        public Task[] tasks = new Task[] { task1, task2, task3, task4, task5, task6, task7, task8, task9, task10 };
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
            int doneCount = 0; int doneHigh = 0; int doneLow = 0;
            int workCount = 0;
            int totalCount = 0; int totalHigh = 0; int totalLow = 0;
            double goalProgress = 0;
            double personalEfficiency = 0;
            foreach (Task task in this.tasks)
            {
                if (task.GoalId == goalId)
                {
                    if (task.Status == "done") { doneCount++; }
                    if (task.Status == "work") { workCount++; }
                    if (task.Priority == "Высокий") { totalHigh++; }
                    if (task.Priority == "Низкий") { totalLow++; }
                    if (task.Priority == "Высокий" && task.Status == "done") { doneHigh++; }
                    if (task.Priority == "Низкий" && task.Status == "done") { doneLow++; }
                    totalCount++;
                }
            }
            // goalProgress = doneCount/totalCount;
            personalEfficiency = (doneCount+(0.2*doneHigh+0.1*doneLow))/(totalCount+(0.2*totalHigh+0.1*totalLow));
            return JsonConvert.SerializeObject(new GoalStats(totalCount, workCount, doneCount, personalEfficiency));
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
        [HttpPut("putdone/{id}")]
        public void PutDone(int id)
        {
            foreach (Task task in this.tasks)
            {
                if (task.Id == id)
                {
                    task.Status = "done";
                }
            }
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

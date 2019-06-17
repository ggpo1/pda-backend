using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

namespace pda_backend.Models
{
    [DataContract]
    public class Task 
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int TaskTitleNum { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public string Priority { get; set; }
        [DataMember]
        public string Status { get; set; }
        [DataMember]
        public int GoalId { get; set; }

        public Task(int id, int taskTitleNum, string title, string description, string priority, string status, int goalId)
        {
            Id = id;
            TaskTitleNum = taskTitleNum;
            Title = title;
            Description = description;
            Priority = priority;
            Status = status;
            GoalId = goalId;
        }

        // public string toJson()
        // {
        //     return JsonConvert.SerializeObject(this);
        // }
    }   
}
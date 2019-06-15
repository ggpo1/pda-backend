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
        public int TaskId { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public int StatusCode { get; set; }
        [DataMember]
        public int UserId { get; set; }

        public Task(int taskId, string title, int statusCode, int userId)
        {
            TaskId = taskId;
            Title = title;
            StatusCode = statusCode;
            UserId = userId;
        }

        // public string toJson()
        // {
        //     return JsonConvert.SerializeObject(this);
        // }
    }   
}
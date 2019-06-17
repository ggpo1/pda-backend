using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

namespace pda_backend.Models
{
    [DataContract]
    public class Goal
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public int Progress { get; set; }
        // [DataMember]
        // public int UserId { get; set; }

        public Goal(int id, string title, string description, int progress)
        {
            Id = id;
            Title = title;
            Description = description;
            Progress = progress;
        }

        public string toJson()
        {
            // Dictionary<string, string> jsonBook = new Dictionary<string, string>();
            // jsonBook.add("id", this.bookId.ToString());
            // jsonBook.add("title", this.title);
            // jsonBook.add("icon", this.icon);
            // jsonBook.add("genreId", this.genreId.ToString());
            // jsonBook.add("userId", this.userId.ToString());
            // return jsonBook;
            return JsonConvert.SerializeObject(this);
            // return "";
        }
    }
}
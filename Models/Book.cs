using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

namespace pda_backend.Models
{
    [DataContract]
    public class Book
    {
        [DataMember]
        public int BookId { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public string Icon { get; set; }
        [DataMember]
        public int GenreId { get; set; }
        [DataMember]
        public int UserId { get; set; }

        public Book(int bookId, string title, string icon, int genreId, int userId)
        {
            BookId = bookId;
            Title = title;
            Icon = icon;
            GenreId = genreId;
            UserId = userId;
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
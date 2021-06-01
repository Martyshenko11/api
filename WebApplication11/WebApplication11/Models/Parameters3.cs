using System.Collections.Generic;

namespace WebApplication1.Models
{
    public class Parameters3
    {
        public Results3 results { get; set; }
    }
    public class Book
    {
        public string description { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public string book_image { get; set; }
    }

    public class Results3
    {
        public string list_name { get; set; }
        public List<Book> books { get; set; }
    }
}

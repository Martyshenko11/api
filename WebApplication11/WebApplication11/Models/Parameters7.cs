using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Parameters7
    {
        public Results7 results { get; set; }
    }

    public class Comment
    {
        public string userDisplayName { get; set; }
        public string userLocation { get; set; }
        public string commentBody { get; set; }
    }

    public class Results7
    {
        public List<Comment> comments { get; set; }
    }
}

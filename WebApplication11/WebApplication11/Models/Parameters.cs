﻿using System.Collections.Generic;

namespace WebApplication1.Models
{
    public class Parameters
    {
        public List<Results> Results { get; set; }
    }
    public class Results
    {
        public string Url { get; set; }
        public string Published_date { get; set; }
        public string Section { get; set; }
        public string Title { get; set; }
    }
}

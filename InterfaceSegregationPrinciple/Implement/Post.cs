using System;

namespace InterfaceSegregationPrinciple.Implement
{
    public class Post
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime Date { get; set; }

        public int NumberOfViews { get; set; }
    }
}
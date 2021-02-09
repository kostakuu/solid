using System;
using System.Collections.Generic;

namespace LiskovSubstitutionPrinciple.Avoid
{
    public class Post
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime Date { get; set; }

        public int NumberOfViews { get; set; }

        public IEnumerable<Comment> Comments { get; set; }
    }
}
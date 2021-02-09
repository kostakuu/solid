using System;
using System.Collections.Generic;

namespace LiskovSubstitutionPrinciple.Avoid
{
    public class StandardReport
    {
        public IEnumerable<Post> Posts { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public IEnumerable<Post> GetTop10Posts()
        {
            // Calculate and return top 10 posts for report's date range
            return default;
        }

        public IEnumerable<Comment> GetTop10Comments()
        {
            // Calculate and return top 10 comments for report's posts
            return default;
        }
    }
}
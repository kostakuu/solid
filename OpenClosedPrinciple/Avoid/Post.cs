using System;

namespace OpenClosedPrinciple.Avoid
{
    public class Post
    {
        // Only for standard and video post
        public string Title { get; set; }

        // Only for standard and status posts
        public string Content { get; set; }

        // Only for video posts
        public string Url { get; set; }
        
        // For all types
        public DateTime Date { get; set; }

        // For all types
        public PostType Type { get; set; }
    }
}
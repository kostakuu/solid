using System.Collections.Generic;

namespace LiskovSubstitutionPrinciple.Implement
{
    public class StandardReport : BaseReport, ITopComments
    {
        public IEnumerable<Comment> GetTop10Comments()
        {
            // Calculate and return top 10 comments for report's posts
            return default;
        }
    }
}
using System.Collections.Generic;

namespace LiskovSubstitutionPrinciple.Implement
{
    public class ExtendedReport : StandardReport, IFeaturedPosts
    {
        public IEnumerable<Post> GetFeaturedPosts()
        {
            // Calculate and return featured posts for report's date range
            return default;
        }
    }
}
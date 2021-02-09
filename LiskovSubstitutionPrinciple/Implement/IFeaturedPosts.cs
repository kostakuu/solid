using System.Collections.Generic;

namespace LiskovSubstitutionPrinciple.Implement
{
    public interface IFeaturedPosts
    {
        IEnumerable<Post> GetFeaturedPosts();
    }
}
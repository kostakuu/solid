using System.Collections.Generic;

namespace LiskovSubstitutionPrinciple.Implement
{
    public interface ITopPosts
    {
        IEnumerable<Post> GetTop10Posts();
    }
}
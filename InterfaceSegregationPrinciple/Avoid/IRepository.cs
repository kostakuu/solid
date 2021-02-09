using System.Collections.Generic;

namespace InterfaceSegregationPrinciple.Avoid
{
    public interface IRepository
    {
        IEnumerable<Post> Read();

        void Write(IEnumerable<Post> posts);
    }
}
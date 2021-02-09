using System.Collections.Generic;

namespace InterfaceSegregationPrinciple.Implement
{
    public interface IWriteRepository
    {
        void Write(IEnumerable<Post> posts);
    }
}
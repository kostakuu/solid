using System.Collections.Generic;

namespace InterfaceSegregationPrinciple.Implement
{
    public interface IRepository : IWriteRepository
    {
        IEnumerable<Post> Read();
    }
}
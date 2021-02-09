using System.Collections.Generic;

namespace InterfaceSegregationPrinciple.Avoid
{
    public class DataBaseRepository : IRepository
    {
        public IEnumerable<Post> Read()
        {
            // implement reading posts from data base
            return default;
        }

        public void Write(IEnumerable<Post> posts)
        {
            // implement writing posts to the data base
        }
    }
}
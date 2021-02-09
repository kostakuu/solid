using System.Collections.Generic;

namespace InterfaceSegregationPrinciple.Avoid
{
    public class BackupRepository : IRepository
    {
        public IEnumerable<Post> Read()
        {
            throw new System.NotImplementedException();
        }

        public void Write(IEnumerable<Post> posts)
        {
            // implement generating backup and writing posts to JSONs file
        }
    }
}
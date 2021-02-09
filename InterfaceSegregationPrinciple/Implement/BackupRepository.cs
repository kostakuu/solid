using System.Collections.Generic;

namespace InterfaceSegregationPrinciple.Implement
{
    public class BackupRepository : IWriteRepository
    {
        public void Write(IEnumerable<Post> posts)
        {
            // implement generating backup and writing posts to JSONs file
        }
    }
}
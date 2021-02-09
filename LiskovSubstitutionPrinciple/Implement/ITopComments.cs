using System.Collections.Generic;

namespace LiskovSubstitutionPrinciple.Implement
{
    public interface ITopComments
    {
        IEnumerable<Comment> GetTop10Comments();
    }
}
namespace OpenClosedPrinciple.Implement
{
    public interface IGenericService<T>
    {
        T PublishPost(T post);
    }
}
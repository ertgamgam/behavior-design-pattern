namespace Iterator
{
    public interface IAggregate<out T>
    {
        IIterator<T> CreateIterator();
    }
}
namespace McrDDD.SeedWork
{
    public interface IEntity<out TKey> : IEntity
        where TKey : notnull
    {
        TKey Id { get; }
    }
    public interface IEntity
    {
        IReadOnlyCollection<IDomainEvent<IEntity>> Events { get; }

        IEnumerable<IDomainEvent<IEntity>> DequeenAllEvent();
    }
}
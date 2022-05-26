namespace McrDDD.SeedWork
{
    public interface IDomainEvent<out TEntity> : INotification
       where TEntity : IEntity
    {
        TEntity Target { get; }
    }
}
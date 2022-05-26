using System.ComponentModel.DataAnnotations;

namespace McrDDD.SeedWork
{
    public abstract class Entity<TKey> : IEntity<TKey>
        where TKey : notnull
    {
        [Key]
        public virtual TKey Id { get; protected set; } = default!;
        public virtual DateTimeOffset CreatedAt { get; set; } = default!;
        public virtual DateTimeOffset UpdatedAt { get; set; } = default!;

        private readonly Queue<IDomainEvent<IEntity<TKey>>> _events = new();

        public IReadOnlyCollection<IDomainEvent<IEntity>> Events => _events;
        protected void EnqueueEvent(IDomainEvent<IEntity<TKey>> @event) => _events.Enqueue(@event);
        public IEnumerable<IDomainEvent<IEntity>> DequeenAllEvent()
        {
            while (Events.Count != 0)
            {
                yield return _events.Dequeue();
            }
        }
    }
}
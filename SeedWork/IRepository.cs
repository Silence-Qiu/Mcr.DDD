using System.Linq.Expressions;

namespace McrDDD.SeedWork
{
    public interface IRepository<TEntity, in TKey>
        where TKey : notnull
        where TEntity : Entity<TKey>
    {
        TEntity Add(TEntity entity);
        IEnumerable<TEntity> AddRange(IEnumerable<TEntity> entities);
        TEntity Update(TEntity entity);
        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);
        void DeleteRange(Expression<Func<TEntity, bool>> whereExpression);
        Task<TEntity> FindAsync(TKey id);
        IQueryable<TEntity> FindAll();
        IQueryable<TEntity> FindAll(Expression<Func<TEntity, bool>> whereExpression);
    }
}

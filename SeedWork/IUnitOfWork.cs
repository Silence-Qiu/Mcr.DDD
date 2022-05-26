namespace McrDDD.SeedWork
{
    public interface IUnitOfWork
    {
        /// <summary>
        /// 持久化并返回修改的对象
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<IEnumerable<IEntity>> SaveAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// 开启事务
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task BeginTransactionAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// 提交事务
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task CommitTransactionAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// 回滚事务
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task RollbackTransactionAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// 获取当前事务ID
        /// </summary>
        /// <returns>当前事务ID,若为null,则表示事务未开启</returns>
        Guid? GetCurrentTransactionId();
    }
}

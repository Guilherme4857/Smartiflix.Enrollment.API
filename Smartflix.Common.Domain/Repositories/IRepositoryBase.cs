using Smartflix.Common.Domain.Entity;

namespace Smartflix.Common.Domain.Repositories
{
    /// <summary>
    /// Define repository base.
    /// </summary>
    /// <typeparam name="TEntity">Entity to repository.</typeparam>
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        /// <summary>
        /// Add item to the track.
        /// </summary>
        /// <typeparam name="T">Item type.</typeparam>
        /// <param name="entity">Item.</param>
        void Add<T>(T entity) where T : IEntity;

        /// <summary>
        /// Push all changes.
        /// </summary>
        /// <param name="cancellationToken">Cancelation token</param>
        /// <returns>Int to represent sucess.</returns>
        Task<int> Push(CancellationToken cancellationToken);
    }
}

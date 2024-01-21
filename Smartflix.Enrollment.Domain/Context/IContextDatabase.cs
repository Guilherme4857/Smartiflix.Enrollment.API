using Microsoft.EntityFrameworkCore;

namespace Smartflix.Enrollment.Domain.Context
{
    /// <summary>
    /// Define context database.
    /// </summary>
    public interface IContextDatabase
    {
        /// <summary>
        /// Save changes.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>Int that represent success.</returns>
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Create a new <see cref="DbSet{TEntity}"/>.
        /// </summary>
        /// <typeparam name="TEntity">Entity to create <see cref="DbSet{TEntity}"/>.</typeparam>
        /// <returns><see cref="DbSet{TEntity}"/>.</returns>
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
    }
}

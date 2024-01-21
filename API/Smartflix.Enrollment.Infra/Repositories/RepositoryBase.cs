using Microsoft.EntityFrameworkCore;
using Smartflix.Enrollment.Domain.Context;
using Smartflix.Enrollment.Domain.Entities;
using Smartflix.Enrollment.Domain.Repositories;

namespace Smartflix.Enrollment.Infra.Repositories
{
    /// <summary>
    /// Implement repository base.
    /// </summary>
    /// <typeparam name="TEntity">Entity type.</typeparam>
    public abstract class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        private IContextDatabase _context { get; }

        /// <summary>
        /// Initialize <see cref="RepositoryBase{TEntity}"/>.
        /// </summary>
        /// <param name="context">Database context.</param>
        protected RepositoryBase(IContextDatabase context)
        {
            _context = context;
            Entities = _context.Set<TEntity>();
        }

        /// <summary>
        /// DB set of the entity.
        /// </summary>
        protected DbSet<TEntity> Entities { get; set; }

        /// <inheritdoc/>
        public void Add<T>(T entity) where T : IEntity
            => Entities?.Add(entity as TEntity);

        /// <inheritdoc/>
        public async Task<int> Push(CancellationToken cancellationToken)
            => await _context.SaveChangesAsync(cancellationToken).ConfigureAwait(false);
    }
}

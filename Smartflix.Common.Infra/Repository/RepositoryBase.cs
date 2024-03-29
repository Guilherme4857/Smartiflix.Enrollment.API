﻿using Microsoft.EntityFrameworkCore;
using Smartflix.Common.Domain.Entity;
using Smartflix.Common.Domain.Repository;

namespace Smartflix.Common.Infra.Repository
{
    /// <summary>
    /// Implement repository base.
    /// </summary>
    /// <typeparam name="TContext">Context type.</typeparam>
    /// <typeparam name="TEntity">Entity type.</typeparam>
    public abstract class RepositoryBase<TContext, TEntity> : IRepositoryBase<TEntity> where TContext : DbContext
                                                                                       where TEntity : class
    {
        private TContext _context { get; }

        /// <summary>
        /// Initialize <see cref="RepositoryBase{TContext, TEntity}"/>.
        /// </summary>
        /// <param name="context">Database context.</param>
        protected RepositoryBase(TContext context)
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

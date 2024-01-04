using Enrollment.Database.Context;
using Microsoft.EntityFrameworkCore;

namespace Enrollment.Database.Repositories.Class
{
    public abstract class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        private IContextDatabase _context { get; }

        protected RepositoryBase(IContextDatabase context)
        {
            _context = context;
            Entities = _context.Set<TEntity>();
        }

        protected DbSet<TEntity> Entities { get; set; }

        public void Add(TEntity entity)
            => Entities?.Add(entity);

        public async Task<int> Push(CancellationToken cancellationToken)
            => await _context.SaveChangesAsync(cancellationToken).ConfigureAwait(false);
    }
}

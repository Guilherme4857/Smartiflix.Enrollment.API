using Enrollment.API.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Smartflix.Common.Infra.Repositories;
using Smartflix.Enrollment.Domain.Entities;
using Smartflix.Enrollment.Domain.Repositories;
using Smartflix.Enrollment.Infra.Context;

namespace Smartflix.Enrollment.Infra.Repositories
{
    /// <summary>
    /// Implement class category repository.
    /// </summary>
    public sealed class ClassCategoryRepository : RepositoryBase<ContextDatabase, ClassCategory>, IClassCategoryRepository
    {
        /// <summary>
        /// Initialize <see cref="ClassCategoryRepository"/>.
        /// </summary>
        /// <param name="context">Database context.</param>
        public ClassCategoryRepository(ContextDatabase context)
            : base(context)
        {
        }

        /// <inheritdoc/>
        public async Task<IClassCategory> GetById(int id, CancellationToken cancellationToken)
            => Entities.Local.FirstOrDefault(_ => _.Id.Equals(id)) ??
            await Entities.FirstOrDefaultAsync(_ => _.Id.Equals(id), cancellationToken).ConfigureAwait(false);

        /// <inheritdoc/>
        public IEnumerable<IClassCategory> GetAll()
            => Entities;
    }
}

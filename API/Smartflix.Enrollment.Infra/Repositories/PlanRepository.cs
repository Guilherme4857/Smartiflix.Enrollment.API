using Enrollment.API.Database.Entities;
using Smartflix.Common.Infra.Repository;
using Smartflix.Enrollment.Domain.Entities;
using Smartflix.Enrollment.Domain.Repositories;
using Smartflix.Enrollment.Infra.Context;

namespace Smartflix.Enrollment.Infra.Repositories
{
    /// <summary>
    /// Implement plan repository.
    /// </summary>
    public sealed class PlanRepository : RepositoryBase<ContextDatabase, Plan>, IPlanRepository
    {
        /// <summary>
        /// Initialize <see cref="PlanRepository"/>.
        /// </summary>
        /// <param name="context">Database context.</param>
        public PlanRepository(ContextDatabase context)
            : base(context)
        {
        }

        /// <inheritdoc/>
        public IEnumerable<IPlan> GetAll()
            => Entities;
    }
}

using Enrollment.API.Database.Entities;
using Smartflix.Enrollment.Domain.Context;
using Smartflix.Enrollment.Domain.Entities;
using Smartflix.Enrollment.Domain.Repositories;

namespace Smartflix.Enrollment.Infra.Repositories
{
    /// <summary>
    /// Implement plan repository.
    /// </summary>
    public sealed class PlanRepository : RepositoryBase<Plan>, IPlanRepository
    {
        /// <summary>
        /// Initialize <see cref="PlanRepository"/>.
        /// </summary>
        /// <param name="context">Database context.</param>
        public PlanRepository(IContextDatabase context)
            : base(context)
        {
        }

        /// <inheritdoc/>
        public IEnumerable<IPlan> GetAll()
            => Entities;
    }
}

using Enrollment.API.Database.Entities;
using Enrollment.Database.Context;

namespace Enrollment.Database.Repositories.Class
{
    public sealed class PlanRepository : RepositoryBase<Plan>, IPlanRepository
    {
        public PlanRepository(IContextDatabase context)
            : base(context)
        {
        }

        public IEnumerable<Plan> GetAll()
            => Entities;
    }
}

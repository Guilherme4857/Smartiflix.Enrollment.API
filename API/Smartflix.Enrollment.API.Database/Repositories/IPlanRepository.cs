using Enrollment.API.Database.Entities;

namespace Enrollment.Database.Repositories
{
    public interface IPlanRepository : IRepositoryBase<Plan>
    {
        IEnumerable<Plan> GetAll();
    }
}

using Enrollment.API.Database.Entities;

namespace Enrollment.Database.Repositories
{
    public interface IClassCategoryRepository : IRepositoryBase<ClassCategory>
    {
        Task<ClassCategory> GetById(int id, CancellationToken cancellationToken);

        IEnumerable<ClassCategory> GetAll();
    }
}

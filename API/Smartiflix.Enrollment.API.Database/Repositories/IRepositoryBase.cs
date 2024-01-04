using Microsoft.EntityFrameworkCore;

namespace Enrollment.Database.Repositories
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Add(TEntity entity);

        Task<int> Push(CancellationToken cancellationToken);
    }
}

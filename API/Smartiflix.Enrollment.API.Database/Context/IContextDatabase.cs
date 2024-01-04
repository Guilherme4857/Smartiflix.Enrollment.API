using Enrollment.API.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace Enrollment.Database.Context
{
    public interface IContextDatabase
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);

        DbSet<TEntity> Set<TEntity>() where TEntity : class;
    }
}

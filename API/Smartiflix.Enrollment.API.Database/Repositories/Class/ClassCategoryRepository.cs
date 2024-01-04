using Enrollment.API.Database.Entities;
using Enrollment.Database.Context;
using Microsoft.EntityFrameworkCore;

namespace Enrollment.Database.Repositories.Class
{
    public sealed class ClassCategoryRepository : RepositoryBase<ClassCategory>, IClassCategoryRepository
    {

        public ClassCategoryRepository(IContextDatabase context)
            : base (context) 
        { 
        }

        public async Task<ClassCategory> GetById(int id, CancellationToken cancellationToken)
            => Entities.Local.FirstOrDefault(_ => _.Id.Equals(id)) ??
            await Entities.FirstOrDefaultAsync(_ => _.Id.Equals(id), cancellationToken).ConfigureAwait(false);

        public IEnumerable<ClassCategory> GetAll()
            => Entities;
    }
}

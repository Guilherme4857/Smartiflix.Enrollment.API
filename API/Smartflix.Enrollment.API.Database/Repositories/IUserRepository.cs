using Enrollment.Database.Repositories;
using Smartflix.Enrollment.Database.Entities;

namespace Smartflix.Enrollment.Database.Repositories
{
    public interface IUserRepository : IRepositoryBase<User>
    {
        public Task<User> GetUserByEmail(string email, CancellationToken cancellationToken);
    }
}

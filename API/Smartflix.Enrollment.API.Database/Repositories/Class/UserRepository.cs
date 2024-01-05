using Enrollment.Database.Context;
using Enrollment.Database.Repositories.Class;
using Microsoft.EntityFrameworkCore;
using Smartflix.Enrollment.Database.Entities;

namespace Smartflix.Enrollment.Database.Repositories.Class
{
    public sealed class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(IContextDatabase context)
            : base(context)
        {
        }

        public async Task<User> GetUserByEmail(string email, CancellationToken cancellationToken)
            => await Entities.FirstOrDefaultAsync(_ => _.Email.Equals(email), cancellationToken).ConfigureAwait(false) ??
                     Entities.Local.FirstOrDefault(_ => _.Email.Equals(email));
    }
}

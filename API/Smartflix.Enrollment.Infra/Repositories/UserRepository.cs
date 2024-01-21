using Microsoft.EntityFrameworkCore;
using Smartflix.Enrollment.Database.Entities;
using Smartflix.Enrollment.Domain.Context;
using Smartflix.Enrollment.Domain.Repositories;

namespace Smartflix.Enrollment.Infra.Repositories
{
    /// <summary>
    /// Implement user repository.
    /// </summary>
    public sealed class UserRepository : RepositoryBase<User>, IUserRepository
    {
        /// <summary>
        /// Initialize <see cref="UserRepository"/>.
        /// </summary>
        /// <param name="context">Database context.</param>
        public UserRepository(IContextDatabase context)
            : base(context)
        {
        }

        /// <inheritdoc/>
        public async Task<IUser> GetByEmail(string email, CancellationToken cancellationToken)
            => await Entities.FirstOrDefaultAsync(_ => _.Email.Equals(email), cancellationToken).ConfigureAwait(false) ??
                     Entities.Local.FirstOrDefault(_ => _.Email.Equals(email));
    }
}

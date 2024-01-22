using Microsoft.EntityFrameworkCore;
using Smartflix.Common.Infra.Repository;
using Smartflix.Enrollment.Database.Entities;
using Smartflix.Enrollment.Domain.Repositories;
using Smartflix.Enrollment.Infra.Context;

namespace Smartflix.Enrollment.Infra.Repositories
{
    /// <summary>
    /// Implement user repository.
    /// </summary>
    public sealed class UserRepository : RepositoryBase<ContextDatabase, User>, IUserRepository
    {
        /// <summary>
        /// Initialize <see cref="UserRepository"/>.
        /// </summary>
        /// <param name="context">Database context.</param>
        public UserRepository(ContextDatabase context)
            : base(context)
        {
        }

        /// <inheritdoc/>
        public async Task<IUser> GetByEmail(string email, CancellationToken cancellationToken)
            => await Entities.FirstOrDefaultAsync(_ => _.Email.Equals(email), cancellationToken).ConfigureAwait(false) ??
                     Entities.Local.FirstOrDefault(_ => _.Email.Equals(email));
    }
}

using Smartflix.Enrollment.Database.Entities;

namespace Smartflix.Enrollment.Domain.Repositories
{
    /// <summary>
    /// Define user repository.
    /// </summary>
    public interface IUserRepository : IRepositoryBase<IUser>
    {
        /// <summary>
        /// Get user by e-mail.
        /// </summary>
        /// <param name="email">User e-mail.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>User.</returns>
        public Task<IUser> GetByEmail(string email, CancellationToken cancellationToken);
    }
}

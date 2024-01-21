using Smartflix.Enrollment.Domain.Enum;

namespace Smartflix.Enrollment.Database.Entities
{
    /// <summary>
    /// Implement entity user.
    /// </summary>
    public class User : IUser
    {
        /// <summary>
        /// Initialize <see cref="User"/>.
        /// </summary>
        /// <param name="id">User ID.</param>
        /// <param name="role">User role.</param>
        /// <param name="name">User name.</param>
        /// <param name="email">User e-mail.</param>
        /// <param name="password">User password.</param>
        public User(int id, RoleEnum role, string name, string email, string password)
        {
            Id = id;
            Role = role;
            Name = name;
            Email = email;
            Password = password;
        }

        /// <summary>
        /// Initialize <see cref="User"/>.
        /// </summary>
        /// <param name="role">User role.</param>
        /// <param name="name">User name.</param>
        /// <param name="email">User e-mail.</param>
        /// <param name="password">User password.</param>
        public User(RoleEnum role, string name, string email, string password)
            : this(0, role, name, email, password)
        {
        }

        /// <inheritdoc/>
        public int Id { get; }

        /// <inheritdoc/>
        public RoleEnum Role { get; set; }

        /// <inheritdoc/>
        public string Name { get; set; }

        /// <inheritdoc/>
        public string Email { get; set; }

        /// <inheritdoc/>
        public string Password { get; set; }
    }
}

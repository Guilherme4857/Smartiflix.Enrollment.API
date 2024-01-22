using Smartflix.Common.Domain.Entity;
using Smartflix.Enrollment.Domain.Enum;

namespace Smartflix.Enrollment.Database.Entities
{
    /// <summary>
    /// Define user interface.
    /// </summary>
    public interface IUser : IEntity
    {
        /// <summary>
        /// User ID.
        /// </summary>
        int Id { get; }

        /// <summary>
        /// User role.
        /// </summary>
        RoleEnum Role { get; set; }

        /// <summary>
        /// User name.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// User e-mail.
        /// </summary>
        string Email { get; set; }

        /// <summary>
        /// User password.
        /// </summary>
        string Password { get; set; }
    }
}

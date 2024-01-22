using Smartflix.Common.Domain.Entity;

namespace Smartflix.Enrollment.Domain.Entities
{
    /// <summary>
    /// Define the entity class category.
    /// </summary>
    public interface IClassCategory : IEntity
    {
        /// <summary>
        /// Class category ID.
        /// </summary>
        int Id { get; set; }

        /// <summary>
        /// Class category name.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Class category icon.
        /// </summary>
        string Icon { get; set; }

        /// <summary>
        /// Class category description.
        /// </summary>
        string Description { get; set; }

        /// <summary>
        /// Class category teacher.
        /// </summary>
        string Teacher { get; set; }
    }
}

using Smartflix.Enrollment.Domain.Entities;

namespace Enrollment.API.Database.Entities
{
    /// <summary>
    /// Implement entity class category.
    /// </summary>
    public class ClassCategory : IClassCategory
    {
        /// <summary>
        /// Initialize <see cref="ClassCategory"/>.
        /// </summary>
        /// <param name="id">Class category ID.</param>
        /// <param name="name">Class category name.</param>
        /// <param name="icon">Class category icon.</param>
        /// <param name="description">Class category description.</param>
        /// <param name="teacher">Class category teacher.</param>
        public ClassCategory(int id, string name, string icon, string description, string teacher)
        {
            Id = id;
            Name = name;
            Icon = icon;
            Description = description;
            Teacher = teacher;
        }

        /// <summary>
        /// Initialize <see cref="ClassCategory"/>.
        /// </summary>
        /// <param name="name">Class category name.</param>
        /// <param name="icon">Class category icon.</param>
        /// <param name="description">Class category description.</param>
        /// <param name="teacher">Class category teacher.</param>
        public ClassCategory(string name, string icon, string description, string teacher)
        {
            Name = name;
            Icon = icon;
            Description = description;
            Teacher = teacher;
        }

        /// <inheritdoc/>
        public int Id { get; set; }

        /// <inheritdoc/>
        public string Name { get; set; }

        /// <inheritdoc/>
        public string Icon { get; set; }

        /// <inheritdoc/>
        public string Description { get; set; }

        /// <inheritdoc/>
        public string Teacher { get; set; }
    }
}

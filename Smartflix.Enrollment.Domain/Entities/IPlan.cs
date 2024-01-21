namespace Smartflix.Enrollment.Domain.Entities
{
    /// <summary>
    /// Define the entity plan.
    /// </summary>
    public interface IPlan : IEntity
    {
        /// <summary>
        /// Plan name.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Plan monthly value.
        /// </summary>
        decimal MonthlyValue { get; set; }

        /// <summary>
        /// Total of classes.
        /// </summary>
        int ClassTotal { get; set; }

        /// <summary>
        /// Class categories.
        /// </summary>
        IEnumerable<IClassCategory> ClassCategories { get; }
    }
}

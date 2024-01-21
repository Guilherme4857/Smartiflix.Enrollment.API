using Smartflix.Enrollment.Domain.Entities;

namespace Enrollment.API.Database.Entities
{
    /// <summary>
    /// Implement entity plan.
    /// </summary>
    public class Plan : IPlan
    {
        /// <summary>
        /// Initialize <see cref="Plan"/>.
        /// </summary>
        /// <param name="name">Plan name.</param>
        /// <param name="monthlyValue">Plan monthly value.</param>
        /// <param name="classTotal">Total of classes.</param>
        public Plan(string name, decimal monthlyValue, int classTotal)
        {
            Name = name;
            MonthlyValue = monthlyValue;
            ClassTotal = classTotal;
        }

        /// <inheritdoc/>
        public string Name { get; set; }

        /// <inheritdoc/>
        public decimal MonthlyValue { get; set; }

        /// <inheritdoc/>
        public int ClassTotal { get; set; }

        /// <inheritdoc/>
        public virtual ICollection<ClassCategory> ClassCategories { get; set; }

        /// <inheritdoc/>
        IEnumerable<IClassCategory> IPlan.ClassCategories => ClassCategories;
    }
}

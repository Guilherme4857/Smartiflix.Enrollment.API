using Smartflix.Common.Domain.Repository;
using Smartflix.Enrollment.Domain.Entities;

namespace Smartflix.Enrollment.Domain.Repositories
{
    /// <summary>
    /// Define plan repository.
    /// </summary>
    public interface IPlanRepository : IRepositoryBase<IPlan>
    {
        /// <summary>
        /// Get all plans.
        /// </summary>
        /// <returns>Plans list.</returns>
        IEnumerable<IPlan> GetAll();
    }
}

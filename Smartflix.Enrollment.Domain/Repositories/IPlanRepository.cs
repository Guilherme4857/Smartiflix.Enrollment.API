using Smartflix.Common.Domain.Repositories;
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

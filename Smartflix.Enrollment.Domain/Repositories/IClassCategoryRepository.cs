using Smartflix.Enrollment.Domain.Entities;

namespace Smartflix.Enrollment.Domain.Repositories
{
    /// <summary>
    /// Define class category repository.
    /// </summary>
    public interface IClassCategoryRepository : IRepositoryBase<IClassCategory>
    {
        /// <summary>
        /// Get class category by ID.
        /// </summary>
        /// <param name="id">Class category ID.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>Class category.</returns>
        Task<IClassCategory> GetById(int id, CancellationToken cancellationToken);

        /// <summary>
        /// Get all class categories.
        /// </summary>
        /// <returns>Class categories list.</returns>
        IEnumerable<IClassCategory> GetAll();
    }
}

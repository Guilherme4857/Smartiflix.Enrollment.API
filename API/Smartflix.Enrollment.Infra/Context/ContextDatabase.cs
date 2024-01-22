using Microsoft.EntityFrameworkCore;
using Smartflix.Common.Infra.Context;
using Smartflix.Enrollment.Domain.Context;
using System.Reflection;

namespace Smartflix.Enrollment.Infra.Context
{
    /// <summary>
    /// Implement context database.
    /// </summary>
    public sealed class ContextDatabase : ContextBase, IContextDatabase
    {
        /// <summary>
        /// Initialize <see cref="ContextDatabase"/>.
        /// </summary>
        /// <param name="configuration">Configuration.</param>
        public ContextDatabase(DbContextOptions options)
            : base(options, Assembly.GetExecutingAssembly())
        {
        }
    }
}

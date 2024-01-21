using Enrollment.Database.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Smartflix.Enrollment.Database.Mapping;
using Smartflix.Enrollment.Domain.Context;

namespace Smartflix.Enrollment.Infra.Context
{
    /// <summary>
    /// Implement context database.
    /// </summary>
    public sealed class ContextDatabase : DbContext, IContextDatabase
    {
        private string _connectionString;

        /// <summary>
        /// Initialize <see cref="ContextDatabase"/>.
        /// </summary>
        /// <param name="configuration">Configuration.</param>
        public ContextDatabase(IConfiguration configuration)
        {
            _connectionString = configuration["ConnectionString"];
        }

        /// <inheritdoc/>
        protected sealed override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString)
                          .UseLazyLoadingProxies();
        }

        /// <inheritdoc/>
        protected sealed override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClassCategoryMapping())
                        .ApplyConfiguration(new PlanMapping())
                        .ApplyConfiguration(new UserMapping());
        }
    }
}

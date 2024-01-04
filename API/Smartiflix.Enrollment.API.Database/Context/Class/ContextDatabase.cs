using Enrollment.API.Database.Entities;
using Enrollment.Database.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Enrollment.Database.Context.Class
{
    public sealed class ContextDatabase : DbContext, IContextDatabase
    {
        private string? _connectionString;

        public ContextDatabase(IConfiguration configuration)
        {
            _connectionString = configuration["ConnectionString"];
        }

        protected sealed override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString)
                          .UseLazyLoadingProxies();
        }

        protected sealed override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClassCategoryMapping())
                        .ApplyConfiguration(new PlanMapping());
        }
    }
}

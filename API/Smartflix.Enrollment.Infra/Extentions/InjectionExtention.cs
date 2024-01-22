using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Smartflix.Enrollment.Domain.Context;
using Smartflix.Enrollment.Domain.Repositories;
using Smartflix.Enrollment.Infra.Context;
using Smartflix.Enrollment.Infra.Repositories;

namespace Enrollment.Database.Extentions
{
    /// <summary>
    /// Implement injection extensions.
    /// </summary>
    public static class InjectionExtention
    {
        /// <summary>
        /// Add SQL Server database.
        /// </summary>
        /// <param name="services">Service collection.</param>
        /// <param name="connectionString">Connection string.</param>
        /// <returns>Service collection.</returns>
        public static IServiceCollection AddSqlDatabaseContext(this IServiceCollection services, string connectionString)
            => services.AddDbContext<IContextDatabase, ContextDatabase>(_ => _.UseSqlServer(connectionString));

        /// <summary>
        /// Method to inject module's dependences.
        /// </summary>
        /// <param name="services">Services collection.</param>
        /// <returns>Services collection.</returns>
        public static IServiceCollection ModuleInjections(this IServiceCollection services)
            => services.AddScoped<IClassCategoryRepository, ClassCategoryRepository>()
                       .AddScoped<IPlanRepository, PlanRepository>()
                       .AddScoped<IUserRepository, UserRepository>();

    }
}

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
        /// Method to inject module's dependences.
        /// </summary>
        /// <param name="services">Services collection.</param>
        /// <returns>Services collection.</returns>
        public static IServiceCollection DataBaseInjections(this IServiceCollection services)
            => services.AddDbContext<IContextDatabase, ContextDatabase>()
                       .AddScoped<IClassCategoryRepository, ClassCategoryRepository>()
                       .AddScoped<IPlanRepository, PlanRepository>()
                       .AddScoped<IUserRepository, UserRepository>();

    }
}

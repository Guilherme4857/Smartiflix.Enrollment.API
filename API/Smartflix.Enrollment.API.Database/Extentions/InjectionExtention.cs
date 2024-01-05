using Enrollment.Database.Context;
using Enrollment.Database.Context.Class;
using Enrollment.Database.Repositories;
using Enrollment.Database.Repositories.Class;
using Microsoft.Extensions.DependencyInjection;
using Smartflix.Enrollment.Database.Repositories;
using Smartflix.Enrollment.Database.Repositories.Class;

namespace Enrollment.Database.Extentions
{
    public static class InjectionExtention
    {
        public static IServiceCollection DataBaseInjections(this IServiceCollection services)
            => services.AddDbContext<IContextDatabase, ContextDatabase>()
                       .AddScoped<IClassCategoryRepository, ClassCategoryRepository>()
                       .AddScoped<IPlanRepository, PlanRepository>()
                       .AddScoped<IUserRepository, UserRepository>();

    }
}

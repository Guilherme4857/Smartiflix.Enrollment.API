using Enrollment.Database.Context;
using Enrollment.Database.Context.Class;
using Enrollment.Database.Repositories;
using Enrollment.Database.Repositories.Class;
using Microsoft.Extensions.DependencyInjection;

namespace Enrollment.Database.Extentions
{
    public static class ExtentionInjection
    {
        public static IServiceCollection DataBaseInjections(this IServiceCollection services)
            => services.AddDbContext<IContextDatabase, ContextDatabase>()
                       .AddScoped<IClassCategoryRepository, ClassCategoryRepository>()
                       .AddScoped<IPlanRepository, PlanRepository>();

    }
}

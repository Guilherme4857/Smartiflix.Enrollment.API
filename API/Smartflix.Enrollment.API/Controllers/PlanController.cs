using Enrollment.API.Database.Entities;
using Enrollment.OR.EnrollPlan.Request;
using Enrollment.OR.GetClassCategories.Response;
using Enrollment.OR.GetPlan.Response;
using Microsoft.AspNetCore.Mvc;
using Smartflix.Enrollment.Domain.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Enrollment.API.Controllers
{
    [Route("api/plans")]
    [ApiController]
    public class PlanController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> EnrollPlan([FromBody] RequestPlanEnroll request, IPlanRepository planRepository, IClassCategoryRepository classCategoryRepository, CancellationToken cancellationToken)
        {
            List<ClassCategory> categories = new List<ClassCategory>();
            foreach (var categoryId in request.ClassCategoriesIds)
            {
                var classCategory = await classCategoryRepository.GetById(categoryId, cancellationToken).ConfigureAwait(false);
                categories.Add(classCategory as ClassCategory);
            }

            planRepository.Add(new Plan(request.Name, request.MonthlyValue, request.ClassTotal) { ClassCategories = categories });
            await planRepository.Push(cancellationToken).ConfigureAwait(false);

            return StatusCode(StatusCodes.Status200OK);
        }

        [HttpGet]
        public IEnumerable<FoundPlan> GetAllPlans(IPlanRepository planRepository)
        {
            var foundPlans = new List<FoundPlan>();
            var categories = new List<FoundClassCategory>();
            var plans = planRepository.GetAll();

            foreach (var plan in plans)
            {
                foreach (var classCategory in plan.ClassCategories)
                    categories.Add(new FoundClassCategory(
                        classCategory.Id,
                        classCategory.Name,
                        classCategory.Icon,
                        classCategory.Description,
                        classCategory.Teacher));

                foundPlans.Add(new FoundPlan(plan.Name, plan.MonthlyValue, plan.ClassTotal, categories));
            }

            return foundPlans;
        }
    }
}

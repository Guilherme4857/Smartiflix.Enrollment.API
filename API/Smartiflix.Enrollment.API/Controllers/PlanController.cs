using Enrollment.API.Database.Entities;
using Enrollment.Database.Context;
using Enrollment.Database.Context.Class;
using Enrollment.Database.Repositories;
using Enrollment.OR.EnrollPlan.Request;
using Enrollment.OR.GetClassCategories.Response;
using Enrollment.OR.GetPlan.Response;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Enrollment.API.Controllers
{
    [Route("api/plans")]
    [ApiController]
    public class PlanController : ControllerBase
    {
        public IPlanRepository _planRepository;
        public IClassCategoryRepository _classCategoryRepository;

        public PlanController(IPlanRepository planRepository, IClassCategoryRepository classCategoryRepository)
        {
            _planRepository = planRepository;
            _classCategoryRepository = classCategoryRepository;
        }

        [HttpPost]
        public async Task<IActionResult> EnrollPlan([FromBody] RequestPlanEnroll request, CancellationToken cancellationToken)
        {
            List<ClassCategory> categories = new List<ClassCategory>();
            foreach (var categoryId in request.ClassCategoriesIds)
            {
                var classCategory = await _classCategoryRepository.GetById(categoryId, cancellationToken).ConfigureAwait(false);
                categories.Add(classCategory);
            }

            var plan = new Plan(request.Name, request.MonthlyValue, request.ClassTotal);
            plan.ClassCategories = categories;

            _planRepository.Add(plan);
            await _planRepository.Push(cancellationToken).ConfigureAwait(false);

            return StatusCode(StatusCodes.Status200OK);
        }

        [HttpGet]
        public IEnumerable<FoundPlan> GetAllPlans()
        {
            var foundPlans = new List<FoundPlan>();
            var categories = new List<FoundClassCategory>();
            var plans = _planRepository.GetAll();
 
            foreach (var plan in plans)
            {
                foreach(var classCategory in plan.ClassCategories)
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

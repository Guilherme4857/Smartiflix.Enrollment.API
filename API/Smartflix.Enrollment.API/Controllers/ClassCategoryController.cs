using Enrollment.API.Database.Entities;
using Enrollment.Database.Repositories;
using Enrollment.OR.EnrollClassCategory.Request;
using Enrollment.OR.GetClassCategories.Response;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Enrollment.API.Controllers
{
    [Route("api/class-categories")]
    [ApiController, Consumes("application/json"), Produces("application/json")]
    public class ClassCategoryController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> EnrollClassCategory([FromBody] RequestClassCategoryEnroll request, IClassCategoryRepository classCategoryRepository, CancellationToken cancellationToken)
        {
            classCategoryRepository.Add(new ClassCategory(request.Name, request.Icon, request.Description, request.Teacher));

            await classCategoryRepository.Push(cancellationToken);

            return StatusCode(StatusCodes.Status200OK);
        }

        [HttpGet]
        [Authorize]
        public IEnumerable<FoundClassCategory> GetClassCategories(IClassCategoryRepository classCategoryRepository)
        {
            var foundClassCategories = new List<FoundClassCategory>();
            var classCategories = classCategoryRepository.GetAll();

            foreach (ClassCategory classCategory in classCategories)
                foundClassCategories.Add(
                    new FoundClassCategory(
                        classCategory.Id,
                        classCategory.Name,
                        classCategory.Icon,
                        classCategory.Description,
                        classCategory.Teacher));

            return foundClassCategories;
        }
    }
}

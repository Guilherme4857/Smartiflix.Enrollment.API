using Enrollment.API.Database.Entities;
using Enrollment.OR.EnrollStudent.Request;
using Microsoft.AspNetCore.Mvc;

namespace Enrollment.API.Controllers
{
    [Route("api/students")]
    [ApiController, Consumes("application/json"), Produces("application/json")]
    public class StudentController : ControllerBase
    {
        [HttpPost]
        public string EnrollStudent([FromBody] RequestStudentEnroll request)
        {
            var student = new Student(request.Name, request.Cpf, request.PaymentWay, "ohhhrqingkrk43464wrg");

            return student.Token;
        }

        //[HttpGet]
        //public string StudentLogin([FromBody])
    }
}

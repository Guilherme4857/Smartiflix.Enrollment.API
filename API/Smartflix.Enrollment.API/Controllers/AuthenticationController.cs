using Enrollment.OR.StudentLogin.Request;
using Microsoft.AspNetCore.Mvc;
using Smartflix.Enrollment.API.Services;
using Smartflix.Enrollment.Database.Entities;
using Smartflix.Enrollment.Database.Extentions;
using Smartflix.Enrollment.Domain.Repositories;
using Smartflix.Enrollment.OR.UserEnroll.Request;
using System.Security.Cryptography;

namespace Smartflix.Enrollment.API.Controllers
{
    [Route("api/authentication")]
    [ApiController]
    public sealed class AuthenticationController : ControllerBase
    {
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] RequestUserLogin userLogin, IUserRepository userRepository, IConfiguration configuration, CancellationToken cancellationToken)
        {
            var user = await userRepository.GetByEmail(userLogin.Email, cancellationToken).ConfigureAwait(false);

            if (user is null)
                return Unauthorized(new { message = "Email or password incorrect." });

            if (!userLogin.Password.VerifyHash(SHA256.Create(), user.Password))
                return Unauthorized(new { Message = "Email or password incorrect." });

            return Ok(new { Token = TokenService.GenerateToken(user as User, configuration.GetValue<string>("Params:Key")) });
        }

        [HttpPost("sign-up")]
        public async Task<IActionResult> EnrollUser([FromBody] RequestUserEnroll request, IUserRepository userRepository, CancellationToken cancellationToken)
        {
            if (!request.Password.Equals(request.ConfirmPassword))
                return BadRequest(new { Message = "Confirm password is different of password." });

            userRepository.Add<User>(entity: new(request.Role, request.Name, request.Email, request.Password.GetHash(SHA256.Create())));

            await userRepository.Push(cancellationToken);

            return Ok();
        }
    }
}

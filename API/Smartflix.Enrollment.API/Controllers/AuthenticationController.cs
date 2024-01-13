using Enrollment.OR.StudentLogin.Request;
using Microsoft.AspNetCore.Mvc;
using Smartflix.Enrollment.API.Services;
using Smartflix.Enrollment.Database.Extentions;
using Smartflix.Enrollment.Database.Repositories;
using System.Security.Cryptography;

namespace Smartflix.Enrollment.API.Controllers
{
    [Route("api/authentication")]
    [ApiController]
    public sealed class AuthenticationController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Login([FromBody] RequestUserLogin userLogin, IUserRepository userRepository, IConfiguration configuration, CancellationToken cancellationToken)
        {
            var user = await userRepository.GetUserByEmail(userLogin.Email, cancellationToken).ConfigureAwait(false);

            if (user is null)
                return Unauthorized(new { message = "Email or password incorrect." });

            if (!userLogin.Password.VerifyHash(SHA256.Create(), user.Password))
                return Unauthorized(new { Message = "Email or password incorrect." });

            return Ok(new { Token = TokenService.GenerateToken(user, configuration.GetValue<string>("Params:Key")) });
        }
    }
}

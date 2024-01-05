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
        private IUserRepository _userRepository;
        public IConfiguration _configuration;

        public AuthenticationController(IUserRepository userRepository, IConfiguration configuration)
        {
            _userRepository = userRepository;
            _configuration = configuration;
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromBody] RequestUserLogin userLogin, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetUserByEmail(userLogin.Email, cancellationToken).ConfigureAwait(false);

            if (user is null)
                return NotFound(new { message = "Email or password incorrect." });

            if (!userLogin.Password.VerifyHash(SHA256.Create(), user.Password))
                return NotFound(new { Message = "Email or password incorrect." });

            return Ok(new { Token = TokenService.GenerateToken(user, _configuration.GetValue<string>("Params:Key")) });
        }
    }
}

using Newtonsoft.Json;

namespace Enrollment.OR.StudentLogin.Request
{
    public sealed class RequestUserLogin
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }
    }
}

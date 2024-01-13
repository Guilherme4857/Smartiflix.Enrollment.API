﻿using Newtonsoft.Json;
using Smartflix.Enrollment.Database.Enum;

namespace Smartflix.Enrollment.OR.UserEnroll.Request
{
    public sealed class RequestUserEnroll
    {
        [JsonProperty("role")]
        public RoleEnum Role { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }
    }
}

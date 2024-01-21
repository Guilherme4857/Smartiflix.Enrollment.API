using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Enrollment.OR.EnrollClassCategory.Request
{
    public sealed class RequestClassCategoryEnroll
    {
        [Required, JsonProperty("name")]
        public string Name { get; set; }

        [Required, JsonProperty("icon")]
        public string Icon { get; set; }

        [Required, JsonProperty("description")]
        public string Description { get; set; }

        [Required, JsonProperty("teacher")]
        public string Teacher { get; set; }
    }
}

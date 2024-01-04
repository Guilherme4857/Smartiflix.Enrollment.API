using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Enrollment.OR.EnrollPlan.Request
{
    public sealed class RequestPlanEnroll
    {
        [Required, JsonProperty("name")]
        public string Name { get; set; }

        [Required, JsonProperty("monthlyValue")]
        public decimal MonthlyValue { get; set; }

        [Required, JsonProperty("classTotal")]
        public int ClassTotal { get; set; }

        [Required, JsonProperty("classCategoriesIds")]
        public int[] ClassCategoriesIds { get; set; }
    }
}

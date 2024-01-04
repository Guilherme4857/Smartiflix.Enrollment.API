using Enrollment.OR.Base.Enums;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Enrollment.OR.EnrollStudent.Request
{
    public sealed class RequestStudentEnroll
    {
        [Required, JsonProperty("name")]
        public string Name { get; set; }

        [Required, JsonProperty("cpf")]
        public string Cpf { get; set; }

        [Required, JsonProperty("paymentWay")]
        public PaymentWay PaymentWay { get; set; }
    }
}

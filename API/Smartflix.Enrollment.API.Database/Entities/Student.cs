using Enrollment.OR.Base.Enums;

namespace Enrollment.API.Database.Entities
{
    public sealed class Student
    {
        public Student(string name, string cpf, PaymentWay paymentWay, string token)
        {
            Name = name;
            Cpf = cpf;
            PaymentWay = paymentWay;
            Token = token;
        }

        public string Name { get; set; }

        public string Cpf { get; set; }

        public PaymentWay PaymentWay { get; set; }

        public string Token { get; set; }
    }
}

using Smartflix.Enrollment.Domain.Entities;
using Smartflix.Enrollment.Domain.Enum;

namespace Enrollment.API.Database.Entities
{
    /// <summary>
    /// Implement entity student.
    /// </summary>
    public sealed class Student : IStudent
    {
        /// <summary>
        /// Initialize <see cref="Student"/>.
        /// </summary>
        /// <param name="name">Student name.</param>
        /// <param name="cpf">Student CPF.</param>
        /// <param name="paymentWay">Student payment way.</param>
        /// <param name="token">Student token.</param>
        public Student(string name, string cpf, PaymentWay paymentWay, string token)
        {
            Name = name;
            Cpf = cpf;
            PaymentWay = paymentWay;
            Token = token;
        }

        /// <inheritdoc/>
        public string Name { get; set; }

        /// <inheritdoc/>
        public string Cpf { get; set; }

        /// <inheritdoc/>
        public PaymentWay PaymentWay { get; set; }

        /// <inheritdoc/>
        public string Token { get; set; }
    }
}

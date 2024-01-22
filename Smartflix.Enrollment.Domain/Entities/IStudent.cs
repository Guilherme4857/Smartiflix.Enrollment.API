using Smartflix.Common.Domain.Entity;
using Smartflix.Enrollment.Domain.Enum;

namespace Smartflix.Enrollment.Domain.Entities
{
    /// <summary>
    /// Define entity student.
    /// </summary>
    public interface IStudent : IEntity
    {
        /// <summary>
        /// Student name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Student CPF.
        /// </summary>
        public string Cpf { get; set; }

        /// <summary>
        /// Student payment way.
        /// </summary>
        public PaymentWay PaymentWay { get; set; }

        /// <summary>
        /// Student token.
        /// </summary>
        public string Token { get; set; }
    }
}

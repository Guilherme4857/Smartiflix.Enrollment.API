using Smartflix.Enrollment.Database.Enum;

namespace Smartflix.Enrollment.Database.Entities
{
    public class User
    {
        public User(int id, RoleEnum role, string name, string email, string password)
        {
            Id = id;
            Role = role;
            Name = name;
            Email = email;
            Password = password;
        }

        public User(RoleEnum role, string name, string email, string password)
            : this(0, role, name, email, password)
        {
        }

        public int Id { get; }

        public RoleEnum Role { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
    }
}

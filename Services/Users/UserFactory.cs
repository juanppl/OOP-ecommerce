using OOP_ecommerce.BaseModels;
using OOP_ecommerce.Models.Users;

namespace OOP_ecommerce.Services.Users
{
    public class UserFactory
    {
        public static User CreateUser(string role, string firstName, string lastName, string email, string password, string userName, string bio, bool isActive, List<string> permissions = null, List<int> assignedDepartments = null)
        {
            switch (role.ToLower())
            {
                case "admin":
                    return new AdminUser(firstName, lastName, email, password, userName, bio, isActive, permissions ?? new List<string>(), assignedDepartments ?? new List<int>());

                case "superadmin":
                    return new SuperAdminUser(firstName, lastName, email, password, userName, bio, isActive, permissions ?? new List<string>(), true);

                case "regular":
                    return new RegularUser(firstName, lastName, email, password, userName, bio, isActive);

                case "vip":
                    return new VipUser(firstName, lastName, email, password, userName, bio, isActive);

                default:
                    throw new ArgumentException("Tipo de usuario no válido.");
            }
        }
    }
}

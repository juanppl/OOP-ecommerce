using OOP_ecommerce.BaseModels;

namespace OOP_ecommerce.Models.Users
{
    public class SuperAdminUser : User
    {
        public List<string> GlobalPermissions { get; set; }
        public bool RoleManagementPermissions { get; set; }
        public bool IsSuperAdmin { get; private set; } = true;
        public SuperAdminUser(string firstName, string lastName, string email, string password, string userName, string bio, bool isActive, List<string> globalPermissions, bool roleManagementPermissions) :
            base(firstName, lastName, email, password, userName, bio, isActive)
        {
            GlobalPermissions = globalPermissions;
            RoleManagementPermissions = roleManagementPermissions;
        }
        public override string ToString()
        {
            return $"Super Admin User: {FirstName} {LastName} with email {Email}";
        }
    }
}

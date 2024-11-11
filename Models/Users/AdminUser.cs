using OOP_ecommerce.BaseModels;

namespace OOP_ecommerce.Models.Users
{
    public class AdminUser : User
    {
        public List<string> Permissions { get; set; }
        public List<int> AssignedDepartments { get; set; }
        public AdminUser(string firstName, string lastName, string email, string password, string userName, string bio, bool isActive, List<string> permissions, List<int> assignedDepartments) :
            base(firstName, lastName, email, password, userName, bio, isActive)
        {
            Permissions = permissions;
            AssignedDepartments = assignedDepartments;
        }
        public override string ToString()
        {
            return $"Admin User: {FirstName} {LastName} with email {Email}";
        }
    }
}

namespace OOP_ecommerce.BaseModels
{
    public abstract class User
    {
        public User(string firstName, string lastName, string email, string password, string userName, string bio, bool isActive)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            UserName = userName;
            Bio = bio;
            IsActive = isActive;
        }

        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public string Bio { get; set; }
        public bool IsActive { get; set; }
    }
}

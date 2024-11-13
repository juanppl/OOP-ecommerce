using System.ComponentModel.DataAnnotations;

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

        [StringLength(50, ErrorMessage = "El nombre no puede exceder los 50 caracteres.")]
        public string FirstName { get; set; }

        [StringLength(50, ErrorMessage = "El nombre completo no puede exceder los 50 caracteres.")]
        public string LastName { get; set; }

        [EmailAddress(ErrorMessage = "El correo electrónico no tiene un formato válido.")]
        public string Email { get; set; }

        [StringLength(20, MinimumLength = 8, ErrorMessage = "La contraseña debe tener al menos 8 caracteres.")]
        public string Password { get; set; }
        public string UserName { get; set; }
        public string Bio { get; set; }
        public bool IsActive { get; set; }
        public string TokenSesion { get; private set; }
        public override string ToString()
        {
            return $"User: {FirstName} {LastName} with email {Email}";
        }
        public bool IsAuthenticated()
        {
            return true;
        }
        public void setTokenSession(string tokenSession)
        {
            TokenSesion = tokenSession;
        }
    }
}

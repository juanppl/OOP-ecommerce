namespace OOP_ecommerce.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public string Bio { get; set; }
        public bool IsSuperUser { get; set; }
        public bool IsActive { get; set; }
        public ICollection<Order> Order { get; set; }
        public ICollection<ChatbotConversation> ChatbotConversation { get; set; }
    }
}

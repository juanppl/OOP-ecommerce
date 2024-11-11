using OOP_ecommerce.BaseModels;

namespace OOP_ecommerce.Models.Users
{
    public class VipUser : User
    {
        public VipUser(string firstName, string lastName, string email, string password, string userName, string bio, bool isActive) : 
            base(firstName, lastName, email, password, userName, bio, isActive)
        {
        }
        public decimal SeasonDiscount { get; private set; } = 0.05M;
        public decimal TaxesDiscount { get; private set; } = 0.02M;
        public virtual ICollection<Order> Order { get; set; }
        public virtual ICollection<ChatbotConversation> ChatbotConversation { get; set; }
    }
}

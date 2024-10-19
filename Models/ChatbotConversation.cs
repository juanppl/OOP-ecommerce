namespace OOP_ecommerce.Models
{
    public class ChatbotConversation
    {
        public int ChatbotConversationId { get; set; }
        public int UserId { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public DateTime RequestedDate { get; set; }
        public int Frequency { get; set; }
        public User User { get; set; }
    }
}

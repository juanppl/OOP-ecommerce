namespace OOP_ecommerce.BaseModels
{
    public class ChatbotConversation
    {
        public ChatbotConversation(int userId, string question, string answer, DateTime requestedDate, int frequency)
        {
            UserId = userId;
            Question = question;
            Answer = answer;
            RequestedDate = requestedDate;
            Frequency = frequency;
        }

        public int ChatbotConversationId { get; set; }
        public int UserId { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public DateTime RequestedDate { get; set; }
        public int Frequency { get; set; }
        public virtual User User { get; set; }
    }
}

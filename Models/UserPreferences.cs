namespace OOP_ecommerce.Models
{
    public class UserPreferences
    {
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public DateTime VisitDate { get; set; }
    }
}

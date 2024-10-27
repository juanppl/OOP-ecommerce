namespace OOP_ecommerce.BaseModels
{
    public class UserPreferences
    {
        public UserPreferences(int productId, DateTime visitDate)
        {
            ProductId = productId;
            VisitDate = visitDate;
        }

        public int UserId { get; set; }
        public int ProductId { get; set; }
        public DateTime VisitDate { get; set; }
    }
}

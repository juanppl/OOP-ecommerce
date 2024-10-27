namespace OOP_ecommerce.BaseModels
{
    public class Order
    {
        public Order(double price, DateTime creationDate, DateTime paidDate, string status, DateTime canceledDate, bool wasCanceled, int userId, User user)
        {
            Price = price;
            CreationDate = creationDate;
            PaidDate = paidDate;
            Status = status;
            CanceledDate = canceledDate;
            WasCanceled = wasCanceled;
            UserId = userId;
            User = user;
        }

        public int OrderId { get; set; }
        public double Price { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime PaidDate { get; set; }
        public string Status { get; set; }
        public DateTime CanceledDate { get; set; }
        public bool WasCanceled { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public virtual OrderHistory OrderHistory { get; set; }
    }
}

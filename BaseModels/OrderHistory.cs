namespace OOP_ecommerce.BaseModels
{
    public class OrderHistory
    {
        public OrderHistory(int orderId, double price, DateTime creationDate, DateTime paidDate, string status, DateTime canceledDate, bool wasCanceled, int userId)
        {
            OrderId = orderId;
            Price = price;
            CreationDate = creationDate;
            PaidDate = paidDate;
            Status = status;
            CanceledDate = canceledDate;
            WasCanceled = wasCanceled;
            UserId = userId;
        }

        public int OrderHistoryId { get; set; }
        public int OrderId { get; set; }
        public double Price { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime PaidDate { get; set; }
        public string Status { get; set; }
        public DateTime CanceledDate { get; set; }
        public bool WasCanceled { get; set; }
        public int UserId { get; set; }
        public virtual Order Order { get; set; }
    }
}

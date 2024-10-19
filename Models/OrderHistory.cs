namespace OOP_ecommerce.Models
{
    public class OrderHistory
    {
        public int OrderHistoryId { get; set; }
        public int OrderId { get; set; }
        public double Price { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime PaidDate { get; set; }
        public string Status { get; set; }
        public DateTime CanceledDate { get; set; }
        public bool WasCanceled { get; set; }
        public int UserId { get; set; }
        public Order Order { get; set; }
    }
}

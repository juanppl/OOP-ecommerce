namespace OOP_ecommerce.BaseModels
{
    public class Order
    {
        public Order(string status, int userId, List<Product> products)
        {
            CreationDate = DateTime.Now;
            Status = status;
            WasCanceled = false;
            UserId = userId;
            Products = products;
            TotalAmount = CalculateTotalAmount();
        }

        public int OrderId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime PaidDate { get; set; }
        public string Status { get; set; }
        public DateTime CanceledDate { get; set; }
        public bool WasCanceled { get; set; }
        public int UserId { get; set; }
        public List<Product> Products { get; set; }
        public double TotalAmount { get; set; }
        public bool IsAuthorized { get; set; }
        public bool IsPaid { get; set; }
        public User User { get; set; }
        public virtual OrderHistory OrderHistory { get; set; }

        private double CalculateTotalAmount()
        {
            double total = 0;
            foreach (var product in Products)
            {
                total += product.Price;
            }
            return total;
        }
    }
}

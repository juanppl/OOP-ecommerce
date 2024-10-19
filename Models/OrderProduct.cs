namespace OOP_ecommerce.Models
{
    public class OrderProduct
    {
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
}

namespace OOP_ecommerce.BaseModels
{
    public class OrderProduct
    {
        public OrderProduct(int orderId, double price, int quantity)
        {
            OrderId = orderId;
            Price = price;
            Quantity = quantity;
        }

        public int ProductId { get; set; }
        public int OrderId { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
}

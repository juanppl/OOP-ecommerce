namespace OOP_ecommerce.Models.Orders
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public int OrderId { get; set; }
        public double Amount { get; set; }
        public string PaymentMethod { get; set; }
        public bool IsSuccessfullPayment  { get; set; }
        public DateTime PaymentDate { get; set; }

        public Payment(int paymentId, int orderId, double amount, string paymentMethod)
        {
            PaymentId = paymentId;
            OrderId = orderId;
            Amount = amount;
            PaymentMethod= paymentMethod;
            IsSuccessfullPayment = false;
            PaymentDate = DateTime.Now;
        }
    }

}

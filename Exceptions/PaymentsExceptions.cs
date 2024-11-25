namespace OOP_ecommerce.Exceptions
{
    public class PaymentCreationException : Exception
    {
        public PaymentCreationException(string message) : base(message) { }

        public PaymentCreationException(string message, Exception innerException) : base(message, innerException) { }
    }

    public class PaymentConfirmationException : Exception
    {
        public PaymentConfirmationException(string message) : base(message) { }

        public PaymentConfirmationException(string message, Exception innerException) : base(message, innerException) { }
    }

}

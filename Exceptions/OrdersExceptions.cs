namespace OOP_ecommerce.Exceptions
{
    public class OrderCreationException : Exception
    {
        public OrderCreationException(string message) : base(message) { }

        public OrderCreationException(string message, Exception innerException) : base(message, innerException) { }
    }

    public class OrderAuthorizationException : Exception
    {
        public OrderAuthorizationException(string message) : base(message) { }

        public OrderAuthorizationException(string message, Exception innerException) : base(message, innerException) { }
    }

}

namespace OOP_ecommerce.Exceptions
{
    public class ProductCreationException : Exception
    {
        public ProductCreationException(string message) : base(message) { }

        public ProductCreationException(string message, Exception innerException) : base(message, innerException) { }
    }

    public class ProductNotFoundException : Exception
    {
        public ProductNotFoundException(string message) : base(message) { }

        public ProductNotFoundException(string message, Exception innerException) : base(message, innerException) { }
    }

    public class ProductAlreadyExistsException : Exception
    {
        public ProductAlreadyExistsException(string message) : base(message) { }

        public ProductAlreadyExistsException(string message, Exception innerException) : base(message, innerException) { }
    }

    public class ProductUpdateStockException : Exception
    {
        public ProductUpdateStockException(string message) : base(message) { }

        public ProductUpdateStockException(string message, Exception innerException) : base(message, innerException) { }
    }

}

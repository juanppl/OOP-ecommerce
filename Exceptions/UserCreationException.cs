namespace OOP_ecommerce.Exceptions
{
    public class UserCreationException : Exception
    {
        public UserCreationException(string message) : base(message) { }

        public UserCreationException(string message, Exception innerException) : base(message, innerException) { }
    }

}

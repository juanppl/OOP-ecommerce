namespace OOP_ecommerce.Interfaces
{
    public interface IProcessPayment
    {
        void StartPayment(int userId, double monto, string tokenSesion);
        bool VerifyPayment(int userId, double monto, string tokenSesion);
        void ConfirmPayment(int userId, double monto, string tokenSesion);
    }
}

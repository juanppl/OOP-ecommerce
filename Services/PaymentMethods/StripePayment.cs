using OOP_ecommerce.Interfaces;

namespace OOP_ecommerce.Services.PaymentMethods
{
    public class StripePayment : IProcessPayment
    {
        public void StartPayment(int userId, double monto, string tokenSesion)
        {
            // Iniciar pago con tarjeta
            Console.WriteLine($"Iniciando pago con tarjeta para el usuario {userId}, monto: {monto:C}.");
        }

        public bool VerifyPayment(int userId, double monto, string tokenSesion)
        {
            // Verificación de pago (simulada)
            Console.WriteLine($"Verificando pago con tarjeta para el usuario {userId}...");
            return true; // Supongamos que la verificación fue exitosa
        }

        public void ConfirmPayment(int userId, double monto, string tokenSesion)
        {
            // Confirmar pago con tarjeta
            Console.WriteLine($"Confirmando pago con tarjeta para el usuario {userId}, monto: {monto:C}.");
        }
    }

}

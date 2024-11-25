using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using OOP_ecommerce.Exceptions;
using OOP_ecommerce.Interfaces;
using OOP_ecommerce.Models.Orders;
using OOP_ecommerce.Utils;

namespace OOP_ecommerce.Services
{
    public class PaymentProcessor
    {
        private List<Payment> _payments;
        private OrderManagment _orderManagment;
        private LogManager _logger = LogManager.GetInstance();

        public PaymentProcessor(OrderManagment orderManagment)
        {
            _payments = new List<Payment>();
            _orderManagment = orderManagment;
        }

        public Payment CreatePayment(int orderId, IProcessPayment paymentProcess)
        {
            try
            {
                var order = _orderManagment.GetOrders().FirstOrDefault(o => o.OrderId == orderId);
                if (order == null || !order.IsAuthorized)
                {
                    Console.WriteLine("La orden no está autorizada.");
                    _logger.Log("La orden no está autorizada.");
                    throw new PaymentCreationException("La orden no está autorizada o no se encontró.");
                }

                var payment = new Payment(_payments.Count + 1, orderId, order.TotalAmount, paymentProcess.GetType().Name);
                _payments.Add(payment);
                Console.WriteLine($"payment de {payment.Amount:C} creado para la orden {orderId} con el método {paymentProcess.GetType().Name}.");
                _logger.Log($"payment de {payment.Amount:C} creado para la orden {orderId} con el método {paymentProcess.GetType().Name}.");
                return payment;
            }
            catch (Exception ex)
            {
                _logger.Log($"Error inesperado al crear el pago: {ex.Message}");
                Console.WriteLine($"Error inesperado al crear el pago: {ex.Message}");
                throw new PaymentCreationException("Hubo un error inesperado al crear el pago.", ex);
            }
        }

        // Confirmar el payment de una orden
        public void ConfirmPayment(int paymentId, IProcessPayment paymentProcess)
        {
            try
            {
                var payment = _payments.FirstOrDefault(p => p.PaymentId == paymentId);
                if (payment == null)
                {
                    Console.WriteLine("payment no encontrado.");
                    _logger.Log("payment no encontrado.");
                    throw new PaymentConfirmationException("Payment no encontrado.");
                }

                if (paymentProcess.VerifyPayment(payment.PaymentId, payment.Amount, "tokenSesion"))
                {
                    payment.IsSuccessfullPayment = true;
                    var orden = _orderManagment.GetOrders().FirstOrDefault(o => o.OrderId == payment.OrderId);
                    if (orden != null)
                    {
                        orden.IsPaid = true;
                    }

                    _logger.Log($"payment de la orden {payment.OrderId} confirmado.");
                    Console.WriteLine($"payment de la orden {payment.OrderId} confirmado.");
                }
                else
                {
                    _logger.Log("payment fallido.");
                    Console.WriteLine("payment fallido.");
                    throw new PaymentConfirmationException("La verificación del pago ha fallado.");
                }
            }
            catch (Exception ex)
            {
                _logger.Log($"Error inesperado al confirmar el pago: {ex.Message}");
                Console.WriteLine($"Error inesperado al confirmar el pago: {ex.Message}");
                throw new PaymentConfirmationException("Hubo un error inesperado al confirmar el pago.", ex);
            }
        }
    }

}

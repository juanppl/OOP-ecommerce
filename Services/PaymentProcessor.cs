using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
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
            var order = _orderManagment.GetOrders().FirstOrDefault(o => o.OrderId == orderId);
            if (order == null || !order.IsAuthorized)
            {
                Console.WriteLine("La orden no está autorizada.");
                _logger.Log("La orden no está autorizada.");
                return null;
            }

            var payment = new Payment(_payments.Count + 1, orderId, order.TotalAmount, paymentProcess.GetType().Name);
            _payments.Add(payment);
            Console.WriteLine($"payment de {payment.Amount:C} creado para la orden {orderId} con el método {paymentProcess.GetType().Name}.");
            _logger.Log($"payment de {payment.Amount:C} creado para la orden {orderId} con el método {paymentProcess.GetType().Name}.");
            return payment;
        }

        // Confirmar el payment de una orden
        public void ConfirmPayment(int paymentId, IProcessPayment paymentProcess)
        {
            var payment = _payments.FirstOrDefault(p => p.PaymentId == paymentId);
            if (payment == null)
            {
                Console.WriteLine("payment no encontrado.");
                _logger.Log("payment no encontrado.");
                return;
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
            }
        }
    }

}

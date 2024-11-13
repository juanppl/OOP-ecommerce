using Microsoft.AspNetCore.Mvc.RazorPages;
using OOP_ecommerce.Interfaces;
using OOP_ecommerce.Models.Orders;

namespace OOP_ecommerce.Services
{
    public class PaymentProcessor
    {
        private List<Payment> _payments;
        private OrderManagment _orderManagment;

        public PaymentProcessor(OrderManagment orderManagment)
        {
            _payments = new List<Payment>();
            _orderManagment = orderManagment;
        }

        public Payment CreatePayment(int orderId, IProcessPayment paymentProcess)
        {
            var order = _orderManagment.Orders.FirstOrDefault(o => o.OrderId == orderId);
            if (order == null || !order.IsAuthorized)
            {
                Console.WriteLine("La orden no está autorizada.");
                return null;
            }

            var payment = new Payment(_payments.Count + 1, orderId, order.TotalAmount, paymentProcess.GetType().Name);
            _payments.Add(payment);
            Console.WriteLine($"payment de {payment.Amount:C} creado para la orden {orderId} con el método {paymentProcess.GetType().Name}.");
            return payment;
        }

        // Confirmar el payment de una orden
        public void ConfirmPayment(int paymentId, IProcessPayment paymentProcess)
        {
            var payment = _payments.FirstOrDefault(p => p.PaymentId == paymentId);
            if (payment == null)
            {
                Console.WriteLine("payment no encontrado.");
                return;
            }

            if (paymentProcess.VerifyPayment(payment.PaymentId, payment.Amount, "tokenSesion"))
            {
                payment.IsSuccessfullPayment = true;
                var orden = _orderManagment.Orders.FirstOrDefault(o => o.OrderId == payment.OrderId);
                if (orden != null)
                {
                    orden.IsPaid = true;
                }

                Console.WriteLine($"payment de la orden {payment.OrderId} confirmado.");
            }
            else
            {
                Console.WriteLine("payment fallido.");
            }
        }
    }

}

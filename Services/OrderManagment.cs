using OOP_ecommerce.BaseModels;
using OOP_ecommerce.Exceptions;
using OOP_ecommerce.Utils;

namespace OOP_ecommerce.Services
{
    public class OrderManagment
    {
        public List<Order> Orders;
        public Dictionary<int, User> _users;
        public LogManager _logger = LogManager.GetInstance();

        public OrderManagment()
        {
            Orders = new List<Order>();
            _users = new Dictionary<int, User>();
        }

        public virtual List<Order> GetOrders() => Orders;

        // Crear una nueva orden
        public Order CreateOrder(int userId, List<Product> products)
        {
            try
            {
                if (!_users.ContainsKey(userId))
                {
                    throw new OrderCreationException("Usuario no encontrado para la creación de la orden.");
                }

                if (products == null || products.Count == 0)
                {
                    throw new OrderCreationException("La lista de productos no puede estar vacía.");
                }

                var nuevaOrden = new Order("Nueva", userId, products);
                Orders.Add(nuevaOrden);
                Console.WriteLine($"Orden {nuevaOrden.OrderId} creada para el usuario {userId}.");
                _logger.Log($"Orden {nuevaOrden.OrderId} creada para el usuario {userId}.");
                return nuevaOrden;
            }
            catch (Exception ex) 
            {
                _logger.Log($"Error inesperado al crear la orden: {ex.Message}");
                Console.WriteLine($"Error inesperado al crear la orden: {ex.Message}");
                throw new OrderCreationException("Hubo un error inesperado al crear la orden.", ex);
            }
        }

        // Autorizar una orden (verificar saldo y existencia de productos)
        public bool AutorizarOrden(int orderId, string tokenSesion)
        {
            try
            {
                var order = Orders.FirstOrDefault(o => o.OrderId == orderId);
                if (order == null)
                {
                    _logger.Log("Orden no encontrada.");
                    Console.WriteLine("Orden no encontrada.");
                    throw new OrderAuthorizationException("Orden no encontrada.");
                }

                var user = _users[order.UserId];
                if (!user.IsAuthenticated() || user.TokenSesion != tokenSesion)
                {
                    Console.WriteLine("El usuario no está autenticado.");
                    _logger.Log("El usuario no está autenticado.");
                    throw new OrderAuthorizationException("El usuario no está autenticado o el token es inválido.");
                }

                order.IsAuthorized = true;
                Console.WriteLine($"Orden {orderId} autorizada. El monto total es {order.TotalAmount:C}.");
                _logger.Log($"Orden {orderId} autorizada. El monto total es {order.TotalAmount:C}.");
                return true;
            }
            catch (Exception ex) 
            {
                _logger.Log($"Error inesperado al autorizar la orden: {ex.Message}");
                Console.WriteLine($"Error inesperado al autorizar la orden: {ex.Message}");
                throw new OrderAuthorizationException("Hubo un error inesperado al autorizar la orden.", ex);
            }
        }

        public void AgregarUsuario(User user)
        {
            _users[user.UserId] = user;
        }
    }

}

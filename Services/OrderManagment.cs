using OOP_ecommerce.BaseModels;

namespace OOP_ecommerce.Services
{
    public class OrderManagment
    {
        public List<Order> Orders;
        private Dictionary<int, User> _users;

        public OrderManagment()
        {
            Orders = new List<Order>();
            _users = new Dictionary<int, User>();
        }

        // Crear una nueva orden
        public Order CreateOrder(int userId, List<Product> products)
        {
            var nuevaOrden = new Order("Nueva", userId, products);
            Orders.Add(nuevaOrden);
            Console.WriteLine($"Orden {nuevaOrden.OrderId} creada para el usuario {userId}.");
            return nuevaOrden;
        }

        // Autorizar una orden (verificar saldo y existencia de productos)
        public bool AutorizarOrden(int orderId, string tokenSesion)
        {
            var order = Orders.FirstOrDefault(o => o.OrderId == orderId);
            if (order == null)
            {
                Console.WriteLine("Orden no encontrada.");
                return false;
            }

            var user = _users[order.UserId];
            if (!user.IsAuthenticated() || user.TokenSesion != tokenSesion)
            {
                Console.WriteLine("El usuario no está autenticado.");
                return false;
            }

            order.IsAuthorized = true;
            Console.WriteLine($"Orden {orderId} autorizada. El monto total es {order.TotalAmount:C}.");
            return true;
        }

        public void AgregarUsuario(User user)
        {
            _users[user.UserId] = user;
        }
    }

}

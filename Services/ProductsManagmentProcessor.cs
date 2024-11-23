using OOP_ecommerce.BaseModels;
using OOP_ecommerce.Utils;

namespace OOP_ecommerce.Services
{
    public class ProductsManagmentProcessor : ProductsManagment
    {
        private LogManager _logger = LogManager.GetInstance();

        public ProductsManagmentProcessor() : base() { }

        // Implementación de añadir un producto al inventario
        public override void AddProduct(Product product)
        {
            var existingProduct = Inventory.Find(p => p.ProductId == product.ProductId);
            if (existingProduct != null)
            {
                Console.WriteLine($"El producto {product.FullName} ya existe en el inventario.");
                _logger.Log($"El producto {product.FullName} ya existe en el inventario.");
            }
            else
            {
                Inventory.Add(product);
                Console.WriteLine($"Producto {product.FullName} añadido al inventario.");
                _logger.Log($"Producto {product.FullName} añadido al inventario.");
            }
        }

        // Implementación de eliminar un producto del inventario
        public override void DeleteProduct(int productId)
        {
            var product = Inventory.Find(p => p.ProductId == productId);
            if (product != null)
            {
                Inventory.Remove(product);
                Console.WriteLine($"Producto {product.FullName} eliminado del inventario.");
                _logger.Log($"Producto {product.FullName} eliminado del inventario.");
            }
            else
            {
                Console.WriteLine("Producto no encontrado en el inventario.");
                _logger.Log("Producto no encontrado en el inventario.");
            }
        }

        // Implementación de actualizar el stock de un producto
        public override void UpdateStock(int productId, int amount)
        {
            var product = Inventory.Find(p => p.ProductId == productId);
            if (product != null)
            {
                product.AvailableQty += amount;
                Console.WriteLine($"Stock de {product.FullName} actualizado. Nueva cantidad: {product.AvailableQty}");
                _logger.Log($"Stock de {product.FullName} actualizado. Nueva cantidad: {product.AvailableQty}");
            }
            else
            {
                Console.WriteLine("Producto no encontrado en el inventario.");
                _logger.Log("Producto no encontrado en el inventario.");
            }
        }
    }

}

using OOP_ecommerce.BaseModels;
using OOP_ecommerce.Interfaces;
using OOP_ecommerce.Utils;

namespace OOP_ecommerce.Services
{
    public class ProductsManagmentProcessor : ProductsManagment
    {
        private LogManager _logger = LogManager.GetInstance();
        private IProductFactory _productFactory;

        public ProductsManagmentProcessor(
            IProductFactory productFactory) : base()
        {
            _productFactory = productFactory;
        }

        public override Product CreateProduct(ProductType productType, string fullName, string displayName, string description, double price, bool isActive, DateTime creationDate, DateTime expireDate, int availableQty, bool isDeleted, int timesViewed, int timesBuyed, int categoryId, dynamic extraInfo1, dynamic extraInfo2)
        {
            switch (productType)
            {
                case ProductType.Desktop:
                    return _productFactory.CreateDesktop(fullName, displayName, description, price, isActive, creationDate, expireDate, availableQty, isDeleted, timesViewed, timesBuyed, categoryId, extraInfo1, extraInfo2);
                case ProductType.Laptop:
                    return _productFactory.CreateLaptop(fullName, displayName, description, price, isActive, creationDate, expireDate, availableQty, isDeleted, timesViewed, timesBuyed, categoryId, extraInfo1, extraInfo2);
                case ProductType.SmartWatch:
                    return _productFactory.CreateSmartWatch(fullName, displayName, description, price, isActive, creationDate, expireDate, availableQty, isDeleted, timesViewed, timesBuyed, categoryId, extraInfo1, extraInfo2);
                case ProductType.SmartPhone:
                    return _productFactory.CreateSmartphone(fullName, displayName, description, price, isActive, creationDate, expireDate, availableQty, isDeleted, timesViewed, timesBuyed, categoryId, extraInfo1, extraInfo2);
                case ProductType.Tablet:
                    return _productFactory.CreateTablet(fullName, displayName, description, price, isActive, creationDate, expireDate, availableQty, isDeleted, timesViewed, timesBuyed, categoryId, extraInfo1, extraInfo2);
                default:
                    throw new ArgumentException("Unknown product type.");
            }
        }

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

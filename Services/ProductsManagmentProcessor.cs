using OOP_ecommerce.BaseModels;
using OOP_ecommerce.Exceptions;
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
            try
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
                        throw new ProductCreationException("Tipo de producto desconocido.");
                }
            }
            catch (Exception ex)
            {
                _logger.Log($"Error inesperado al crear el producto: {ex.Message}");
                Console.WriteLine($"Error inesperado al crear el producto: {ex.Message}");
                throw new ProductCreationException("Hubo un error inesperado al crear el producto.", ex);
            }
        }

        // Implementación de añadir un producto al inventario
        public override void AddProduct(Product product)
        {
            try
            {
                var existingProduct = Inventory.Find(p => p.ProductId == product.ProductId);
                if (existingProduct != null)
                {
                    Console.WriteLine($"El producto {product.FullName} ya existe en el inventario.");
                    _logger.Log($"El producto {product.FullName} ya existe en el inventario.");
                    throw new ProductAlreadyExistsException($"El producto {product.FullName} ya existe en el inventario.");
                }
                else
                {
                    Inventory.Add(product);
                    Console.WriteLine($"Producto {product.FullName} añadido al inventario.");
                    _logger.Log($"Producto {product.FullName} añadido al inventario.");
                }
            }
            catch (Exception ex)
            {
                _logger.Log($"Error inesperado al añadir el producto: {ex.Message}");
                Console.WriteLine($"Error inesperado al añadir el producto: {ex.Message}");
                throw new ProductCreationException("Hubo un error inesperado al añadir el producto.", ex);
            }
        }

        // Implementación de eliminar un producto del inventario
        public override void DeleteProduct(int productId)
        {
            try
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
                    throw new ProductNotFoundException("Producto no encontrado en el inventario.");
                }
            }
            catch (Exception ex)
            {
                _logger.Log($"Error inesperado al eliminar el producto: {ex.Message}");
                Console.WriteLine($"Error inesperado al eliminar el producto: {ex.Message}");
                throw new ProductNotFoundException("Hubo un error inesperado al eliminar el producto.", ex);
            }
            
        }

        // Implementación de actualizar el stock de un producto
        public override void UpdateStock(int productId, int amount)
        {
            try
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
                    throw new ProductUpdateStockException("Producto no encontrado en el inventario.");
                }
            }
            catch(Exception ex)
            {
                _logger.Log($"Error inesperado al actualizar el stock del producto: {ex.Message}");
                Console.WriteLine($"Error inesperado al actualizar el stock del producto: {ex.Message}");
                throw new ProductUpdateStockException("Hubo un error inesperado al actualizar el stock del producto.", ex);
            }
        }
    }

}

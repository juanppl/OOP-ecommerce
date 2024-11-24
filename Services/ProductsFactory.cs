using OOP_ecommerce.BaseModels;
using OOP_ecommerce.Interfaces;
using OOP_ecommerce.Models.Products;

namespace OOP_ecommerce.Services
{
    public class ProductsFactory : IProductFactory
    {
        public Product CreateDesktop(string fullName, string displayName, string description, double price, bool isActive, DateTime creationDate, DateTime expireDate, int availableQty, bool isDeleted, int timesViewed, int timesBuyed, int categoryId, bool hasScreensIncluded, string typeOfCase)
        {
            return new Desktop(fullName, displayName, description, price, isActive, creationDate, expireDate, availableQty, isDeleted, timesViewed, timesBuyed, categoryId, hasScreensIncluded, typeOfCase);
        }

        public Product CreateLaptop(string fullName, string displayName, string description, double price, bool isActive, DateTime creationDate, DateTime expireDate, int availableQty, bool isDeleted, int timesViewed, int timesBuyed, int categoryId, string batteryBrand, int batteryLifeTime)
        {
            return new Laptop(fullName, displayName, description, price, isActive, creationDate, expireDate, availableQty, isDeleted, timesViewed, timesBuyed, categoryId, batteryBrand, batteryLifeTime);
        }

        public Product CreateSmartphone(string fullName, string displayName, string description, double price, bool isActive, DateTime creationDate, DateTime expireDate, int availableQty, bool isDeleted, int timesViewed, int timesBuyed, int categoryId, double screenSize, int cameraCount)
        {
            return new SmartPhone(fullName, displayName, description, price, isActive, creationDate, expireDate, availableQty, isDeleted, timesViewed, timesBuyed, categoryId, screenSize, cameraCount);
        }

        public Product CreateTablet(string fullName, string displayName, string description, double price, bool isActive, DateTime creationDate, DateTime expireDate, int availableQty, bool isDeleted, int timesViewed, int timesBuyed, int categoryId, int batteryLifeTime, string color)
        {
            return new Tablet(fullName, displayName, description, price, isActive, creationDate, expireDate, availableQty, isDeleted, timesViewed, timesBuyed, categoryId, batteryLifeTime, color);
        }

        public Product CreateSmartWatch(string fullName, string displayName, string description, double price, bool isActive, DateTime creationDate, DateTime expireDate, int availableQty, bool isDeleted, int timesViewed, int timesBuyed, int categoryId, string strapMaterial, double batteryDuration)
        {
            return new SmartWatch(fullName, displayName, description, price, isActive, creationDate, expireDate, availableQty, isDeleted, timesViewed, timesBuyed, categoryId, strapMaterial, batteryDuration);
        }
    }
}

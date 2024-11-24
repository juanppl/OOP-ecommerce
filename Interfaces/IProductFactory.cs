using OOP_ecommerce.BaseModels;

namespace OOP_ecommerce.Interfaces
{
    public interface IProductFactory
    {
        Product CreateDesktop(string fullName, string displayName, string description, double price, bool isActive, DateTime creationDate, DateTime expireDate, int availableQty, bool isDeleted, int timesViewed, int timesBuyed, int categoryId, bool hasScreensIncluded, string typeOfCase);
        Product CreateLaptop(string fullName, string displayName, string description, double price, bool isActive, DateTime creationDate, DateTime expireDate, int availableQty, bool isDeleted, int timesViewed, int timesBuyed, int categoryId, string batteryBrand, int batteryLifeTime);
        Product CreateSmartphone(string fullName, string displayName, string description, double price, bool isActive, DateTime creationDate, DateTime expireDate, int availableQty, bool isDeleted, int timesViewed, int timesBuyed, int categoryId, double screenSize, int cameraCount);
        Product CreateSmartWatch(string fullName, string displayName, string description, double price, bool isActive, DateTime creationDate, DateTime expireDate, int availableQty, bool isDeleted, int timesViewed, int timesBuyed, int categoryId, string strapMaterial, double batteryDuration);
        Product CreateTablet(string fullName, string displayName, string description, double price, bool isActive, DateTime creationDate, DateTime expireDate, int availableQty, bool isDeleted, int timesViewed, int timesBuyed, int categoryId, int batteryLifeTime, string color);
    }
}

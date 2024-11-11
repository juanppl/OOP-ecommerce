
using OOP_ecommerce.BaseModels;

namespace OOP_ecommerce.Models.Products
{
    public class Laptop : Product
    {
        public string BatteryBrand { get; set; }
        public int BatteryLifeTime { get; set; }
        public Laptop(string fullName, string displayName, string descripiton, double price, bool isActive, DateTime creationDate, DateTime expireDate, int availableQty, DateTime modificationDate, bool isDeleted, DateTime deletedDate, int timesViewed, int timesBuyed, int categoryId, string batteryBrand, int batteryLifeTime) : 
            base(fullName, displayName, descripiton, price, isActive, creationDate, expireDate, availableQty, modificationDate, isDeleted, deletedDate, timesViewed, timesBuyed, categoryId)
        {
            BatteryBrand = batteryBrand;
            BatteryLifeTime = batteryLifeTime;
        }
    }
}

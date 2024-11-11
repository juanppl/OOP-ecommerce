using OOP_ecommerce.BaseModels;

namespace OOP_ecommerce.Models.Products
{
    public class Tablet : Product
    {
        public int BatteryLifeTime { get; set; }
        public string Color { get; set; }
        public Tablet(string fullName, string displayName, string descripiton, double price, bool isActive, DateTime creationDate, DateTime expireDate, int availableQty, DateTime modificationDate, bool isDeleted, DateTime deletedDate, int timesViewed, int timesBuyed, int categoryId, int batteryLifeTime, string color) :
            base(fullName, displayName, descripiton, price, isActive, creationDate, expireDate, availableQty, modificationDate, isDeleted, deletedDate, timesViewed, timesBuyed, categoryId)
        {
            BatteryLifeTime = batteryLifeTime;
            Color = color;
        }
    }
}

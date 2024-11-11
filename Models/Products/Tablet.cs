using OOP_ecommerce.BaseModels;

namespace OOP_ecommerce.Models.Products
{
    public class Tablet : Product
    {
        public Tablet(string fullName, string displayName, string descripiton, double price, bool isActive, DateTime creationDate, DateTime expireDate, int availableQty, bool isDeleted, int timesViewed, int timesBuyed, int categoryId, int batteryLifeTime, string color, DateTime? deletedDate = null, DateTime? modificationDate = null) :
            base(fullName, displayName, descripiton, price, isActive, creationDate, expireDate, availableQty, isDeleted, timesViewed, timesBuyed, categoryId, deletedDate, modificationDate)
        {
            BatteryLifeTime = batteryLifeTime;
            Color = color;
        }

        public int BatteryLifeTime { get; set; }
        public string Color { get; set; }
        
    }
}

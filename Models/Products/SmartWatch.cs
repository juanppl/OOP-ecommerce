using OOP_ecommerce.BaseModels;

namespace OOP_ecommerce.Models.Products
{
    public class SmartWatch : Product
    {
        public string StrapMaterial { get; set; }
        public double BatteryDuration { get; set; }
        public SmartWatch(string fullName, string displayName, string descripiton, double price, bool isActive, DateTime creationDate, DateTime expireDate, int availableQty, DateTime modificationDate, bool isDeleted, DateTime deletedDate, int timesViewed, int timesBuyed, int categoryId, string strapMaterial, double batteryDuration) :
            base(fullName, displayName, descripiton, price, isActive, creationDate, expireDate, availableQty, modificationDate, isDeleted, deletedDate, timesViewed, timesBuyed, categoryId)
        {
            StrapMaterial = strapMaterial;
            BatteryDuration = batteryDuration;
        }
    }
}

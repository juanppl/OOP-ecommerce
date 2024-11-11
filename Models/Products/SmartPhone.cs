using OOP_ecommerce.BaseModels;

namespace OOP_ecommerce.Models.Products
{
    public class SmartPhone : Product
    {
        public double ScreenSize { get; set; }
        public int CameraCount { get; set; }
        public SmartPhone(string fullName, string displayName, string descripiton, double price, bool isActive, DateTime creationDate, DateTime expireDate, int availableQty, DateTime modificationDate, bool isDeleted, DateTime deletedDate, int timesViewed, int timesBuyed, int categoryId, double screenSize, int cameraCount) :
            base(fullName, displayName, descripiton, price, isActive, creationDate, expireDate, availableQty, modificationDate, isDeleted, deletedDate, timesViewed, timesBuyed, categoryId)
        {
            ScreenSize = screenSize;
            CameraCount = cameraCount;
        }
    }
}

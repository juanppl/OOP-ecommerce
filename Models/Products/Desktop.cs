
using OOP_ecommerce.BaseModels;

namespace OOP_ecommerce.Models.Products
{
    public class Desktop : Product
    {
        public bool HasScreensIncluded { get; set; }
        public string TypeOfCase { get; set; }
        public Desktop(string fullName, string displayName, string descripiton, double price, bool isActive, DateTime creationDate, DateTime expireDate, int availableQty, DateTime modificationDate, bool isDeleted, DateTime deletedDate, int timesViewed, int timesBuyed, int categoryId, bool hasScreensIncluded, string typeOfCase) : 
            base(fullName, displayName, descripiton, price, isActive, creationDate, expireDate, availableQty, modificationDate, isDeleted, deletedDate, timesViewed, timesBuyed, categoryId)
        {
            TypeOfCase = typeOfCase;
            HasScreensIncluded = hasScreensIncluded;
        }
    }
}

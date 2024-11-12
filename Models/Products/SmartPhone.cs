using OOP_ecommerce.BaseModels;

namespace OOP_ecommerce.Models.Products
{
    public class SmartPhone : Product
    {
        public SmartPhone(string fullName, string displayName, string descripiton, double price, bool isActive, DateTime creationDate, DateTime expireDate, int availableQty, bool isDeleted, int timesViewed, int timesBuyed, int categoryId, double screenSize, int cameraCount, DateTime? deletedDate = null, DateTime? modificationDate = null) : 
            base(fullName, displayName, descripiton, price, isActive, creationDate, expireDate, availableQty, isDeleted, timesViewed, timesBuyed, categoryId, deletedDate, modificationDate)
        {
            ScreenSize = screenSize;
            CameraCount = cameraCount;
        }

        public double ScreenSize { get; set; }
        public int CameraCount { get; set; }
        public override string DisplayProductInformation()
        {
            return $"SmartPhone Data = Name: {FullName}, Description: {Descripiton}, Price: {Price}, Cameras: {CameraCount}";
        }
        public void CalculatePrice(double discountPercentage, bool applyDiscount)
        {
            if (applyDiscount)
            {
                double discountAmount = Price * (discountPercentage / 100);
                Price -= discountAmount;
                Console.WriteLine($"Price for {DisplayName} updated with {discountPercentage}% discount. New price: {Price:C}");
            }
            else
            {
                Console.WriteLine("Discount application failed, no discount applied.");
            }
        }

        public void CalculatePrice(List<double> discountPercentage, bool applyDiscount)
        {
            if (applyDiscount)
            {
                double discountAmount = Price * (discountPercentage.Sum() / 100);
                Price -= discountAmount;
                Console.WriteLine($"Price for {DisplayName} updated with {discountPercentage}% discount. New price: {Price:C}");
            }
            else
            {
                Console.WriteLine("Discount application failed, no discount applied.");
            }
        }

    }
}

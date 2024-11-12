using OOP_ecommerce.BaseModels;

namespace OOP_ecommerce.Models.Products
{
    public class SmartWatch : Product
    {
        public SmartWatch(string fullName, string displayName, string descripiton, double price, bool isActive, DateTime creationDate, DateTime expireDate, int availableQty, bool isDeleted, int timesViewed, int timesBuyed, int categoryId, string strapMaterial, double batteryDuration, DateTime? deletedDate = null, DateTime? modificationDate = null) :
            base(fullName, displayName, descripiton, price, isActive, creationDate, expireDate, availableQty, isDeleted, timesViewed, timesBuyed, categoryId, deletedDate, modificationDate)
        {
            StrapMaterial = strapMaterial;
            BatteryDuration = batteryDuration;
        }

        public string StrapMaterial { get; set; }
        public double BatteryDuration { get; set; }
        public override string DisplayProductInformation()
        {
            return $"SmartWatch Data = Name: {FullName}, Description: {Descripiton}, Price: {Price}, Strap: {StrapMaterial}";
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

﻿
using OOP_ecommerce.BaseModels;
using OOP_ecommerce.Interfaces;

namespace OOP_ecommerce.Models.Products
{
    public class Laptop : Product, IProductPrice
    {
        public Laptop(string fullName, string displayName, string descripiton, double price, bool isActive, DateTime creationDate, DateTime expireDate, int availableQty, bool isDeleted, int timesViewed, int timesBuyed, int categoryId, string batteryBrand, int batteryLifeTime, DateTime? deletedDate = null, DateTime? modificationDate = null) : 
            base(fullName, displayName, descripiton, price, isActive, creationDate, expireDate, availableQty, isDeleted, timesViewed, timesBuyed, categoryId, deletedDate, modificationDate)
        {
            BatteryBrand = batteryBrand;
            BatteryLifeTime = batteryLifeTime;
        }

        public string BatteryBrand { get; set; }
        public int BatteryLifeTime { get; set; }
        public override string DisplayProductInformation()
        {
            return $"Laptop Data = Name: {FullName}, Description: {Descripiton}, Price: {Price}, Battery: {BatteryBrand}";
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

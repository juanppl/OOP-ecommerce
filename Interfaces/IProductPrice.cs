namespace OOP_ecommerce.Interfaces
{
    public interface IProductPrice
    {
        void CalculatePrice(double discountPercentage, bool applyDiscount);
        void CalculatePrice(List<double> discountPercentage, bool applyDiscount);
    }
}

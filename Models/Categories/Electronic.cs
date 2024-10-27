using OOP_ecommerce.BaseModels;

namespace OOP_ecommerce.Models.Categories
{
    public class Electronic : Category
    {
        public Electronic(string fullName, string displayName, ICollection<Product> product) : 
            base(fullName, displayName, product)
        {
        }
    }
}

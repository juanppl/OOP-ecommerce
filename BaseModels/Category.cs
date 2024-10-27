namespace OOP_ecommerce.BaseModels
{
    public class Category
    {
        public Category(string fullName, string displayName, ICollection<Product> product)
        {
            FullName = fullName ?? string.Empty;
            DisplayName = displayName ?? string.Empty;  
            Product = product ?? new List<Product>();
        }

        public int CategoryId { get; set; }
        public string FullName { get; set; }
        public string DisplayName { get; set; }
        public ICollection<Product> Product { get; set; }
    }
}

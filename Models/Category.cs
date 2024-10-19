namespace OOP_ecommerce.Models
{
    public class Category
    {
        public Category()
        {
            Product = new List<Product>();
        }
        public int CateogryId { get; set; }
        public string FullName { get; set; }
        public string DisplayName { get; set; }
        public ICollection<Product> Product { get; set; }
    }
}

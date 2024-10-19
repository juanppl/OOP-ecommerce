namespace OOP_ecommerce.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string FullName { get; set; }
        public string DisplayName { get; set; }
        public string Descripiton { get; set; }
        public double Price { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public int AvailableQty { get; set; }
        public DateTime ModificationDate { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DeletedDate { get; set; }
        public int TimesViewed { get; set; }
        public int TimesBuyed { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}

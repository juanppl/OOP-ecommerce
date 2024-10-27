namespace OOP_ecommerce.BaseModels
{
    public class Product
    {
        public Product(string fullName, string displayName, string descripiton, double price, bool isActive, DateTime creationDate, DateTime expireDate, int availableQty, DateTime modificationDate, bool isDeleted, DateTime deletedDate, int timesViewed, int timesBuyed, int categoryId)
        {
            FullName = fullName;
            DisplayName = displayName;
            Descripiton = descripiton;
            Price = price;
            IsActive = isActive;
            CreationDate = creationDate;
            ExpireDate = expireDate;
            AvailableQty = availableQty;
            ModificationDate = modificationDate;
            IsDeleted = isDeleted;
            DeletedDate = deletedDate;
            TimesViewed = timesViewed;
            TimesBuyed = timesBuyed;
            CategoryId = categoryId;
        }

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
        public virtual Category Category { get; set; }
    }
}

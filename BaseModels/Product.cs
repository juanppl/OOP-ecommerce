using System.ComponentModel.DataAnnotations;

namespace OOP_ecommerce.BaseModels
{
    public abstract class Product
    {
        public Product(string fullName, string displayName, string descripiton, double price, bool isActive, DateTime creationDate, DateTime expireDate, int availableQty, bool isDeleted, int timesViewed, int timesBuyed, int categoryId, DateTime? deletedDate = null, DateTime? modificationDate = null)
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

        [StringLength(200, ErrorMessage = "El nombre completo no puede exceder los 200 caracteres.")]
        public string FullName { get; set; }

        [StringLength(200, ErrorMessage = "El nombre completo no puede exceder los 200 caracteres.")]
        public string DisplayName { get; set; }

        [StringLength(500, ErrorMessage = "El nombre completo no puede exceder los 500 caracteres.")]
        public string Descripiton { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "El precio debe ser mayor que cero.")]
        public double Price { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }

        [DataType(DataType.Date)]
        [CustomValidation(typeof(Product), "ValidateExpireDate")]
        public DateTime ExpireDate { get; set; }

        // Validación personalizada para la fecha de caducidad
        public static ValidationResult ValidateExpireDate(DateTime expireDate, ValidationContext context)
        {
            if (expireDate <= DateTime.Now)
            {
                return new ValidationResult("La fecha de caducidad debe ser posterior a la fecha actual.");
            }
            return ValidationResult.Success;
        }
        public int AvailableQty { get; set; }
        public DateTime? ModificationDate { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int TimesViewed { get; set; }
        public int TimesBuyed { get; set; }
        public int CategoryId { get; set; }
        public virtual Category? Category { get; set; }

        public virtual string DisplayProductInformation()
        {
            return $"Name: {FullName}, Description: {Descripiton}, Price: {Price}";
        }
    }
}

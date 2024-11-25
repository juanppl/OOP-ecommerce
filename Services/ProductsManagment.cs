using OOP_ecommerce.BaseModels;
using OOP_ecommerce.Utils;
using System;
using System.Collections.Generic;

namespace OOP_ecommerce.Services
{
    public abstract class ProductsManagment
    {
        public List<Product> Inventory { get; set; }

        public ProductsManagment()
        {
            Inventory = new List<Product>();
        }

        public abstract Product CreateProduct(ProductType productType, string fullName, string displayName, string description, double price, bool isActive, DateTime creationDate, DateTime expireDate, int availableQty, bool isDeleted, int timesViewed, int timesBuyed, int categoryId, dynamic extraInfo1, dynamic extraInfo2);
        public abstract void AddProduct(Product product);
        public abstract void DeleteProduct(int productId);
        public abstract void UpdateStock(int productId, int amount);
    }

}

using OOP_ecommerce.BaseModels;
using System;
using System.Collections.Generic;

namespace OOP_ecommerce.Services
{
    public abstract class ProductsManagment
    {
        protected List<Product> Inventory { get; set; }

        public ProductsManagment()
        {
            Inventory = new List<Product>();
        }

        public abstract void AddProduct(Product product);
        public abstract void DeleteProduct(int productId);
        public abstract void UpdateStock(int productId, int amount);
    }

}

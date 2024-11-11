using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OOP_ecommerce.BaseModels;
using OOP_ecommerce.Models.Products;

namespace OOP_ecommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EcommerceController : ControllerBase
    {
        [HttpGet]
        public void GenerateEcommerceExecution()
        {
            List<Product> products = GenerateListOfProducts();
            products.ForEach(p => {
                Console.WriteLine(p.DisplayProductInformation());
            });
        }

        private List<Product> GenerateListOfProducts()
        {
            var products = new List<Product>();
            products.Add( new Laptop
            (
                availableQty: 1,
                batteryBrand: "Samsung",
                descripiton: "A good laptop",
                batteryLifeTime: 50000,
                categoryId: 2,
                creationDate: DateTime.Now,
                displayName: "ASUS ROG",
                expireDate: DateTime.Now,
                fullName: "ASUS ROG",
                isActive: true,
                price: 1340,
                timesBuyed: 0,
                timesViewed: 0,
                isDeleted: false,
                modificationDate: null,
                deletedDate: null
            ));
            products.Add(new Desktop
            (
                availableQty: 1,
                descripiton: "A good and efficient PC",
                categoryId: 2,
                creationDate: DateTime.Now,
                displayName: "Dell XPS",
                expireDate: DateTime.Now,
                fullName: "Dell XPS",
                isActive: true,
                price: 850.33,
                timesBuyed: 0,
                timesViewed: 0,
                isDeleted: false,
                modificationDate: null,
                deletedDate: null,
                hasScreensIncluded: false,
                typeOfCase: "Full Tower"
            ));
            products.Add(new SmartPhone
            (
                availableQty: 1,
                descripiton: "Best Cellphone in market",
                categoryId: 2,
                creationDate: DateTime.Now,
                displayName: "Iphone 15",
                expireDate: DateTime.Now,
                fullName: "Iphone 15",
                isActive: true,
                price: 2599,
                timesBuyed: 0,
                timesViewed: 0,
                isDeleted: false,
                modificationDate: null,
                deletedDate: null,
                screenSize: 17.5,
                cameraCount: 4
            ));
            products.Add(new SmartWatch
            (
                availableQty: 1,
                descripiton: "Measure your life",
                categoryId: 2,
                creationDate: DateTime.Now,
                displayName: "Xiaomi",
                expireDate: DateTime.Now,
                fullName: "Xiaomi",
                isActive: true,
                price: 130,
                timesBuyed: 0,
                timesViewed: 0,
                isDeleted: false,
                modificationDate: null,
                deletedDate: null,
                strapMaterial: "Leather",
                batteryDuration: 80000
            ));
            return products;
        }

    }
}

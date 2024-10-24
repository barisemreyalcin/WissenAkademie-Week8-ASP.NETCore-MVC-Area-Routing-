using Microsoft.AspNetCore.Mvc;
using RoutingApp.Models;

namespace RoutingApp.Controllers
{
    public class ProductController : Controller
    {

        List<Product> productList = new List<Product>()
        {
            new Product()
            {
                ProductID = 1,
                ProductName = "55 inch TV",
                CategoryID = 1,
                CategoryName = "Electronics",
                Description = "Samsung 55 inch Led TV"
            },
             new Product()
            {
                ProductID = 2,
                ProductName = "Man jeans",
                CategoryID = 2,
                CategoryName = "Men clothing",
                Description = "36 size blue jeans for men"
            },
                new Product()
            {
                ProductID = 3,
                ProductName = "Mini oven",
                CategoryID = 3,
                CategoryName = "Small appliances",
                Description = "Beko microwave mini oven"
            },
                 new Product()
            {
                ProductID = 4,
                ProductName = "Man t-shirt",
                CategoryID = 2,
                CategoryName = "Men clothing",
                Description = "V-neck black t-shirt for men"
            },
        };
        public IActionResult Index()
        {
            return View();
        }


        [Route("product-category-{categoryId}-{categoryName}-{productId}-{productName}")]
        [Route("home/product-category-{categoryId}-{categoryName}-{productId}-{productName}")]
        public IActionResult Detail(int productID)
        {
            var product = productList.FirstOrDefault(x =>  x.ProductID == productID);
            if(product == null) return BadRequest();

            return View(product);
        }
    }
}

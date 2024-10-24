using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RoutingApp.Models;

namespace RoutingApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

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

        [Route("")]
        [Route("Home")]
        [Route("Home/Index")]
        public IActionResult Index()
        {
            return View(productList);
        }

        [Route("Privacy")]
        [Route("Home/Privacy")]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

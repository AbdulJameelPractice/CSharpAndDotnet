using Microsoft.AspNetCore.Mvc;
using Northwind.MVC.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Packt.Shared;

namespace Northwind.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly NorthwindContext _dbContext;

        public HomeController(ILogger<HomeController> logger, NorthwindContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            HomeIndexViewModel model = new(new Random().Next(1, 1001), Categories: _dbContext.Categories.ToList(),
                Products: _dbContext.Products.ToList());
            return View(model);
        }

        [Authorize(Roles = "Administrators")]
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
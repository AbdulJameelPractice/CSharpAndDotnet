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
        private readonly IHttpClientFactory httpClientFactory;
        public HomeController(ILogger<HomeController> logger, NorthwindContext dbContext, IHttpClientFactory httpClientFactory)
        {
            _logger = logger;
            _dbContext = dbContext;
            this.httpClientFactory = httpClientFactory;
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

        public async Task<IActionResult> Customers(string country)
        {
            string uri;
            if(string.IsNullOrEmpty(country))
            {
                uri = "customer";
            }
            else
            {
                uri = $"customer?country={country}";
            }

            HttpClient client = httpClientFactory.CreateClient("Northwind.API");
            HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Get, uri);
            HttpResponseMessage responseMessage = await client.SendAsync(requestMessage);
            IEnumerable<Customer>? model = await responseMessage.Content.ReadFromJsonAsync<IEnumerable<Customer>>();
            return View(model);
        }
    }
}
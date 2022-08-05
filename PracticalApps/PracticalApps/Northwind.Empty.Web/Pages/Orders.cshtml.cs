using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Northwind.Empty.Web.Pages
{
    public class OrdersModel : PageModel
    {
        private NorthwindContext context;
        public OrdersModel(NorthwindContext context)
        {
            this.context = context;
        }
        public int OrdersCount { get; set; }
        public void OnGet()
        {
            var title = "Orders";
            ViewData["Title"] = $"Northwind B2B - {title}";

            OrdersCount = context.Orders.Count();
        }
    }
}

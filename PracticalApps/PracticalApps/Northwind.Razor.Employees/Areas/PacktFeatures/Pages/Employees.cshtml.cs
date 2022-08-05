using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Packt.Shared;

namespace Northwind.Razor.Employees.MyFeature.Pages
{
    public class EmployeesModel : PageModel
    {
        private NorthwindContext db;
        public EmployeesModel(NorthwindContext db)
        {
            this.db = db;
        }

        public Employee[] Employees { get; set; }
        public void OnGet()
        {
            ViewData["Title"] = "Northwind B2B - Employees";
            Employees = db.Employees.OrderBy(p => p.LastName).ThenBy(e => e.FirstName).ToArray();
        }
    }
}
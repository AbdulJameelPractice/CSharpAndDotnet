using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace Northwind.Empty.Web.Pages
{
    public class SuppliersModel : PageModel
    {
        private NorthwindContext context;
        public SuppliersModel(NorthwindContext context)
        {
            this.context = context;
        }
        public IEnumerable<Supplier> Suppliers { get; set; }

        public void OnGet()
        {
            Suppliers = Suppliers = context.Suppliers
                .OrderBy(c => c.Country).ThenBy(c => c.CompanyName);
            ViewData["Title"] = "Northwind B2B - Suppliers";
        }

        [BindProperty]
        public Supplier? Supplier { get; set; }

        public IActionResult OnPost()
        {
            if ((Supplier is not null) && ModelState.IsValid)
            {
                context.Suppliers.Add(Supplier);
                context.SaveChanges();
                return RedirectToPage("/suppliers");
            }
            else
            {
                return Page();

            }
        }
    }
}

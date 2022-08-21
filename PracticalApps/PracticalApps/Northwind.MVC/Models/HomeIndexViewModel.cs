namespace Northwind.MVC.Models;
using Packt.Shared;

public record HomeIndexViewModel(int VisitorCount, IList<Category> Categories, IList<Product> Products);


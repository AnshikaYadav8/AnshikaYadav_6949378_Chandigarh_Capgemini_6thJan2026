using Microsoft.AspNetCore.Mvc;
using OnlineProductCatelog.Models;
using System.Linq;

namespace OnlineProductCatelog.Controllers
{
    public class ProductController : Controller
    {
        private static List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Description = "High performance laptop", Price = 800, ImageUrl = "/images/laptop.jpg" },
            new Product { Id = 2, Name = "Phone", Description = "Latest smartphone", Price = 500, ImageUrl = "/images/phone.jpg" }
        };

        // GET: /Product/
        public IActionResult Index(string search)
        {
            var filtered = string.IsNullOrEmpty(search)
                ? products
                : products.Where(p => p.Name.ToLower().Contains(search.ToLower())).ToList();

            return View(filtered);
        }

        // GET: /Product/Details/1
        public IActionResult Details(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product == null)
                return NotFound();

            return View(product);
        }
    }
}
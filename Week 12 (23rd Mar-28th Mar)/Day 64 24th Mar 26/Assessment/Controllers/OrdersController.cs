//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Rendering;
//using Microsoft.EntityFrameworkCore;
//using Assessment.Data;
//using Assessment.Models;

//public class OrdersController : Controller
//{
//    private readonly ApplicationDbContext _context;

//    public OrdersController(ApplicationDbContext context)
//    {
//        _context = context;
//    }

//    // GET: Orders
//    public IActionResult Index()
//    {
//        var orders = _context.Orders
//            .Include(o => o.Customer)
//            .Include(o => o.ShippingDetail)
//            .ToList();

//        return View(orders);
//    }

//    // GET: Orders/Create
//    public IActionResult Create()
//    {
//        ViewBag.CustomerId = new SelectList(_context.Customers, "CustomerId", "Name");
//        ViewBag.Products = _context.Products.ToList();

//        return View();
//    }

//    // POST: Orders/Create
//    [HttpPost]
//    [ValidateAntiForgeryToken]
//    public IActionResult Create(Order order, List<int> productIds, List<int> quantities)
//    {
//        // 🔥 FIX ALL NAVIGATION VALIDATION
//        ModelState.Remove("OrderItems");
//        ModelState.Remove("Customer");
//        ModelState.Remove("ShippingDetail");

//        if (ModelState.IsValid)
//        {
//            _context.Orders.Add(order);
//            _context.SaveChanges();

//            // Save OrderItems
//            for (int i = 0; i < productIds.Count; i++)
//            {
//                var item = new OrderItem
//                {
//                    OrderId = order.OrderId,
//                    ProductId = productIds[i],
//                    Quantity = quantities[i]
//                };

//                _context.OrderItems.Add(item);
//            }

//            _context.SaveChanges();
//            return RedirectToAction(nameof(Index));
//        }

//        // 🔥 VERY IMPORTANT (if validation fails)
//        ViewBag.CustomerId = new SelectList(_context.Customers, "CustomerId", "Name", order.CustomerId);
//        ViewBag.Products = _context.Products.ToList();

//        return View(order);
//    }
//}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Assessment.Data;
using Assessment.Models;

public class OrdersController : Controller
{
    private readonly ApplicationDbContext _context;

    public OrdersController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: Orders
    public IActionResult Index()
    {
        var orders = _context.Orders
            .Include(o => o.Customer)
            .Include(o => o.ShippingDetail)
            .ToList();

        return View(orders);
    }

    // GET: Orders/Create
    public IActionResult Create()
    {
        ViewBag.CustomerId = new SelectList(_context.Customers, "CustomerId", "Name");
        ViewBag.Products = _context.Products.ToList();
        return View();
    }

    // POST: Orders/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Order order, List<int> productIds, List<int> quantities)
    {
        // 🔥 REMOVE ALL NAVIGATION VALIDATION (FULL FIX)
        ModelState.Remove("OrderItems");
        ModelState.Remove("Customer");
        ModelState.Remove("ShippingDetail");
        ModelState.Remove("ShippingDetail.Order");   // ⭐ THIS FIXES YOUR ERROR

        if (ModelState.IsValid)
        {
            // Save Order
            _context.Orders.Add(order);
            _context.SaveChanges();

            // Save OrderItems
            if (productIds != null && quantities != null)
            {
                for (int i = 0; i < productIds.Count; i++)
                {
                    var item = new OrderItem
                    {
                        OrderId = order.OrderId,
                        ProductId = productIds[i],
                        Quantity = quantities[i]
                    };

                    _context.OrderItems.Add(item);
                }
            }

            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        // Reload dropdowns if validation fails
        ViewBag.CustomerId = new SelectList(_context.Customers, "CustomerId", "Name", order.CustomerId);
        ViewBag.Products = _context.Products.ToList();

        return View(order);
    }
}
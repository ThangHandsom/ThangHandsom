
using Microsoft.AspNetCore.Mvc;

using DoanLTWeb.Models;

namespace DoanLTWeb.Controllers
{
    public class ProductsController : Controller
    {
        private readonly DataContext _context;

        public ProductsController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewBag.productCategories = _context.ProductCategories.ToList();
            return View();
        }
    }
}

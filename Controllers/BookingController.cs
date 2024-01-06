using DoanLTWeb.Models;
using Microsoft.AspNetCore.Mvc;


namespace DoanLTWeb.Controllers
{
    public class BookingController : Controller
    {
        private readonly DataContext _context;
        public BookingController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}

using DoanLTWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace DoanLTWeb.Controllers
{
    public class AboutController : Controller
    {
        private readonly DataContext _context;
        public AboutController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}

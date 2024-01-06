using DoanLTWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DoanLTWeb.Controllers
{
    public class ServicesController : Controller
    {
        private readonly DataContext _context;
        public ServicesController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }



        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

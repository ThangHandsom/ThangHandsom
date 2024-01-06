using Microsoft.AspNetCore.Mvc;

namespace DoanLTWeb.Controllers
{
    public class EventsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

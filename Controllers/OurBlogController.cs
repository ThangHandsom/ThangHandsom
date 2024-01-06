using Microsoft.AspNetCore.Mvc;

namespace DoanLTWeb.Controllers
{
    public class OurBlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

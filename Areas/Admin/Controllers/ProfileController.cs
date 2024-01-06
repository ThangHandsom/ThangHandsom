using DoanLTWeb.Areas.Admin.Models;
using DoanLTWeb.Models;
using DoanLTWeb.Utilities;
using Microsoft.AspNetCore.Mvc;


namespace DoanLTWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProfileController : Controller
    {
        public IActionResult Index()//đăng nhập
        {
            if (!Functions.IsLogin())
                return RedirectToAction("Index", "Login");
            return View();
        }
    }
}

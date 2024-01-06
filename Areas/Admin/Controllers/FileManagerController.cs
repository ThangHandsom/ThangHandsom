using Microsoft.AspNetCore.Mvc;
using DoanLTWeb.Utilities;

namespace DoanLTWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("/Admin/file-manager")]
    public class FileManagerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using DoanLTWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace DoanLTWeb.Controllers
{
    public class ContactController : Controller
    {
        private readonly DataContext _context;
        public ContactController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(Contact model)
        {
            if (ModelState.IsValid)
            {
                // Lưu dữ liệu vào cơ sở dữ liệu
                _context.Contacts.Add(new Contact
                {
                    Name = model.Name,
                    Phone = model.Phone,
                    Email = model.Email,
                    Message = model.Message
                });
                _context.SaveChanges();

                // Sử dụng TempData để truyền thông điệp đến action "ThankYou"
                TempData["ThankYouMessage"] = "Cảm ơn bạn đã gửi tin nhắn! Chúng tôi sẽ sớm phản hồi cho bạn.";

                // Chuyển hướng người dùng sau khi gửi liên hệ
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
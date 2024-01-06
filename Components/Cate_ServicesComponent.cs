using Microsoft.AspNetCore.Mvc;
using DoanLTWeb.Models;

namespace DoanLTWeb.Components
{
    [ViewComponent(Name = "Cate_Services")]
    public class Cate_ServicesComponent : ViewComponent
    {
        private readonly DataContext _context;
        public Cate_ServicesComponent(DataContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listofCateSer = (from c in _context.CateServicess
                              where (c.IsActive == true) && (c.Status == 1)
                              orderby c.CateServiceID descending
                              select c).Take(8).ToList();
            return await Task.FromResult((IViewComponentResult)View("Default", listofCateSer));
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using DoanLTWeb.Models;

namespace DoanLTWeb.ViewComponents
{
    [ViewComponent(Name = "Product")]

    public class ProductViewComponent : ViewComponent
    {
        private readonly DataContext _context;

        public ProductViewComponent(DataContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(int type)
        {
            var items = _context.Products.Include(m => m.CateProduct).Where(m => (bool)m.IsActive);
            if (type > 0)
            {
                items = items.Where(i => i.CateProductID == type);
            }
            return await Task.FromResult<IViewComponentResult>(View(items.OrderByDescending(m => m.ProductID).ToList()));
        }
    }
}
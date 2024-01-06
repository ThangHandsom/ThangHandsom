using DoanLTWeb.Areas.Admin.Models;
using Microsoft.EntityFrameworkCore;

namespace DoanLTWeb.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Post> Posts { get; set; }  
        public DbSet<AdminMenu> AdminMenus { get; set; }
        public DbSet<AdminUser> AdminUsers { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Product> Products { get; set; }    
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Booking> Bookings { get; set; } 
        public DbSet<Cate_Services> CateServicess { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DoanLTWeb.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public string? Name { get; set; }
        public int? CateProductID { get; set; }
        public string? Detail { get; set; }
        public string? Image { get; set; }
        public int? Price { get; set; }
        public bool IsActive { get; set; }
        public virtual ProductCategory? CateProduct { get; set; }

    }
}

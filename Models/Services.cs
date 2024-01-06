using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoanLTWeb.Models
{
    [Table("Services")]
    public class Services
    {
        [Key]
        public int ServicesID { get; set; }
        public string? CategoryServices { get; set; }
        public string? ServicesName { get; set; }
        public string? Description { get; set; }
        public string? Link { get; set; }
        public string? Icon { get; set; }
        public bool ? IsActive { get; set; }
    }
}

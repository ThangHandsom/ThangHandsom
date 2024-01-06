using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoanLTWeb.Models
{
    [Table("About")]
    public class About
    {
        [Key]
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Detail { get; set; }
        public string? Images { get; set; }
        public int? Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
    }
}

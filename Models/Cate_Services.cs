using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoanLTWeb.Models
{
    [Table("Cate_Services")]
    public class Cate_Services
    {
        [Key]
        public int CateServiceID { get; set; }
        public string CateName { get; set; }
        public string Contents { get; set; }
        public string Link { get; set; }
        public string Author { get; set; }
        public bool IsActive { get; set; }
        public int Status { get; set; }
    }
}

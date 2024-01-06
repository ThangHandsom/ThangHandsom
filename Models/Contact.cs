using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoanLTWeb.Models
{
    [Table("Contact")]
    public class Contact
    {
        [Key]
        public int ContactID { get; set; }
        public string? Name { get; set; }    
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Message { get; set; }

    }
}

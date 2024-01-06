using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoanLTWeb.Models
{
    [Table("Booking")]
    public class Booking
    {
        [Key] 
        public int BookingID { get; set; }
        public string? CustomerName { get; set; }
        public int? Phone { get; set; }
        public string? Email { get; set; }
        public int? CategotyProductID { get; set; }
        public string? ProductName { get; set; }
        public int? Quantity { get; set; }
        public DateTime? BookingDate { get; set; }
    }
}

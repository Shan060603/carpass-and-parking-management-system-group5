using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Carpass_Profilling.Models
{
    [Table("syear")] // Matches your table name in the database
    public class Schoolyear
    {
        [Key]
        public int Sy_ID { get; set; }

        [Column("Year")]
        [Required]
        public string Year { get; set; } = string.Empty;
    }
}

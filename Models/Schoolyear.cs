using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Carpass_Profilling.Models
{
    [Table("syear")] // Must match your actual MySQL table name
    public class Schoolyear
    {
        [Key]
        public int Sy_ID { get; set; }

        [Column("Year")]
        public string Year { get; set; }
    }
}

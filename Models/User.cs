using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Carpass_Profilling.Models
{
    [Table("User")]  // Matches the database table name
    public partial class User
    {
        [Key] // ✅ Primary Key
        [EmailAddress] // ✅ Optional: for clarity
        public string Email { get; set; } = null!;

        public string Name { get; set; } = null!;
        public string Gender { get; set; } = null!;
        public string Birthday { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Role { get; set; } = null!;
        public byte[]? Image { get; set; }
    }
}

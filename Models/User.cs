namespace Carpass_Profilling.Models
{
    public partial class User
    {
        public string Name { get; set; } = null!;
        public string Gender { get; set; } = null!;
        public string Birthday { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Role { get; set; } = null!;
        public byte[]? Image { get; set; } // New property to store the image
    }
}
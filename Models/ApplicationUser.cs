using System.ComponentModel.DataAnnotations;

namespace PhuongNVT.Models
{
    public class ApplicationUser
    {
        [Key]
        public int Id { get; set; }

        [Required, EmailAddress]
        public required string Email { get; set; }

        [Required]
        public required string Password { get; set; }

        [Required]
        public required string Role { get; set; } // "Admin" hoặc "User"
    }
}
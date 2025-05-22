using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlacementSystem.Models
{
    public class Users
    {
        [Key]
        public int Id { get; set; }
        public required string Email { get; set; } = string.Empty;
        public bool? IsEmailVerified { get; set; } = false;

        public string? Password { get; set; } = string.Empty;

        [NotMapped] // So EF doesn't map this to the database
        [DataType(DataType.Password)]
        public string? ConfirmPassword { get; set; }
        public string? Role { get; set; } = "Guest"; // Guest, Student, TPOHead, TPOCoordinator, Company, Admin
        public int? ProfileId { get; set; }

        public DateTime? Updated_at { get; set; } = DateTime.Now;
        public DateTime Created_at { get; set; } = DateTime.Now;
    }
}

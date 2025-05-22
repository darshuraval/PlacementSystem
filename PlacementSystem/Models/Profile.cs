using System.ComponentModel.DataAnnotations;

namespace PlacementSystem.Models
{
    public class Profile
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; } = string.Empty;

        public DateTime? Updated_at { get; set; } = DateTime.Now;
        public DateTime Created_at { get; set; } = DateTime.Now;

    }
}

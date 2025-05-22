using System.ComponentModel.DataAnnotations;

namespace PlacementSystem.Models
{
    public class SelectionProcess
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string ProcessName { get; set; } // e.g., "Technical Round", "HR Round"

        public DateTime? Updated_at { get; set; } = DateTime.Now;
        public DateTime Created_at { get; set; } = DateTime.Now;

    }
}

using System.ComponentModel.DataAnnotations;

namespace PlacementSystem.Models
{
    public class SelectionProcess
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? ProcessName { get; set; }
        public ICollection<CampusDriveNotification> CampusDriveNotifications { get; set; } = new List<CampusDriveNotification>();

    }
}

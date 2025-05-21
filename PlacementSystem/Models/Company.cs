using System.ComponentModel.DataAnnotations;

namespace PlacementSystem.Models
{
    public class Company
    {
        [Key]
        public int Id { get; set; }
        public required string CompanyName { get; set; }
        public string? CompanyURL { get; set; }
        public string? CompanyProfile { get; set; }
        public string? CompanyHRName { get; set; }
        public string? CompanyHRContact { get; set; }
        public string? CompanyHREmail { get; set; }
    }
}

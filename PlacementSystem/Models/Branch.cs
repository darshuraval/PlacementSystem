using System;
using System.ComponentModel.DataAnnotations;

namespace PlacementSystem.Models
{
    public class Branch
    {
        [Key]
        public int Id { get; set; }
        public string? BranchName { get; set; } = string.Empty;
        public string? Specialization { get; set; } = string.Empty;
        public DateTime? Updated_at { get; set; } = DateTime.Now;
        public DateTime Created_at { get; set; } = DateTime.Now;
    }
}

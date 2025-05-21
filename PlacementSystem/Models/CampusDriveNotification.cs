using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlacementSystem.Models
{
    public class CampusDriveNotification
    {
        [Key]
        public int Id { get; set; }

        // Foreign Key Reference to Company Model
        public required int CompanyId { get; set; }

        [ForeignKey("CompanyId")]
        public virtual Company Company { get; set; }

        public string? ReferenceNumber { get; set; }

        public string? CompanyName { get; set; }

        public string? JobLocation { get; set; }

        public string? CompanyURL { get; set; }
        public ICollection<SelectionProcess> SelectionProcesses { get; set; } = new List<SelectionProcess>();


        public List<string>? SelectionProcess { get; set; }

        public decimal? CTC { get; set; }

        public decimal? Stipend { get; set; }

        public string? TraineeType { get; set; }

        public bool? IsBond { get; set; }

        public string? BondDetails { get; set; }

        public string? JobProfile { get; set; }

        public string? DateOfJoining { get; set; }

        public string? Batch { get; set; } = "2025";

        public string? EligibleCourses { get; set; }

        public DateTime? RegistrationDeadline { get; set; }

        public string? DeptCoordinatorNames { get; set; }

        public string? DeptCoordinatorEmails { get; set; }

        public string? TPOCoordinatorNames { get; set; } = "Prof. Bhargav Pandya,Mr. Osho Shah";

        public string? TPOCoordinatorEmails { get; set; } = "bhargav.pandya@rku.ac.in,osho.shah@rku.ac.in,";
        
        public string? Venue { get; set; } = "Will be Declared Soon";

        public string? DateAndTime { get; set; } = "Will be Declared Soon";

        public string? Note { get; set; }

        public string? RegistrationLink { get; set; }

        public string? CompanyProfile { get; set; }

        public string? OtherInformation { get; set; }

        public string? AttachmentURL { get; set; }
    }
}

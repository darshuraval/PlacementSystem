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
        public int? CompanyId { get; set; }

        public string? ReferenceNumber { get; set; }

        public string? CompanyName { get; set; }

        public string? JobLocation { get; set; }

        public string? CompanyURL { get; set; }

        public string? SelectionProcess { get; set; } // e.g., "Online Test, Technical Interview, HR Interview"

        public decimal? CTC { get; set; }

        public decimal? Stipend { get; set; }

        public string? TraineeType { get; set; } // e.g., "Internship", "Full-Time"

        public bool? IsBond { get; set; }

        public string? BondDetails { get; set; }

        public string? JobProfile { get; set; }

        public string? DateOfJoining { get; set; }

        public string? Batch { get; set; } = "2025"; // Default batch

        public string? EligibleCourses { get; set; } // e.g., "B.Tech, M.Tech, MBA"

        public DateTime? RegistrationDeadline { get; set; } = DateTime.Now.AddDays(3); // Default to 3 days from now

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
        public DateTime? Updated_at { get; set; } = DateTime.Now;
        public DateTime Created_at { get; set; } = DateTime.Now;
    }
}

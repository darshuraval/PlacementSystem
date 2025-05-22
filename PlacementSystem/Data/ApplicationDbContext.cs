using Microsoft.EntityFrameworkCore;
using PlacementSystem.Models;

namespace PlacementSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }
        public DbSet<CampusDriveNotification> CampusDriveNotification { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<SelectionProcess> SelectionProcess { get; set; }
        public DbSet<Branch> Branches { get; set; }

        public DbSet<PlacementSystem.Models.Branch> Branch { get; set; } = default!;
        public DbSet<PlacementSystem.Models.Users> Users { get; set; } = default!;

    }
}

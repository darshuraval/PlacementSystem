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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SelectionProcess>()
                .HasIndex(sp => sp.ProcessName)
                .IsUnique();

            modelBuilder.Entity<CampusDriveNotification>()
                .HasMany(c => c.SelectionProcesses)
                .WithMany(s => s.CampusDriveNotifications);


            base.OnModelCreating(modelBuilder);
        }
        public DbSet<PlacementSystem.Models.Branch> Branch { get; set; } = default!;

    }
}

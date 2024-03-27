using Microsoft.EntityFrameworkCore;

namespace WorkspaceGlimpse.Models
{
    public class GlimpseContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-H6HOM7Q\SQLEXPRESS;Database=GlimpseDb;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasIndex(a => a.UserId)
                .IsUnique();
        }
    }
}
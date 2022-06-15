using EDU_Journal.Server.Entities;
using Microsoft.EntityFrameworkCore;

namespace EDU_Journal.Server.Data
{
    public class JournalDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public JournalDbContext(DbContextOptions<JournalDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity => 
            {
                entity.ToTable("Users");
                entity.Property(e => e.Email);
            });
        }
    }
}

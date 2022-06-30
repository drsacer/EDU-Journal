using EDU_Journal.Server.Entities;
using Microsoft.EntityFrameworkCore;

namespace EDU_Journal.Server.Data
{
    public class JournalDbContext : DbContext
    {
        public DbSet<User> Users { get; set; } //table
        public DbSet<WorkingDay> WorkingDays { get; set; } //table

        public JournalDbContext(DbContextOptions<JournalDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)//prilikom kreiranja baze podataka - što se sve kreira u njoj (relacije USER- WORKINg DAy)
        {
            modelBuilder.Entity<User>(entity =>
            {
            entity.ToTable("Users");
            entity.Property(e => e.Email); //lambda funkcije - metode koje 
            entity.Property(p => p.Password);
            });
        }
    }
}

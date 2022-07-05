using EDU_Journal.Server.Entities;
using Microsoft.EntityFrameworkCore;

namespace EDU_Journal.Server.Data
{
    public class JournalDbContext : DbContext
    {
        public DbSet<User> Users { get; set; } //table
        public DbSet<WorkingDay> WorkingDays { get; set; } //table
        public DbSet<NonWorkingDay> NonWorkingDays { get; set; } //table
        public DbSet<PublicHolidays> PublicHolidays { get; set; } //table
        public DbSet<Vacation> Vacation { get; set; } //table
        public DbSet<SickLeave> SickLeave{ get; set; } //table


        public JournalDbContext(DbContextOptions<JournalDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)//prilikom kreiranja baze podataka - što se sve kreira u njoj (relacije USER- WORKINg DAy)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("Users");
                entity.Property(e => e.Email); //lambda funkcije
                entity.HasIndex(i => i.Email).IsUnique();
            });

            modelBuilder.Entity<WorkingDay>(entity =>
            {
                entity.HasIndex(i => new {i.UserId, i.Date}); // stvaranje Unique Keya
            });
        }
    }
}

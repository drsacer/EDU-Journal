using EDU_Journal.Server.Entities;
using Microsoft.EntityFrameworkCore;

namespace EDU_Journal.Server.Data
{
    public class JournalDbContext : DbContext
    {
        public DbSet<User> Users { get; set; } //table
        public DbSet<WorkingDay> WorkingDays { get; set; } //table
        public DbSet<NonWorkingDay> NonWorkingDays { get; set; } //table
        public DbSet<PublicHoliday> PublicHolidays { get; set; } //table
        public DbSet<Vacation> Vacations { get; set; } //table
        public DbSet<SickLeave> SickLeaves { get; set; } //table

        public JournalDbContext(DbContextOptions<JournalDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)//prilikom kreiranja baze podataka - što se sve kreira u njoj (relacije USER- WORKINg DAy)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(i => i.Email).IsUnique();
            });

            modelBuilder.Entity<WorkingDay>(entity =>
            {
                entity.HasIndex(i => new {i.UserId, i.Date}).IsUnique(); //  Unique Key
            });

            modelBuilder.Entity<PublicHoliday>(entity =>
            {
                entity.HasIndex(i => i.Date).IsUnique();
            });

            modelBuilder.Entity<SickLeave>(entity =>
            {
                entity.HasIndex(i => i.Name).IsUnique();
            });
        }
    }
}

using EDU_Journal.Server.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

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

           modelBuilder.Entity<Vacation>().Property(s => s.StartDate)
                .HasConversion<DateOnlyConverter, DateOnlyComparer>();

            modelBuilder.Entity<Vacation>().Property(e => e.EndDate)
                .HasConversion<DateOnlyConverter, DateOnlyComparer>();

            modelBuilder.Entity<NonWorkingDay>().Property(s => s.StartDate)
                .HasConversion<DateOnlyConverter, DateOnlyComparer>();

            modelBuilder.Entity<NonWorkingDay>().Property(e => e.EndDate)
                .HasConversion<DateOnlyConverter, DateOnlyComparer>();
        }

        public class DateOnlyConverter : ValueConverter<DateOnly, DateTime>
        {
   
            public DateOnlyConverter() : base(
                    d => d.ToDateTime(TimeOnly.MinValue),
                    d => DateOnly.FromDateTime(d))
            { }
        }

        public class DateOnlyComparer : ValueComparer<DateOnly>
        {
            public DateOnlyComparer() : base(
                (d1, d2) => d1.DayNumber == d2.DayNumber,
                d => d.GetHashCode())
            {
            }
        }

        public class TimeOnlyConverter : ValueConverter<TimeOnly, TimeSpan>
        {
            public TimeOnlyConverter() : base(
                    timeOnly => timeOnly.ToTimeSpan(),
                    timeSpan => TimeOnly.FromTimeSpan(timeSpan))
            {
            }
        }

        public class TimeOnlyComparer : ValueComparer<TimeOnly>
        {
            public TimeOnlyComparer() : base(
                (t1, t2) => t1.Ticks == t2.Ticks,
                t => t.GetHashCode())
            {
            }
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder builder)
        {
            builder.Properties<DateOnly>()
                   .HaveConversion<DateOnlyConverter>();
            // .HaveColumnType("date");

            builder.Properties<TimeOnly>()
                  .HaveConversion<TimeOnlyConverter>();
                 // .HaveColumnType("date");
        }
    }
}

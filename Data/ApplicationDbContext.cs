using appointmnet_schdeular.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace appointmnet_schdeular.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // DbSet properties for your models
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Classroom> Classrooms { get; set; }
        // Add other DbSets as needed

    //    protected override void OnModelCreating(ModelBuilder modelBuilder)
     //   {
         //   base.OnModelCreating(modelBuilder);

            // Your existing model configurations

            // Example:
            // modelBuilder.Entity<Schedule>()
            //    .HasOne(s => s.Course)
            //    .WithMany(c => c.Schedules);

            // modelBuilder.Entity<Schedule>()
            //    .HasOne(s => s.Instructor)
            //    .WithMany(i => i.Schedules);

            // Define other relationships
            // For example, if you have a many-to-many relationship, configure it here
        //}
    }
}

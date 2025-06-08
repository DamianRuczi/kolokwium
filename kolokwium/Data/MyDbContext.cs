using kolokwium.Models;
using Microsoft.EntityFrameworkCore;

namespace prescription_add_ep.Data;

public class MyDbContext : DbContext
{
    
    public DbSet<Studentt> Students { get; set; } = null!;
    public DbSet<Course> Courses { get; set; } = null!;
    
    public DbSet<Enrollment> Enrollments { get; set; } = null!;
    
    public MyDbContext(DbContextOptions options) : base(options)
    {
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        var students = new List<Studentt>()
        {
            new ()
            {
                StudentId = 1,
                FirstName = "User1",
                LastName = "UUU",
                Email = "email@emial.com"
            },
            new ()
            {
                StudentId = 2,
                FirstName = "User2",
                LastName = "UUU",
                Email = "email2@emial.com"
            }
        };

        var courses = new List<Course>
        {
            new()
            {
               CourseId = 1,
               Title = "Course1",
                Credits = "3",
                Teacher = "Teacher1"
                
            },
            new()
            {
                CourseId = 2,
                Title = "Course2",
                Credits = "33",
                Teacher = "Teacher2"
                
            },
        };
        
        modelBuilder.Entity<Studentt>().HasData(students);
        modelBuilder.Entity<Course>().HasData(courses);

    }
}
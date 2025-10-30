using Microsoft.EntityFrameworkCore;
using StudentCourseManager.Core.models;

namespace StudentCourseManager.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Enrollment> Enrollments { get; set; }
    }
}
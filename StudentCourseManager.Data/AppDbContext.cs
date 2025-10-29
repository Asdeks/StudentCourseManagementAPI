using Microsoft.EntityFrameworkCore;
using StudentCourseManager.Core.Models;

namespace StudentCourseManager.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
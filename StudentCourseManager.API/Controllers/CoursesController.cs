using Microsoft.AspNetCore.Mvc;
using StudentCourseManager.Core.Models;
using StudentCourseManager.Data;

namespace StudentCourseManager.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CoursesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CoursesController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetCourses()
        {
            var courses = _context.Courses.ToList();
            return Ok(courses);
        }

        [HttpPost]
        public IActionResult AddStudent(Course course)
        {
            _context.Courses.Add(course);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetCourses), new { id = course.Id }, course);
        }
    }
}

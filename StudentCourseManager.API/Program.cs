using Microsoft.EntityFrameworkCore;
using StudentCourseManager.Data;

var builder = WebApplication.CreateBuilder(args);

// Configure database connection (SQLite for local development)
builder.Services.AddDbContext<AppDbContext>(
    options => options.UseSqlite("Data Source=students.db"));

// Register controllers and Swagger for API documentation
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Enable Swagger UI in development mode
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();

// Map all controller routes (e.g., StudentsController)
app.MapControllers();

// Start the application
app.Run();

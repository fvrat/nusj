using Microsoft.EntityFrameworkCore;
using CraftCourses.Models;

namespace CraftCourses.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Course> Courses { get; set; }
    }
}

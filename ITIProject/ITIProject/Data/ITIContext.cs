using ITIProject.Models;
using Microsoft.EntityFrameworkCore;

namespace ITIProject.Data
{
    public class ITIContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=ITIDB;Integrated Security=True;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }

        public ITIContext()
        {
            
        }
        public ITIContext(DbContextOptions options):base(options)
        {
            
        }
    }
}

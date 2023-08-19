using Microsoft.EntityFrameworkCore;
using StudentCruds.Models;

namespace StudentCruds.Data
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        {
        }
        public DbSet<Student> Students => Set<Student>();
    }

}

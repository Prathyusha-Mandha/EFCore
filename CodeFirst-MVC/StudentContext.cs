using Microsoft.EntityFrameworkCore;

namespace CodeFirst_Practice.Models
{
    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=Prathyusha;database=CodeFirst;integrated security=True;trustservercertificate=True;");
        }
    }
}

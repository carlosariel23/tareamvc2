using Microsoft.EntityFrameworkCore;
namespace codefirts.Models
{


    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Alumno> Alumnos { get; set; }
    }

}

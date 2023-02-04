using Microsoft.EntityFrameworkCore;
using Sistema_Ventas.Models;

namespace Sistema_Ventas.DataAcces
{
    public class UniversityContext : DbContext
    {
        public UniversityContext(DbContextOptions<UniversityContext>options):base (options) 
        {

        }
        //agregar las tablas
        public DbSet<Users>? Users { get; set; }

        public DbSet<Curso> Curso { get; set; }
    }
}



using Microsoft.EntityFrameworkCore;
using shed_project_domain_file;

namespace shed_project_persistence 
{
    public class AppContext : DbContext
    {
        public DbSet<Persona> Personas {get;set;}
        
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                .UseSqlServer("Data source = (localdb)\\MSSQLLocalDB; Initial catalog =shed_project");
            }
        } 
    }
}
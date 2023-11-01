using Microsoft.EntityFrameworkCore;
using GridviewCrudOps.Models;

namespace GridviewCrudOps
{
    public class YourDbContext : DbContext
    {
        public DbSet<Company3> Company3 { get; set; }

        public DbSet<Company> Company { get; set; }

        public DbSet<Company> Company2 { get; set; }
        
        public DbSet<Branch2> Branches { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=CompanyDatabase;Trusted_Connection=True;TrustServerCertificate=true;");
            }
        }

    }
}

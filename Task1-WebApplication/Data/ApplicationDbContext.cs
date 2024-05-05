using Microsoft.EntityFrameworkCore;
using Task1_WebApplication.Models;

namespace Task1_WebApplication.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet <Employee> Employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-MAMLEUS\\SQLEXPRESS; database=Employee; trusted_connection=true; TrustServerCertificate=True ;");
        }
    }
}

using Microsoft.EntityFrameworkCore;

namespace MasterClassManager.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<MasterClass> MasterClasses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=MasterClassDatabase;Trusted_Connection=True;");
        }
        public void Initialize()
        {
            Database.EnsureCreated();
        }
    }
}
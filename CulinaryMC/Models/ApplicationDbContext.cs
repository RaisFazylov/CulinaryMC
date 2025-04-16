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

        /// <summary>
        /// Обеспечивает создание базы данных, если она не существует.
        /// </summary>
        public void Initialize()
        {
            Database.EnsureCreated();
        }
    }
}
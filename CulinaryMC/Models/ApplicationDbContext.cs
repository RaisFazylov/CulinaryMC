using Microsoft.EntityFrameworkCore;

namespace MasterClassManager.Models
{
    /// <summary>
    /// Контекст базы данных для работы с мастер-классами
    /// </summary>
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
using Microsoft.EntityFrameworkCore;

namespace MasterClassManager.Models
{
    /// <summary>
    /// Предоставляет контекст базы данных для работы с мастер-классами
    /// </summary>
    public class ApplicationDbContext : DbContext
    {
        /// <summary>
        /// Таблица MasterClasses в базе данных
        /// </summary>
        public DbSet<MasterClass> MasterClasses { get; set; }

        /// <summary>
        /// Настраивает подключение к SQL Server LocalDB
        /// </summary>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=MasterClassDatabase;Trusted_Connection=True;");
        }

        /// <summary>
        /// Обеспечивает создание базы данных, если она не существует
        /// </summary>
        public void Initialize()
        {
            Database.EnsureCreated();
        }
    }
}
using Microsoft.EntityFrameworkCore;

namespace MasterClassManager.Models
{
    /// <summary>
    /// Контекст базы данных для работы с мастер-классами
    /// </summary>
    public class ApplicationDbContext : DbContext
    {
        /// <summary>
        /// Коллекция мастер-классов в базе данных
        /// </summary>
        public DbSet<MasterClass> MasterClasses { get; set; }

        /// <summary>
        /// Настройка подключения к базе данных
        /// </summary>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Используем LocalDB в качестве сервера базы данных
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=MasterClassDatabase;Trusted_Connection=True;");
        }

        /// <summary>
        /// Инициализация базы данных (создание при первом запуске)
        /// </summary>
        public void Initialize()
        {
            // Создаем базу данных, если она не существует
            Database.EnsureCreated();
        }
    }
}
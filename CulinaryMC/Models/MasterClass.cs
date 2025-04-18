namespace MasterClassManager.Models
{
    /// <summary>
    /// Модель мастер-класса с основными свойствами
    /// </summary>
    public class MasterClass
    {
        /// <summary>
        /// Уникальный идентификатор мастер-класса
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Название мастер-класса
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Подробное описание мастер-класса
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Категория мастер-класса (выпечка, десерты и т.д.)
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// Дата и время проведения мастер-класса
        /// </summary>
        public DateTime Date { get; set; }
    }
}
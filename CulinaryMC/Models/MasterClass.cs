namespace MasterClassManager.Models
{
    /// <summary>
    /// Модель мастер-класса с основными свойствами
    /// </summary>
    public class MasterClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; }
    }
}
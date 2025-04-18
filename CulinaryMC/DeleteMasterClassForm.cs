using MasterClassManager.Models;

namespace CulinaryMC
{
    /// <summary>
    /// Форма для удаления мастер-классов
    /// </summary>
    public partial class DeleteMasterClassForm : Form
    {
        private ApplicationDbContext _dbContext;

        /// <summary>
        /// Конструктор формы удаления
        /// </summary>
        public DeleteMasterClassForm()
        {
            InitializeComponent();
            _dbContext = new ApplicationDbContext();
            LoadRecentMasterClasses();
        }

        /// <summary>
        /// Загрузка недавно добавленных мастер-классов
        /// </summary>
        private void LoadRecentMasterClasses()
        {
            // Показываем мастер-классы, добавленные за последние 7 дней
            var recentDate = DateTime.Now.AddDays(-7);
            var recentClasses = _dbContext.MasterClasses
                .Where(mc => mc.Date >= recentDate)
                .OrderByDescending(mc => mc.Date)
                .ToList();

            // Привязываем данные к DataGridView
            dgvMasterClasses.DataSource = recentClasses;
            dgvMasterClasses.Columns["Id"].Visible = false; // Скрываем колонку с ID
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Удалить"
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Проверяем, что пользователь выбрал мастер-класс для удаления
            if (dgvMasterClasses.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите мастер-класс для удаления");
                return;
            }

            // Получаем выбранный мастер-класс
            var selectedMasterClass = (MasterClass)dgvMasterClasses.SelectedRows[0].DataBoundItem;

            try
            {
                // Удаляем мастер-класс из базы данных
                _dbContext.MasterClasses.Remove(selectedMasterClass);
                _dbContext.SaveChanges();
                MessageBox.Show("Мастер-класс успешно удалён!");
                LoadRecentMasterClasses(); // Обновляем список
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении: {ex.Message}");
            }
        }

        /// <summary>
        /// Обработчик закрытия формы
        /// </summary>
        private void DeleteMasterClassForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Освобождаем ресурсы контекста базы данных
            _dbContext?.Dispose();
        }
    }
}
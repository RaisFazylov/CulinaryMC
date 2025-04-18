using MasterClassManager.Models;

namespace CulinaryMC
{
    /// <summary>
    /// Главная форма приложения "Кулинарные мастер-классы"
    /// </summary>
    public partial class Home : Form
    {
        /// <summary>
        /// Конструктор главной формы
        /// </summary>
        public Home()
        {
            InitializeComponent();
            InitializeDatabase();
        }

        /// <summary>
        /// Инициализация базы данных при запуске приложения
        /// </summary>
        private void InitializeDatabase()
        {
            // Создаем контекст базы данных и инициализируем его
            using (var db = new ApplicationDbContext())
            {
                db.Initialize();
            }
        }

        // Обработчик нажатия кнопки "Добавить"
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Открываем форму добавления мастер-класса
            var addForm = new AddMasterClassForm();
            addForm.ShowDialog();
        }

        // Обработчик нажатия кнопки "Удалить"
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Открываем форму удаления мастер-класса
            var deleteForm = new DeleteMasterClassForm();
            deleteForm.ShowDialog();
        }

        // Обработчик нажатия кнопки "Просмотреть"
        private void btnView_Click(object sender, EventArgs e)
        {
            // Открываем форму просмотра и редактирования мастер-классов
            var viewForm = new ViewMasterClassesForm();
            viewForm.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
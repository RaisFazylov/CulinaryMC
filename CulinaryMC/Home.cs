using MasterClassManager.Models;

namespace CulinaryMC
{
    /// <summary>
    /// Главная форма приложения для управления кулинарными мастер-классами
    /// </summary>
    public partial class Home : Form
    {
        /// <summary>
        /// Инициализирует главную форму и проверяет подключение к БД
        /// </summary>
        public Home()
        {
            InitializeComponent();
            InitializeDatabase();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        /// <summary>
        /// Проверяет и создает базу данных при необходимости
        /// </summary>
        private void InitializeDatabase()
        {
            using (var db = new ApplicationDbContext())
            {
                db.Initialize();
            }
        }

        /// <summary>
        /// Открывает форму добавления нового мастер-класса
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addForm = new AddMasterClassForm();
            addForm.ShowDialog();
        }

        /// <summary>
        /// Открывает форму просмотра и редактирования мастер-классов
        /// </summary>
        private void btnView_Click(object sender, EventArgs e)
        {
            var viewForm = new ViewMasterClassesForm();
            viewForm.ShowDialog();
        }

        private void Home_Load(object sender, EventArgs e)
        {
        }
    }
}
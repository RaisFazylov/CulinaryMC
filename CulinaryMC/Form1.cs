using MasterClassManager.Models;

namespace CulinaryMC
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Инициализирует главную форму и обеспечивает создание базы данных.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            using (var db = new ApplicationDbContext())
            {
                db.Initialize();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Открывает форму для добавления нового мастер-класса.
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addForm = new AddMasterClassForm();
            addForm.ShowDialog();
        }

        /// <summary>
        /// Открывает форму для удаления мастер-класса.
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var deleteForm = new DeleteMasterClassForm();
            deleteForm.ShowDialog();
        }

        /// <summary>
        /// Открывает форму для просмотра списка мастер-классов.
        /// </summary>
        private void btnView_Click(object sender, EventArgs e)
        {
            var viewForm = new ViewMasterClassesForm();
            viewForm.ShowDialog();
        }
    }
}
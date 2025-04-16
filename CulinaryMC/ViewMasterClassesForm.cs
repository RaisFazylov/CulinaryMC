using MasterClassManager.Models;
using Microsoft.EntityFrameworkCore;

namespace CulinaryMC
{
    public partial class ViewMasterClassesForm : Form
    {
        public ViewMasterClassesForm()
        {
            InitializeComponent();
            LoadMasterClasses();
        }

        /// <summary>
        /// Загружает список мастер-классов из базы данных и настраивает отображение DataGridView.
        /// </summary>
        private void LoadMasterClasses()
        {
            try
            {
                using var db = new ApplicationDbContext();
                dgvMasterClasses.DataSource = db.MasterClasses.ToList();
                dgvMasterClasses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvMasterClasses.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}");
            }
        }

        private void ViewMasterClassesForm_Load(object sender, EventArgs e)
        {

        }
    }
}
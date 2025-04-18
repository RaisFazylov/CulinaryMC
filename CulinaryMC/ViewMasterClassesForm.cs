using MasterClassManager.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Windows.Forms;
namespace CulinaryMC
{
    /// <summary>
    /// Форма для просмотра и редактирования мастер-классов
    /// </summary>
    public partial class ViewMasterClassesForm : Form
    {
        private ApplicationDbContext _dbContext;
        private BindingSource _bindingSource;

        /// <summary>
        /// Конструктор формы просмотра
        /// </summary>
        public ViewMasterClassesForm()
        {
            InitializeComponent();
            _dbContext = new ApplicationDbContext();
            _bindingSource = new BindingSource();
            LoadMasterClasses();
            ConfigureDataGridView();
            dgvMasterClasses.Columns["Name"].Width = 90;
            dgvMasterClasses.Columns["Date"].Width = 120;
            dgvMasterClasses.Columns["Description"].Width = 358;
            dgvMasterClasses.Columns["Category"].Width = 80;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            dgvMasterClasses.ReadOnly = true;
        }
        private void LoadRecentMasterClasses()
        {
            var recentDate = DateTime.Now.AddDays(-7);
            var recentClasses = _dbContext.MasterClasses
                .Where(mc => mc.Date >= recentDate)
                .OrderByDescending(mc => mc.Date)
                .ToList();

            dgvMasterClasses.DataSource = recentClasses;
            dgvMasterClasses.Columns["Id"].Visible = false;
        }
        /// <summary>
        /// Загрузка всех мастер-классов из базы данных
        /// </summary>
        private void LoadMasterClasses()
        {
            _bindingSource.DataSource = _dbContext.MasterClasses.Local.ToBindingList();
            _dbContext.MasterClasses.Load();
            dgvMasterClasses.DataSource = _bindingSource;
        }

        /// <summary>
        /// Настройка DataGridView для редактирования
        /// </summary>
        private void ConfigureDataGridView()
        {
            dgvMasterClasses.AutoGenerateColumns = true;
            dgvMasterClasses.AllowUserToAddRows = false;
            dgvMasterClasses.AllowUserToDeleteRows = false;
            dgvMasterClasses.ReadOnly = false;
            dgvMasterClasses.Columns["Id"].Visible = false;
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Сохранить изменения"
        /// </summary>
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (dgvMasterClasses.SelectedRows.Count == 0)
            {
                MessageBox.Show("Необходимо выбрать мастер-класс для редактирования");
                return;
            }
            var selectedMasterClass = (MasterClass)dgvMasterClasses.SelectedRows[0].DataBoundItem;

            var editForm = new EditMasterClassForm(selectedMasterClass, _dbContext);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                _dbContext.SaveChanges();
                LoadMasterClasses();
            }
            this.Close();
        }

        /// <summary>
        /// Обработчик закрытия формы
        /// </summary>
        private void ViewMasterClassesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _dbContext?.Dispose();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvMasterClasses.SelectedRows.Count == 0)
            {
                MessageBox.Show("Необходимо выбрать мастер-класс для удаления");
                return;
            }

            var selectedMasterClass = (MasterClass)dgvMasterClasses.SelectedRows[0].DataBoundItem;

            try
            {
                _dbContext.MasterClasses.Remove(selectedMasterClass);
                _dbContext.SaveChanges();
                MessageBox.Show("Мастер-класс успешно удалён!");
                LoadRecentMasterClasses();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении: {ex.Message}");
            }

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(searchText))
            {
                LoadMasterClasses();
                return;
            }
            var filteredClasses = _dbContext.MasterClasses
                .Where(mc =>
                    mc.Name.ToLower().Contains(searchText) ||
                    mc.Description.ToLower().Contains(searchText) ||
                    mc.Category.ToLower().Contains(searchText))
                .ToList();
            dgvMasterClasses.DataSource = filteredClasses;
        }
        private void ViewMasterClassesForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
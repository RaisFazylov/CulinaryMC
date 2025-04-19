using MasterClassManager.Models;
using Microsoft.EntityFrameworkCore;
using ClosedXML.Excel;
using System.IO;
using System.Windows.Forms;

namespace CulinaryMC
{
    /// <summary>
    /// Форма для просмотра, поиска и управления списком мастер-классов
    /// </summary>
    public partial class ViewMasterClassesForm : Form
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly BindingSource _bindingSource;

        /// <summary>
        /// Инициализирует форму просмотра мастер-классов
        /// </summary>
        public ViewMasterClassesForm()
        {
            InitializeComponent();
            _dbContext = new ApplicationDbContext();
            _bindingSource = new BindingSource();

            // Настройка формы
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // Загрузка данных и настройка DataGridView
            LoadMasterClasses();
            ConfigureDataGridView();

            // Настройка заголовков и размеров столбцов
            dgvMasterClasses.Columns["Name"].HeaderText = "Название";
            dgvMasterClasses.Columns["Date"].HeaderText = "Дата";
            dgvMasterClasses.Columns["Description"].HeaderText = "Описание";
            dgvMasterClasses.Columns["Category"].HeaderText = "Проведение";

            dgvMasterClasses.Columns["Name"].Width = 110;
            dgvMasterClasses.Columns["Date"].Width = 119;
            dgvMasterClasses.Columns["Description"].Width = 370;
            dgvMasterClasses.Columns["Category"].Width = 100;

            // Настройка поведения DataGridView
            dgvMasterClasses.ReadOnly = true;
            dgvMasterClasses.RowHeadersVisible = false;
            dgvMasterClasses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        /// <summary>
        /// Загружает мастер-классы за последние 7 дней
        /// </summary>
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
        /// Загружает все мастер-классы из базы данных
        /// </summary>
        private void LoadMasterClasses()
        {
            _bindingSource.DataSource = _dbContext.MasterClasses.Local.ToBindingList();
            _dbContext.MasterClasses.Load();
            dgvMasterClasses.DataSource = _bindingSource;
        }

        /// <summary>
        /// Настраивает DataGridView для отображения мастер-классов
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
        /// Обрабатывает сохранение изменений в выбранном мастер-классе
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
        /// Обрабатывает закрытие формы и освобождает ресурсы
        /// </summary>
        private void ViewMasterClassesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _dbContext?.Dispose();
        }

        /// <summary>
        /// Обрабатывает удаление выбранного мастер-класса
        /// </summary>
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

        /// <summary>
        /// Обрабатывает поиск мастер-классов по введенному тексту
        /// </summary>
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

        /// <summary>
        /// Обрабатывает экспорт данных в Excel
        /// </summary>
        private void btnReport_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel files (*.xlsx)|*.xlsx",
                    Title = "Сохранить Excel файл",
                    FileName = "Мастер-классы_"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (var workbook = new XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add("Мастер-классы");
                        for (int i = 0; i < dgvMasterClasses.Columns.Count; i++)
                        {
                            worksheet.Cell(1, i + 1).Value = dgvMasterClasses.Columns[i].HeaderText;
                        }
                        for (int i = 0; i < dgvMasterClasses.Rows.Count; i++)
                        {
                            for (int j = 0; j < dgvMasterClasses.Columns.Count; j++)
                            {
                                worksheet.Cell(i + 2, j + 1).Value =
                                    dgvMasterClasses.Rows[i].Cells[j].Value?.ToString();
                            }
                        }

                        worksheet.Columns().AdjustToContents();
                        workbook.SaveAs(saveFileDialog.FileName);
                    }

                    MessageBox.Show("Данные успешно экспортированы в Excel!",
                        "Экспорт завершен", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при экспорте в Excel: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ViewMasterClassesForm_Load(object sender, EventArgs e)
        {
        }
    }
}
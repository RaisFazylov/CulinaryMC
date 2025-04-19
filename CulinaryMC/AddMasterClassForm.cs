using MasterClassManager.Models;
using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;

namespace CulinaryMC
{
    /// <summary>
    /// Форма для добавления новых мастер-классов в систему
    /// </summary>
    public partial class AddMasterClassForm : Form
    {
        /// <summary>
        /// Инициализирует форму добавления мастер-класса и настраивает элементы управления
        /// </summary>
        public AddMasterClassForm()
        {
            InitializeComponent();
            // Настройка DataGridView
            dgvLast.Columns.Add("Name", "Имя");
            dgvLast.Columns.Add("Data", "Время");
            dgvLast.Columns["Name"].Width = 145;
            dgvLast.Columns["Data"].Width = 145;

            // Ограничения интерфейса
            dtpDate.MinDate = DateTime.Today;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            txtName.MaxLength = 20;
            txtDescription.MaxLength = 100;

            // Настройка поведения DataGridView
            dgvLast.AllowUserToOrderColumns = false;
            dgvLast.AllowUserToResizeColumns = false;
            dgvLast.AllowUserToResizeRows = false;
            dgvLast.ReadOnly = true;
            dgvLast.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvLast.RowHeadersVisible = false;
        }

        /// <summary>
        /// Обрабатывает сохранение нового мастер-класса в базу данных
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtDescription.Text) ||
                cmbCategory.SelectedItem == null)
            {
                MessageBox.Show("Необходимо заполнить все поля!");
                return;
            }

            if (dtpDate.Value < DateTime.Now)
            {
                MessageBox.Show("Все события на сегодня заняты!");
                return;
            }
            var newMasterClass = new MasterClass
            {
                Name = txtName.Text,
                Date = dtpDate.Value,
                Description = txtDescription.Text,
                Category = cmbCategory.SelectedItem.ToString()
            };

            try
            {
                using var db = new ApplicationDbContext();
                db.MasterClasses.Add(newMasterClass);
                db.SaveChanges();

                MessageBox.Show("Мастер-класс успешно добавлен!");
                object[] rowData = { txtName.Text, dtpDate.Text, cmbCategory.SelectedItem.ToString() };
                dgvLast.Rows.Add(rowData);
            }
            catch (DbUpdateException dbEx)
            {
                MessageBox.Show($"Ошибка при сохранении в базу данных: {dbEx.InnerException?.Message ?? dbEx.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Общая ошибка: {ex.Message}");
            }
        }

        private void AddMasterClassForm_Load(object sender, EventArgs e)
        {

        }
    }
}
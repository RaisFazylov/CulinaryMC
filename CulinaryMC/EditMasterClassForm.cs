using MasterClassManager.Models;
using Microsoft.EntityFrameworkCore;

namespace CulinaryMC
{
    /// <summary>
    /// Форма для редактирования существующих мастер-классов
    /// </summary>
    public partial class EditMasterClassForm : Form
    {
        private readonly MasterClass _masterClass;
        private readonly ApplicationDbContext _dbContext;

        /// <summary>
        /// Инициализирует форму редактирования мастер-класса
        /// </summary>
        public EditMasterClassForm(MasterClass masterClass, ApplicationDbContext dbContext)
        {
            InitializeComponent();
            _masterClass = masterClass;
            _dbContext = dbContext;

            InitializeFormFields();

            // Настройка формы
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            txtName.MaxLength = 20;
            txtDescription.MaxLength = 100;

            dateTimePicker.MinDate = DateTime.Today;
        }

        /// <summary>
        /// Заполняет поля формы данными из мастер-класса
        /// </summary>
        private void InitializeFormFields()
        {
            txtName.Text = _masterClass.Name;
            txtDescription.Text = _masterClass.Description;
            dateTimePicker.Value = _masterClass.Date;
            comboBoxCategory.SelectedItem = _masterClass.Category;

            // Отображение текущих значений
            lblCurrentName.Text = _masterClass.Name;
            lblCurrentDate.Text = _masterClass.Date.ToShortDateString();
            lblCurrentCategory.Text = _masterClass.Category;
            lblCurrentDescription.Text = _masterClass.Description;
        }

        /// <summary>
        /// Обрабатывает сохранение изменений в мастер-классе
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            _masterClass.Name = txtName.Text;
            _masterClass.Description = txtDescription.Text;
            _masterClass.Date = dateTimePicker.Value;
            _masterClass.Category = comboBoxCategory.SelectedItem.ToString();

            _dbContext.Entry(_masterClass).State = EntityState.Modified;
            this.DialogResult = DialogResult.OK;
            this.Close();
            if (dateTimePicker.Value < DateTime.Now)
            {
                MessageBox.Show("Все события на сегодня заняты!");
                return;
            }
        }

        /// <summary>
        /// Обрабатывает отмену редактирования
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void EditMasterClassForm_Load(object sender, EventArgs e)
        {
        }
    }
}
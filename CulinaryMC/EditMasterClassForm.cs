using MasterClassManager.Models;
using Microsoft.EntityFrameworkCore;


namespace CulinaryMC
{
    public partial class EditMasterClassForm : Form
    {
        private MasterClass _masterClass;
        private ApplicationDbContext _dbContext;

        public EditMasterClassForm(MasterClass masterClass, ApplicationDbContext dbContext)
        {
            InitializeComponent();
            _masterClass = masterClass;
            _dbContext = dbContext;
            InitializeFormFields();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
<<<<<<< HEAD
            txtName.MaxLength = 20;
            txtDescription.MaxLength = 100;
=======
            this.MaximizeBox = false;
            dateTimePicker.MinDate = DateTime.Today;
>>>>>>> юзинги
        }

        private void InitializeFormFields()
        {
            txtName.Text = _masterClass.Name;
            txtDescription.Text = _masterClass.Description;
            dateTimePicker.Value = _masterClass.Date;
            comboBoxCategory.SelectedItem = _masterClass.Category;
            lblCurrentName.Text = _masterClass.Name;
            lblCurrentDate.Text = _masterClass.Date.ToShortDateString();
            lblCurrentCategory.Text = _masterClass.Category;
            lblCurrentDescription.Text = _masterClass.Description;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _masterClass.Name = txtName.Text;
            _masterClass.Description = txtDescription.Text;
            _masterClass.Date = dateTimePicker.Value;
            _masterClass.Category = comboBoxCategory.SelectedItem.ToString();
            _dbContext.Entry(_masterClass).State = EntityState.Modified;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

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
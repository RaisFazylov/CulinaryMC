using MasterClassManager.Models;

namespace CulinaryMC
{
    public partial class Form1 : Form
    {
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addForm = new AddMasterClassForm();
            addForm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var deleteForm = new DeleteMasterClassForm();
            deleteForm.ShowDialog();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            var viewForm = new ViewMasterClassesForm();
            viewForm.ShowDialog();
        }
    }
}

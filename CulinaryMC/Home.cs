using MasterClassManager.Models;

namespace CulinaryMC
{
    /// <summary>
    /// ������� ����� ���������� "���������� ������-������"
    /// </summary>
    public partial class Home : Form
    {
        /// <summary>
        /// ����������� ������� �����
        /// </summary>
        public Home()
        {
            InitializeComponent();
            InitializeDatabase();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        /// <summary>
        /// ������������� ���� ������ ��� ������� ����������
        /// </summary>
        private void InitializeDatabase()
        {
            using (var db = new ApplicationDbContext())
            {
                db.Initialize();
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addForm = new AddMasterClassForm();
            addForm.ShowDialog();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            var viewForm = new ViewMasterClassesForm();
            viewForm.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
using MasterClassManager.Models;

namespace CulinaryMC
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// �������������� ������� ����� � ������������ �������� ���� ������.
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
        /// ��������� ����� ��� ���������� ������ ������-������.
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addForm = new AddMasterClassForm();
            addForm.ShowDialog();
        }

        /// <summary>
        /// ��������� ����� ��� �������� ������-������.
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var deleteForm = new DeleteMasterClassForm();
            deleteForm.ShowDialog();
        }

        /// <summary>
        /// ��������� ����� ��� ��������� ������ ������-�������.
        /// </summary>
        private void btnView_Click(object sender, EventArgs e)
        {
            var viewForm = new ViewMasterClassesForm();
            viewForm.ShowDialog();
        }
    }
}
using MasterClassManager.Models;

namespace CulinaryMC
{
    /// <summary>
    /// ������� ����� ���������� ��� ���������� ����������� ������-��������
    /// </summary>
    public partial class Home : Form
    {
        /// <summary>
        /// �������������� ������� ����� � ��������� ����������� � ��
        /// </summary>
        public Home()
        {
            InitializeComponent();
            InitializeDatabase();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        /// <summary>
        /// ��������� � ������� ���� ������ ��� �������������
        /// </summary>
        private void InitializeDatabase()
        {
            using (var db = new ApplicationDbContext())
            {
                db.Initialize();
            }
        }

        /// <summary>
        /// ��������� ����� ���������� ������ ������-������
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addForm = new AddMasterClassForm();
            addForm.ShowDialog();
        }

        /// <summary>
        /// ��������� ����� ��������� � �������������� ������-�������
        /// </summary>
        private void btnView_Click(object sender, EventArgs e)
        {
            var viewForm = new ViewMasterClassesForm();
            viewForm.ShowDialog();
        }

        private void Home_Load(object sender, EventArgs e)
        {
        }
    }
}
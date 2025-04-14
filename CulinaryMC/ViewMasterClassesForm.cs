using MasterClassManager.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CulinaryMC
{
    public partial class ViewMasterClassesForm : Form
    {
        public ViewMasterClassesForm()
        {
            InitializeComponent();
            LoadMasterClasses();
        }
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

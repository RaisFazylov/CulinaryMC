using MasterClassManager.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CulinaryMC
{
    public partial class ViewMasterClassesForm : Form
    {
        private ApplicationDbContext _dbContext;

        public ViewMasterClassesForm()
        {
            InitializeComponent();
            _dbContext = new ApplicationDbContext();
            LoadMasterClasses();
        }

        private void LoadMasterClasses()
        {
            dgvMasterClasses.DataSource = _dbContext.MasterClasses.ToList();
            dgvMasterClasses.Columns["Id"].Visible = false;
            dgvMasterClasses.ReadOnly = false; // Разрешаем редактирование
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                _dbContext.SaveChanges();
                MessageBox.Show("Изменения сохранены успешно!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении изменений: {ex.Message}");
                LoadMasterClasses(); // Перезагружаем данные в случае ошибки
            }
        }

        private void ViewMasterClassesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _dbContext?.Dispose();
        }
    }
}
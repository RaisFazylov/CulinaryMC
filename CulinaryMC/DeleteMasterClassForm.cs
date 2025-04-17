using MasterClassManager.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CulinaryMC
{
    public partial class DeleteMasterClassForm : Form
    {
        private ApplicationDbContext _dbContext;

        public DeleteMasterClassForm()
        {
            InitializeComponent();
            _dbContext = new ApplicationDbContext();
            LoadMasterClasses();
        }

        private void LoadMasterClasses()
        {
            dgvMasterClasses.DataSource = _dbContext.MasterClasses.ToList();
            dgvMasterClasses.Columns["Id"].Visible = false; // Скрываем колонку с ID
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvMasterClasses.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите мастер-класс для удаления");
                return;
            }

            var selectedMasterClass = (MasterClass)dgvMasterClasses.SelectedRows[0].DataBoundItem;

            try
            {
                _dbContext.MasterClasses.Remove(selectedMasterClass);
                _dbContext.SaveChanges();
                MessageBox.Show("Мастер-класс успешно удалён!");
                LoadMasterClasses();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении: {ex.Message}");
            }
        }

        private void DeleteMasterClassForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _dbContext?.Dispose();
        }
    }
}
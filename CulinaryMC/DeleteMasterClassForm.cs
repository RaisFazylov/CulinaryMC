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
    public partial class DeleteMasterClassForm : Form
    {
        public DeleteMasterClassForm()
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
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}");
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvMasterClasses.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите мастер-класс для удаления");
                return;
            }

            var selectedId = (int)dgvMasterClasses.SelectedRows[0].Cells["Id"].Value;

            try
            {
                using var db = new ApplicationDbContext();
                var masterClassToDelete = db.MasterClasses.Find(selectedId);
                if (masterClassToDelete != null)
                {
                    db.MasterClasses.Remove(masterClassToDelete);
                    db.SaveChanges();
                    MessageBox.Show("Мастер-класс успешно удален");
                    LoadMasterClasses();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении: {ex.Message}");
            }
        }
    }
}

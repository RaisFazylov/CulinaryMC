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
    public partial class AddMasterClassForm : Form
    {
        public AddMasterClassForm()
        {
            InitializeComponent();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
        string.IsNullOrWhiteSpace(txtDescription.Text) ||
        cmbCategory.SelectedItem == null)
            {
                MessageBox.Show("Пожалуйста, заполните все поля");
                return;
            }

            var newMasterClass = new MasterClass
            {
                Name = txtName.Text,
                Date = dtpDate.Value,
                Description = txtDescription.Text,
                Category = cmbCategory.SelectedItem.ToString()
            };

            try
            {
                using var db = new ApplicationDbContext();
                db.MasterClasses.Add(newMasterClass);
                db.SaveChanges();
                MessageBox.Show("Мастер-класс успешно добавлен!");
                this.Close();
            }
            catch (DbUpdateException dbEx)
            {
                MessageBox.Show($"Ошибка при сохранении в базу данных: {dbEx.InnerException?.Message ?? dbEx.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Общая ошибка: {ex.Message}");
            }

        }

        private void AddMasterClassForm_Load(object sender, EventArgs e)
        {

        }
    }
}

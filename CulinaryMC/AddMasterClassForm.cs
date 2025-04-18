﻿using MasterClassManager.Models;
using Microsoft.EntityFrameworkCore;

namespace CulinaryMC
{
    public partial class AddMasterClassForm : Form
    {
        public AddMasterClassForm()
        {
            InitializeComponent();
            dataGridView1.Columns.Add("Name", "Имя");
            dataGridView1.Columns.Add("Data", "Время");
            dataGridView1.Columns.Add("Category", "Категория");
        }

        /// <summary>
        /// Сохраняет новый мастер-класс в базу данных после проверки заполнения полей.
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtDescription.Text) ||
                cmbCategory.SelectedItem == null)
            {
                MessageBox.Show("Необходимо заполнить все поля!");
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
                object[] rowData =
                {
                    txtName.Text,
                    dtpDate.Text,
                    cmbCategory.SelectedItem.ToString()
                };
                dataGridView1.Rows.Add(rowData); 
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
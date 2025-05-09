﻿namespace CulinaryMC
{
    partial class ViewMasterClassesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewMasterClassesForm));
            dgvMasterClasses = new DataGridView();
            btnSaveChanges = new Button();
            label1 = new Label();
            txtSearch = new TextBox();
            btnDelete = new Button();
            btnSearch = new Button();
            btnReport = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMasterClasses).BeginInit();
            SuspendLayout();
            // 
            // dgvMasterClasses
            // 
            dgvMasterClasses.AllowUserToAddRows = false;
            dgvMasterClasses.AllowUserToDeleteRows = false;
            dgvMasterClasses.AllowUserToResizeColumns = false;
            dgvMasterClasses.AllowUserToResizeRows = false;
            dgvMasterClasses.BackgroundColor = Color.Moccasin;
            dgvMasterClasses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMasterClasses.GridColor = Color.Cornsilk;
            dgvMasterClasses.Location = new Point(40, 152);
            dgvMasterClasses.Name = "dgvMasterClasses";
            dgvMasterClasses.ReadOnly = true;
            dgvMasterClasses.RowHeadersWidth = 51;
            dgvMasterClasses.RowTemplate.Height = 29;
            dgvMasterClasses.Size = new Size(723, 201);
            dgvMasterClasses.TabIndex = 0;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.BackColor = Color.Moccasin;
            btnSaveChanges.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnSaveChanges.Location = new Point(106, 386);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(170, 52);
            btnSaveChanges.TabIndex = 1;
            btnSaveChanges.Text = "Редактировать";
            btnSaveChanges.UseVisualStyleBackColor = false;
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Moccasin;
            label1.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(166, 19);
            label1.Name = "label1";
            label1.Size = new Size(472, 48);
            label1.TabIndex = 2;
            label1.Text = "Поиск и редактирование мастер-классов";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(40, 93);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(181, 27);
            txtSearch.TabIndex = 3;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Moccasin;
            btnDelete.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(511, 386);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(170, 52);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Moccasin;
            btnSearch.Location = new Point(227, 88);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(34, 36);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "🔍︎";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnReport
            // 
            btnReport.Location = new Point(771, 422);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(27, 28);
            btnReport.TabIndex = 6;
            btnReport.Text = "📃";
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Moccasin;
            label2.Location = new Point(717, 426);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 7;
            label2.Text = "Отчет";
            // 
            // ViewMasterClassesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(btnReport);
            Controls.Add(btnSearch);
            Controls.Add(btnDelete);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Controls.Add(btnSaveChanges);
            Controls.Add(dgvMasterClasses);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ViewMasterClassesForm";
            Text = "Кулинарные мастер-классы";
            Load += ViewMasterClassesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMasterClasses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMasterClasses;
        private Button btnSaveChanges;
        private Label label1;
        private TextBox txtSearch;
        private Button btnDelete;
        private Button btnSearch;
        private Button btnReport;
        private Label label2;
    }
}
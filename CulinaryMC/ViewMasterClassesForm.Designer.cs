namespace CulinaryMC
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
            btnSaveChanges.Location = new Point(127, 386);
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
            label1.Location = new Point(174, 19);
            label1.Name = "label1";
            label1.Size = new Size(448, 48);
            label1.TabIndex = 2;
            label1.Text = "Поиск и редактирование мастер-классов";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(40, 80);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(181, 27);
            txtSearch.TabIndex = 3;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Moccasin;
            btnDelete.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(523, 386);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(128, 52);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Moccasin;
            btnSearch.Location = new Point(219, 79);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(31, 29);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "🔍︎";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // ViewMasterClassesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(800, 450);
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
    }
}
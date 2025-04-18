namespace CulinaryMC
{
    partial class AddMasterClassForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMasterClassForm));
            txtName = new TextBox();
            txtDescription = new TextBox();
            dtpDate = new DateTimePicker();
            cmbCategory = new ComboBox();
            btnSave = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Cursor = Cursors.IBeam;
            txtName.Location = new Point(123, 88);
            txtName.Name = "txtName";
            txtName.Size = new Size(250, 27);
            txtName.TabIndex = 0;
            // 
            // txtDescription
            // 
            txtDescription.Cursor = Cursors.IBeam;
            txtDescription.Location = new Point(123, 198);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(250, 27);
            txtDescription.TabIndex = 1;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(123, 148);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(250, 27);
            dtpDate.TabIndex = 2;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "Online", "Offline", "Online-offline" });
            cmbCategory.Location = new Point(124, 248);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(249, 28);
            cmbCategory.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Moccasin;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(352, 348);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(109, 35);
            btnSave.TabIndex = 4;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 91);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 5;
            label1.Text = "Название";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 148);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 6;
            label2.Text = "Дата";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 198);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 7;
            label3.Text = "Описание";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 251);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 8;
            label4.Text = "Категория";
            // 
            // label5
            // 
            label5.BackColor = Color.Moccasin;
            label5.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(244, 9);
            label5.Name = "label5";
            label5.Size = new Size(322, 49);
            label5.TabIndex = 9;
            label5.Text = "Добавить мастер-класс";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = Color.Moccasin;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(417, 88);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(347, 188);
            dataGridView1.TabIndex = 10;
            // 
            // AddMasterClassForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Controls.Add(cmbCategory);
            Controls.Add(dtpDate);
            Controls.Add(txtDescription);
            Controls.Add(txtName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddMasterClassForm";
            Text = "Кулинарные мастер-классы";
            Load += AddMasterClassForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtDescription;
        private DateTimePicker dtpDate;
        private ComboBox cmbCategory;
        private Button btnSave;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DataGridView dataGridView1;
    }
}
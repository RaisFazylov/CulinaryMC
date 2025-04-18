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
            label6 = new Label();
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
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(250, 83);
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
            cmbCategory.Location = new Point(124, 287);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(249, 28);
            cmbCategory.TabIndex = 3;
            cmbCategory.Text = "Online";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Moccasin;
            btnSave.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(324, 353);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(163, 57);
            btnSave.TabIndex = 4;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Moccasin;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 88);
            label1.Name = "label1";
            label1.Size = new Size(108, 27);
            label1.TabIndex = 5;
            label1.Text = "Название";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.Moccasin;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 148);
            label2.Name = "label2";
            label2.Size = new Size(108, 27);
            label2.TabIndex = 6;
            label2.Text = "Дата";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = Color.Moccasin;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 198);
            label3.Name = "label3";
            label3.Size = new Size(108, 27);
            label3.TabIndex = 7;
            label3.Text = "Описание";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = Color.Moccasin;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 287);
            label4.Name = "label4";
            label4.Size = new Size(108, 28);
            label4.TabIndex = 8;
            label4.Text = "Категория";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.BackColor = Color.Moccasin;
            label5.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(235, 9);
            label5.Name = "label5";
            label5.Size = new Size(354, 49);
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
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(347, 227);
            dataGridView1.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(489, 65);
            label6.Name = "label6";
            label6.Size = new Size(184, 20);
            label6.TabIndex = 11;
            label6.Text = "Только что добавленные";
            // 
            // AddMasterClassForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
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
        private Label label6;
    }
}
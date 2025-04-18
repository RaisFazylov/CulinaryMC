namespace CulinaryMC
{
    partial class EditMasterClassForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditMasterClassForm));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtName = new TextBox();
            txtDescription = new TextBox();
            dateTimePicker = new DateTimePicker();
            comboBoxCategory = new ComboBox();
            lblCurrentName = new Label();
            lblCurrentDate = new Label();
            lblCurrentDescription = new Label();
            lblCurrentCategory = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Moccasin;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 119);
            label1.Name = "label1";
            label1.Size = new Size(102, 27);
            label1.TabIndex = 0;
            label1.Text = "Название";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.Moccasin;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 180);
            label2.Name = "label2";
            label2.Size = new Size(102, 27);
            label2.TabIndex = 1;
            label2.Text = "Дата";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = Color.Moccasin;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 234);
            label3.Name = "label3";
            label3.Size = new Size(104, 23);
            label3.TabIndex = 2;
            label3.Text = "Описание";
            // 
            // label4
            // 
            label4.BackColor = Color.Moccasin;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 290);
            label4.Name = "label4";
            label4.Size = new Size(102, 25);
            label4.TabIndex = 3;
            label4.Text = "Категория";
            // 
            // txtName
            // 
            txtName.Location = new Point(113, 119);
            txtName.Name = "txtName";
            txtName.Size = new Size(250, 27);
            txtName.TabIndex = 4;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(113, 234);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(250, 27);
            txtDescription.TabIndex = 5;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(113, 180);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(250, 27);
            dateTimePicker.TabIndex = 6;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Items.AddRange(new object[] { "Online", "Offline", "Online-Offline" });
            comboBoxCategory.Location = new Point(115, 290);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(250, 28);
            comboBoxCategory.TabIndex = 7;
            // 
            // lblCurrentName
            // 
            lblCurrentName.BackColor = Color.Moccasin;
            lblCurrentName.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblCurrentName.Location = new Point(538, 119);
            lblCurrentName.Name = "lblCurrentName";
            lblCurrentName.Size = new Size(119, 27);
            lblCurrentName.TabIndex = 8;
            lblCurrentName.Text = "Название";
            lblCurrentName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCurrentDate
            // 
            lblCurrentDate.BackColor = Color.Moccasin;
            lblCurrentDate.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblCurrentDate.Location = new Point(538, 180);
            lblCurrentDate.Name = "lblCurrentDate";
            lblCurrentDate.Size = new Size(119, 27);
            lblCurrentDate.TabIndex = 9;
            lblCurrentDate.Text = "Дата";
            lblCurrentDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCurrentDescription
            // 
            lblCurrentDescription.BackColor = Color.Moccasin;
            lblCurrentDescription.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblCurrentDescription.Location = new Point(538, 234);
            lblCurrentDescription.Name = "lblCurrentDescription";
            lblCurrentDescription.Size = new Size(119, 27);
            lblCurrentDescription.TabIndex = 10;
            lblCurrentDescription.Text = "Описание";
            lblCurrentDescription.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCurrentCategory
            // 
            lblCurrentCategory.BackColor = Color.Moccasin;
            lblCurrentCategory.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblCurrentCategory.Location = new Point(536, 290);
            lblCurrentCategory.Name = "lblCurrentCategory";
            lblCurrentCategory.Size = new Size(121, 28);
            lblCurrentCategory.TabIndex = 11;
            lblCurrentCategory.Text = "Категория";
            lblCurrentCategory.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Moccasin;
            btnSave.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(146, 367);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(142, 50);
            btnSave.TabIndex = 12;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Moccasin;
            btnCancel.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.Location = new Point(508, 368);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(140, 49);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // label5
            // 
            label5.BackColor = Color.Moccasin;
            label5.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(168, 9);
            label5.Name = "label5";
            label5.Size = new Size(480, 53);
            label5.TabIndex = 14;
            label5.Text = "Редактирование мастер-класса";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.BackColor = Color.Moccasin;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(508, 77);
            label6.Name = "label6";
            label6.Size = new Size(179, 30);
            label6.TabIndex = 15;
            label6.Text = "Текущее состояние";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // EditMasterClassForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(lblCurrentCategory);
            Controls.Add(lblCurrentDescription);
            Controls.Add(lblCurrentDate);
            Controls.Add(lblCurrentName);
            Controls.Add(comboBoxCategory);
            Controls.Add(dateTimePicker);
            Controls.Add(txtDescription);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EditMasterClassForm";
            Text = "Кулинарные мастер-классы";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtName;
        private TextBox txtDescription;
        private DateTimePicker dateTimePicker;
        private ComboBox comboBoxCategory;
        private Label lblCurrentName;
        private Label lblCurrentDate;
        private Label lblCurrentDescription;
        private Label lblCurrentCategory;
        private Button btnSave;
        private Button btnCancel;
        private Label label5;
        private Label label6;
    }
}
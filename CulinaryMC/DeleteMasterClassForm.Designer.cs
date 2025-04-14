namespace CulinaryMC
{
    partial class DeleteMasterClassForm
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
            dgvMasterClasses = new DataGridView();
            btnDelete = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMasterClasses).BeginInit();
            SuspendLayout();
            // 
            // dgvMasterClasses
            // 
            dgvMasterClasses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMasterClasses.Location = new Point(12, 94);
            dgvMasterClasses.Name = "dgvMasterClasses";
            dgvMasterClasses.RowHeadersWidth = 51;
            dgvMasterClasses.RowTemplate.Height = 29;
            dgvMasterClasses.Size = new Size(776, 291);
            dgvMasterClasses.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Moccasin;
            btnDelete.Location = new Point(358, 391);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Moccasin;
            label1.Location = new Point(340, 24);
            label1.Name = "label1";
            label1.Size = new Size(132, 20);
            label1.TabIndex = 2;
            label1.Text = "Выбрать событие";
            // 
            // DeleteMasterClassForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnDelete);
            Controls.Add(dgvMasterClasses);
            Name = "DeleteMasterClassForm";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)dgvMasterClasses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMasterClasses;
        private Button btnDelete;
        private Label label1;
    }
}
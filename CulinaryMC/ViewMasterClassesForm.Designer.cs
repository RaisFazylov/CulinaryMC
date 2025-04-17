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
            dgvMasterClasses = new DataGridView();
            btnSaveChanges = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMasterClasses).BeginInit();
            SuspendLayout();
            // 
            // dgvMasterClasses
            // 
            dgvMasterClasses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMasterClasses.Location = new Point(40, 113);
            dgvMasterClasses.Name = "dgvMasterClasses";
            dgvMasterClasses.RowHeadersWidth = 51;
            dgvMasterClasses.RowTemplate.Height = 29;
            dgvMasterClasses.Size = new Size(723, 240);
            dgvMasterClasses.TabIndex = 0;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.Location = new Point(376, 395);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(94, 29);
            btnSaveChanges.TabIndex = 1;
            btnSaveChanges.Text = "button1";
            btnSaveChanges.UseVisualStyleBackColor = true;
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // ViewMasterClassesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSaveChanges);
            Controls.Add(dgvMasterClasses);
            Name = "ViewMasterClassesForm";
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)dgvMasterClasses).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvMasterClasses;
        private Button btnSaveChanges;
    }
}
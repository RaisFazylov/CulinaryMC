namespace CulinaryMC
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            btnAdd = new Button();
            btnView = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            labelo = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Moccasin;
            btnAdd.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(168, 347);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(123, 38);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnView
            // 
            btnView.BackColor = Color.Moccasin;
            btnView.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnView.Location = new Point(520, 347);
            btnView.Name = "btnView";
            btnView.Size = new Size(126, 38);
            btnView.TabIndex = 2;
            btnView.Text = "Просмотр";
            btnView.UseVisualStyleBackColor = false;
            btnView.Click += btnView_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(103, 104);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(303, 168);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.ErrorImage = (Image)resources.GetObject("pictureBox2.ErrorImage");
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.InitialImage = (Image)resources.GetObject("pictureBox2.InitialImage");
            pictureBox2.Location = new Point(471, 104);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(246, 168);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // labelo
            // 
            labelo.BackColor = Color.Moccasin;
            labelo.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            labelo.Location = new Point(194, 19);
            labelo.Name = "labelo";
            labelo.Size = new Size(415, 47);
            labelo.TabIndex = 5;
            labelo.Text = "Кулинарные мастер-классы";
            labelo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(800, 450);
            Controls.Add(labelo);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnView);
            Controls.Add(btnAdd);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Home";
            Text = "Кулинарные мастер-классы";
            Load += Home_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAdd;
        private Button btnView;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label labelo;
    }
}

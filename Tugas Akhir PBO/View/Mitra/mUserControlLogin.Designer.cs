namespace Tugas_Akhir_PBO.View.Mitra
{
    partial class mUserControlLogin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mUserControlLogin));
            EmailBox = new TextBox();
            PasswordBox = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            AdminLogin = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // EmailBox
            // 
            EmailBox.BorderStyle = BorderStyle.None;
            EmailBox.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmailBox.Location = new Point(1260, 459);
            EmailBox.Name = "EmailBox";
            EmailBox.Size = new Size(370, 23);
            EmailBox.TabIndex = 0;
            // 
            // PasswordBox
            // 
            PasswordBox.BorderStyle = BorderStyle.None;
            PasswordBox.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordBox.Location = new Point(1260, 544);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Size = new Size(370, 23);
            PasswordBox.TabIndex = 1;
            PasswordBox.TextChanged += passwordBox_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(1245, 610);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(392, 67);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += LoginButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Poppins", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(1465, 701);
            label1.Name = "label1";
            label1.Size = new Size(51, 23);
            label1.TabIndex = 3;
            label1.Text = "Daftar";
            label1.Click += RegisterLabel_Click;
            // 
            // AdminLogin
            // 
            AdminLogin.AutoSize = true;
            AdminLogin.BackColor = Color.Transparent;
            AdminLogin.Font = new Font("Poppins", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AdminLogin.Location = new Point(1468, 71);
            AdminLogin.Name = "AdminLogin";
            AdminLogin.Size = new Size(44, 23);
            AdminLogin.TabIndex = 4;
            AdminLogin.Text = "Login";
            AdminLogin.Click += AdminLabel_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Poppins", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(1468, 721);
            label2.Name = "label2";
            label2.Size = new Size(44, 23);
            label2.TabIndex = 5;
            label2.Text = "Login";
            label2.Click += AdminLabel_Click;
            // 
            // mUserControlLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(label2);
            Controls.Add(AdminLogin);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(PasswordBox);
            Controls.Add(EmailBox);
            Name = "mUserControlLogin";
            Size = new Size(1920, 1080);
            Load += mUserControlLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox EmailBox;
        private TextBox PasswordBox;
        private PictureBox pictureBox1;
        private Label label1;
        private Label AdminLogin;
        private Label label2;
    }
}

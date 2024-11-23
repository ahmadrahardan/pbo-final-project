namespace Tugas_Akhir_PBO.View
{
    partial class UserControlLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlLogin));
            EmailBox = new TextBox();
            PasswordBox = new TextBox();
            RegisterLabel = new Label();
            pictureBox1 = new PictureBox();
            MitraLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // EmailBox
            // 
            EmailBox.BorderStyle = BorderStyle.None;
            EmailBox.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmailBox.Location = new Point(1260, 449);
            EmailBox.Name = "EmailBox";
            EmailBox.Size = new Size(370, 23);
            EmailBox.TabIndex = 0;
            // 
            // PasswordBox
            // 
            PasswordBox.BorderStyle = BorderStyle.None;
            PasswordBox.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordBox.Location = new Point(1260, 535);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Size = new Size(370, 23);
            PasswordBox.TabIndex = 1;
            PasswordBox.TextChanged += passwordBox_TextChanged;
            // 
            // RegisterLabel
            // 
            RegisterLabel.AutoSize = true;
            RegisterLabel.BackColor = Color.Transparent;
            RegisterLabel.Font = new Font("Poppins", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RegisterLabel.Location = new Point(1468, 692);
            RegisterLabel.Name = "RegisterLabel";
            RegisterLabel.Size = new Size(51, 23);
            RegisterLabel.TabIndex = 2;
            RegisterLabel.Text = "Daftar";
            RegisterLabel.Click += RegisterLabel_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(1245, 593);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(392, 67);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += LoginButton_Click;
            // 
            // MitraLabel
            // 
            MitraLabel.AutoSize = true;
            MitraLabel.BackColor = Color.Transparent;
            MitraLabel.Font = new Font("Poppins", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MitraLabel.Location = new Point(1463, 712);
            MitraLabel.Name = "MitraLabel";
            MitraLabel.Size = new Size(44, 23);
            MitraLabel.TabIndex = 4;
            MitraLabel.Text = "Login";
            MitraLabel.Click += MitraLabel_Click;
            // 
            // UserControlLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(MitraLabel);
            Controls.Add(pictureBox1);
            Controls.Add(RegisterLabel);
            Controls.Add(PasswordBox);
            Controls.Add(EmailBox);
            Name = "UserControlLogin";
            Size = new Size(1920, 1080);
            Load += UserControlLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox EmailBox;
        private TextBox PasswordBox;
        private Label RegisterLabel;
        private PictureBox pictureBox1;
        private Label MitraLabel;
    }
}

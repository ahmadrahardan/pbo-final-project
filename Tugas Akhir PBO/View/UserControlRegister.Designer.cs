namespace Tugas_Akhir_PBO.View
{
    partial class UserControlRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlRegister));
            LoginLabel = new Label();
            pictureBox1 = new PictureBox();
            UsernameBox = new TextBox();
            EmailBox = new TextBox();
            PasswordBox = new TextBox();
            ConfirmPasswordBox = new TextBox();
            RegistrationCodeBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.BackColor = Color.Transparent;
            LoginLabel.Font = new Font("Poppins", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginLabel.Location = new Point(1467, 895);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(52, 23);
            LoginLabel.TabIndex = 0;
            LoginLabel.Text = "Masuk";
            LoginLabel.Click += LoginLabel_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(1270, 800);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(393, 67);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += RegisterButton_Click;
            // 
            // UsernameBox
            // 
            UsernameBox.BorderStyle = BorderStyle.None;
            UsernameBox.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UsernameBox.Location = new Point(1289, 453);
            UsernameBox.Name = "UsernameBox";
            UsernameBox.Size = new Size(353, 23);
            UsernameBox.TabIndex = 2;
            // 
            // EmailBox
            // 
            EmailBox.BorderStyle = BorderStyle.None;
            EmailBox.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmailBox.Location = new Point(1289, 527);
            EmailBox.Name = "EmailBox";
            EmailBox.Size = new Size(353, 23);
            EmailBox.TabIndex = 3;
            // 
            // PasswordBox
            // 
            PasswordBox.BorderStyle = BorderStyle.None;
            PasswordBox.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordBox.Location = new Point(1289, 595);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Size = new Size(353, 23);
            PasswordBox.TabIndex = 4;
            // 
            // ConfirmPasswordBox
            // 
            ConfirmPasswordBox.BorderStyle = BorderStyle.None;
            ConfirmPasswordBox.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ConfirmPasswordBox.Location = new Point(1289, 664);
            ConfirmPasswordBox.Name = "ConfirmPasswordBox";
            ConfirmPasswordBox.Size = new Size(353, 23);
            ConfirmPasswordBox.TabIndex = 5;
            // 
            // RegistrationCodeBox
            // 
            RegistrationCodeBox.BorderStyle = BorderStyle.None;
            RegistrationCodeBox.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RegistrationCodeBox.Location = new Point(1289, 735);
            RegistrationCodeBox.Name = "RegistrationCodeBox";
            RegistrationCodeBox.Size = new Size(353, 23);
            RegistrationCodeBox.TabIndex = 6;
            // 
            // UserControlRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(RegistrationCodeBox);
            Controls.Add(ConfirmPasswordBox);
            Controls.Add(PasswordBox);
            Controls.Add(EmailBox);
            Controls.Add(UsernameBox);
            Controls.Add(pictureBox1);
            Controls.Add(LoginLabel);
            Name = "UserControlRegister";
            Size = new Size(1920, 1080);
            Load += Register_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LoginLabel;
        private PictureBox pictureBox1;
        private TextBox UsernameBox;
        private TextBox EmailBox;
        private TextBox PasswordBox;
        private TextBox ConfirmPasswordBox;
        private TextBox RegistrationCodeBox;
    }
}

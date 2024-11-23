using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tugas_Akhir_PBO.App.Context.Admin;
using Tugas_Akhir_PBO.App.Models.Admin;
using Tugas_Akhir_PBO.View.Mitra;

namespace Tugas_Akhir_PBO.View
{
    public partial class UserControlLogin : UserControl
    {
        LandingPage FormParent;
        public UserControlLogin(LandingPage FormParent)
        {
            InitializeComponent();
            this.FormParent = FormParent;
        }

        private void RegisterLabel_Click(object sender, EventArgs e)
        {
            FormParent.ShowRegister();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            LoginContext loginAdminContext = new LoginContext();
            Login login = loginAdminContext.Validate(EmailBox.Text, PasswordBox.Text);

            if (login != null)
            {
                MessageBox.Show("Login berhasil!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.FormParent.ShowDashboard();
                ClearTextBox();
            }
            else if (string.IsNullOrEmpty(EmailBox.Text) || string.IsNullOrEmpty(PasswordBox.Text))
            {
                MessageBox.Show("Email & Password tidak boleh kosong!", "FAILED", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Email atau Password salah. Masukkan dengan benar!", "LOGIN FAILED", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MitraLabel_Click(object sender, EventArgs e)
        {
            this.FormParent.Hide();
            mLandingPage mitraForm = new mLandingPage();
            mitraForm.Show();
        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {
            PasswordBox.PasswordChar = '*';
        }

        public void ClearTextBox()
        {
            EmailBox.Text = "";
            PasswordBox.Text = "";
        }

        private void UserControlLogin_Load(object sender, EventArgs e)
        {
            
        }

    }
}

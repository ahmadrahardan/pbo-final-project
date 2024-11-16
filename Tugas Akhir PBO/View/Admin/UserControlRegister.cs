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

namespace Tugas_Akhir_PBO.View
{
    public partial class UserControlRegister : UserControl
    {
        LandingPage FormParent;
        public UserControlRegister(LandingPage FormParent)
        {
            InitializeComponent();
            this.FormParent = FormParent;
        }

        private void LoginLabel_Click(object sender, EventArgs e)
        {
            FormParent.ShowLogin();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UsernameBox.Text) || string.IsNullOrEmpty(EmailBox.Text) ||
                string.IsNullOrEmpty(PasswordBox.Text) || string.IsNullOrEmpty(ConfirmPasswordBox.Text) ||
                string.IsNullOrEmpty(RegistrationCodeBox.Text))
            {
                MessageBox.Show("Semua field harus diisi!", "FAILED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (PasswordBox.Text != ConfirmPasswordBox.Text)
            {
                MessageBox.Show("Password dan konfirmasi password tidak sesuai!", "FAILED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (RegistrationCodeBox.Text != "12345")
            {
                MessageBox.Show("Kode registrasi salah!", "FAILED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Register register = new Register(
                UsernameBox.Text,
                EmailBox.Text,
                PasswordBox.Text
            );

            RegisterContext registerContext = new RegisterContext();
            bool isRegistered = registerContext.Register(register);

            if (isRegistered)
            {
                MessageBox.Show("Register berhasil!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearTextBox();
            }
            else
            {
                MessageBox.Show("Gagal mendaftarkan user. Email atau username mungkin sudah digunakan.", "FAILED", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        public void ClearTextBox()
        {
            UsernameBox.Text = "";
            EmailBox.Text = "";
            PasswordBox.Text = "";
            ConfirmPasswordBox.Text = "";
            RegistrationCodeBox.Text = "";
        }
    }
}

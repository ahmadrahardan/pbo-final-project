using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tugas_Akhir_PBO.App.Context.Mitra;
using Tugas_Akhir_PBO.App.Models.Mitra;

namespace Tugas_Akhir_PBO.View.Mitra
{
    public partial class mUserControlRegister : UserControl
    {
        mLandingPage FormParent;
        public mUserControlRegister(mLandingPage FormParent)
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

            mRegister register = new mRegister(
                UsernameBox.Text,
                EmailBox.Text,
                PasswordBox.Text
            );

            mRegisterContext registerContext = new mRegisterContext();
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

        public void ClearTextBox()
        {
            UsernameBox.Text = "";
            EmailBox.Text = "";
            PasswordBox.Text = "";
            ConfirmPasswordBox.Text = "";
            RegistrationCodeBox.Text = "";
        }

        private void mUserControlRegister_Load(object sender, EventArgs e)
        {

        }
    }
}

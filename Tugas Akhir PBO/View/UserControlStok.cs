using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_Akhir_PBO.View
{
    public partial class UserControlStok : UserControl
    {
        LandingPage FormParent;
        public UserControlStok(LandingPage FormParent)
        {
            InitializeComponent();
            this.FormParent = FormParent;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FormParent.ShowDashboard();
        }

        private void btnPengelolaanProduk_Click(object sender, EventArgs e)
        {
            FormParent.ShowKelolaProduk();
        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            FormParent.ShowTransaksi();
        }

        private void LogoutBox_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                FormParent.ShowLogin();
            }
        }

        private void UserControlStok_Load(object sender, EventArgs e)
        {

        }
    }
}

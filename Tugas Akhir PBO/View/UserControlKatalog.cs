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
    public partial class UserControlKatalog : UserControl
    {
        LandingPage FormParent;
        public UserControlKatalog(LandingPage FormParent)
        {
            InitializeComponent();
            this.FormParent = FormParent;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FormParent.ShowDashboard();
        }

        private void btnPengelolaanStok_Click(object sender, EventArgs e)
        {
            FormParent.ShowKelolaStok();
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

        private void UserControlKatalog_Load(object sender, EventArgs e)
        {

        }
    }
}

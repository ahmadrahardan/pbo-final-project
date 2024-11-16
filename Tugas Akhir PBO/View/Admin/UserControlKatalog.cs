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
        UCAddProduk addProduk;
        public UserControlKatalog(LandingPage FormParent)
        {
            InitializeComponent();
            addProduk = new UCAddProduk(this);

            this.Controls.Add(addProduk);
            addProduk.Visible = false;
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

        private void btnAddProduk_Click(object sender, EventArgs e)
        {
            ShowAddProduk();
        }

        public void ShowAddProduk()
        {
            addProduk.Visible = true;
            addProduk.BringToFront();
        }

        private void LogoutBox_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                FormParent.ShowLogin();
            }
        }

        //private void InitializePanelKatalog()
        //{
        //    panelKatalog = new Panel
        //    {
        //        Location = new Point(485, 280),
        //        Size = new Size(1340, 720), 
        //        AutoScroll = true,
        //        BackColor = Color.Transparent,
        //        Name = "panelDashboard"
        //    };

        //    this.Controls.Add(panelKatalog);
        //}

        private void UserControlKatalog_Load(object sender, EventArgs e)
        {

        }
    }
}

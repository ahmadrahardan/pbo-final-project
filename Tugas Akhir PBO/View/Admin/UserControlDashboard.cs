using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tugas_Akhir_PBO.App.Context.Admin;

namespace Tugas_Akhir_PBO.View
{
    public partial class UserControlDashboard : UserControl
    {
        LandingPage FormParent;
        UserControlLogin login;
        public UserControlDashboard(LandingPage FormParent)
        {
            InitializeComponent();
            this.FormParent = FormParent;
            this.DGVriwayat = DGVriwayat;
            this.Controls.Add(totalKatalogLabel);
            this.Controls.Add(totalPenghasilanLabel);
            this.Controls.Add(totalDisewaLabel);
        }

        private void LoadTotalBarangDisewa()
        {
            TransaksiContext transaksiContext = new TransaksiContext();
            int totalBarangDisewa = transaksiContext.GetJumlahBarangDisewa();
            totalDisewaLabel.Text = $"{totalBarangDisewa}";
        }

        Label totalDisewaLabel = new Label
        {
            Location = new Point(530, 280),
            Font = new Font("Poppins", 32, FontStyle.Bold),
            ForeColor = Color.Black,
            BackColor = Color.FromArgb(255, 255, 255),
            AutoSize = true,
        };

        private void LoadTotalHargaSum()
        {
            TransaksiContext transaksiContext = new TransaksiContext();
            int totalHargaSum = transaksiContext.GetTotalHargaSum();
            totalPenghasilanLabel.Text = $"Rp.{totalHargaSum.ToString("N0", new CultureInfo("id-ID"))}";
        }

        Label totalPenghasilanLabel = new Label
        {
            Location = new Point(1450, 280),
            Font = new Font("Poppins", 18, FontStyle.Bold),
            ForeColor = Color.Black,
            BackColor = Color.FromArgb(255, 255, 255),
            AutoSize = true,
        };

        private void LoadTotalKatalogCount()
        {
            KatalogContext katalogContext = new KatalogContext();
            int totalKatalogCount = katalogContext.GetTotalKatalogCount();
            totalKatalogLabel.Text = $"{totalKatalogCount}";
        }

        Label totalKatalogLabel = new Label
        {
            Location = new Point(1030, 280),
            Font = new Font("Poppins", 32, FontStyle.Bold),
            ForeColor = Color.Black,
            BackColor = Color.FromArgb(255, 255, 255),
            AutoSize = true,
        };

        private void LoadDataRiwayatTransaksi()
        {
            try
            {
                DGVriwayat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                DGVriwayat.AllowUserToAddRows = false;

                DataTable riwayatTransaksi = DashboardContext.All();
                if (riwayatTransaksi == null)
                {
                    MessageBox.Show("Error: Gagal mengambil data mahasiswa");
                    return;
                }

                DGVriwayat.Columns.Clear();

                DGVriwayat.DataSource = riwayatTransaksi;

                if (DGVriwayat.Columns["id_transaksi"] != null) DGVriwayat.Columns["id_transaksi"].Visible = false;
                if (DGVriwayat.Columns["tanggal_transaksi"] != null)
                    DGVriwayat.Columns["tanggal_transaksi"].HeaderText = "Tgl Transaksi";
                if (DGVriwayat.Columns["nama"] != null)
                    DGVriwayat.Columns["nama"].HeaderText = "Nama";
                if (DGVriwayat.Columns["total_harga"] != null)
                    DGVriwayat.Columns["total_harga"].HeaderText = "Total Harga";
                if (DGVriwayat.Columns["tanggal_kembali"] != null)
                    DGVriwayat.Columns["tanggal_kembali"].HeaderText = "Tgl Kembali";
                if (DGVriwayat.Columns["nama_produk"] != null)
                    DGVriwayat.Columns["nama_produk"].HeaderText = "Nama Produk";
                if (DGVriwayat.Columns["daftar_produk"] != null)
                    DGVriwayat.Columns["daftar_produk"].HeaderText = "Daftar Produk";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error dalam loadDataRiwayatTransaksi: {ex.Message}\n{ex.StackTrace}");
            }
        }

        private void btnPengelolaanStok_Click(object sender, EventArgs e)
        {
            FormParent.ShowKelolaStok();
        }

        private void btnPengelolaanProduk_Click(object sender, EventArgs e)
        {
            FormParent.ShowKelolaProduk();
        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            FormParent.ShowTransaksi();
        }

        private void UserControlDashboard_Load(object sender, EventArgs e)
        {
            LoadDataRiwayatTransaksi();
            LoadTotalKatalogCount();
            LoadTotalHargaSum();
            LoadTotalBarangDisewa();
            totalKatalogLabel.BringToFront();
            totalPenghasilanLabel.BringToFront();
            totalDisewaLabel.BringToFront();

        }

        private void LogoutBox_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                FormParent.ShowLogin();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

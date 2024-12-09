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
using Tugas_Akhir_PBO.View.Admin;

namespace Tugas_Akhir_PBO.View
{
    public partial class UserControlDashboard : UserControl
    {
        LandingPage FormParent;
        public UCAddRiwayat addRiwayat;
        UserControlLogin login;
        UserControlStok stokControl;
        Label totalProdukLabel;
        Label totalProdukDisewaLabel;
        Label totalPenghasilanLabel;
        FlowLayoutPanel panelStruk;

        public UserControlDashboard(LandingPage FormParent, UserControlStok stokControl)
        {
            InitializeComponent();
            this.FormParent = FormParent;
            this.stokControl = stokControl;

            addRiwayat = new UCAddRiwayat(this, stokControl);
            this.Controls.Add(addRiwayat);
            addRiwayat.Visible = false;

            InitializeTotalProdukLabel();
            InitializeTotalProdukDisewaLabel();
            InitializeTotalPenghasilanLabel();
            InitializePanelRiwayat();
            LoadTotalProduk();
            LoadTotalProdukDisewa();
            LoadTotalPenghasilan();
            LoadRiwayat();
        }

        public void SetStokControl(UserControlStok stokControl)
        {
            this.stokControl = stokControl;
        }

        private void InitializeTotalProdukLabel()
        {
            totalProdukLabel = new Label
            {
                Text = "",
                Font = new Font("Poppins", 36, FontStyle.Bold),
                ForeColor = Color.Black,
                BackColor = Color.Transparent,
                Location = new Point(520, 290), 
                AutoSize = true
            };

            this.Controls.Add(totalProdukLabel);
        }

        private void InitializeTotalProdukDisewaLabel()
        {
            totalProdukDisewaLabel = new Label
            {
                Text = "",
                Font = new Font("Poppins", 36, FontStyle.Bold),
                ForeColor = Color.Black,
                BackColor = Color.Transparent,
                Location = new Point(985, 290), 
                AutoSize = true
            };

            this.Controls.Add(totalProdukDisewaLabel);
        }

        private void InitializeTotalPenghasilanLabel()
        {
            totalPenghasilanLabel = new Label
            {
                Text = "",
                Font = new Font("Poppins", 18, FontStyle.Bold),
                ForeColor = Color.Black,
                BackColor = Color.Transparent,
                Location = new Point(1472, 310),
                AutoSize = true
            };

            this.Controls.Add(totalPenghasilanLabel);
        }

        private void InitializePanelRiwayat()
        {
            panelStruk = new FlowLayoutPanel
            {
                Location = new Point(510, 615),
                Size = new Size(1300, 360),
                AutoScroll = false,
                BackColor = Color.Transparent,
                Name = "panelRiwayat",
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false
            };

            this.Controls.Add(panelStruk);
        }

        public void LoadTotalProduk()
        {
            try
            {
                KatalogContext katalogContext = new KatalogContext();
                List<Katalog> katalogList = katalogContext.GetAllKatalog();
                int totalProduk = katalogList.Count;

                totalProdukLabel.Text = $"{totalProduk}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat total produk: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadTotalProdukDisewa()
        {
            try
            {
                TransaksiContext transaksiContext = new TransaksiContext();
                List<Transaksi> transaksiList = transaksiContext.GetAllTransaksi();

                int totalProdukDisewa = transaksiList.Count(t => t.Status == "Disewa");

                totalProdukDisewaLabel.Text = $"{totalProdukDisewa}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat total produk disewa: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadTotalPenghasilan()
        {
            try
            {
                TransaksiContext transaksiContext = new TransaksiContext();
                List<Transaksi> transaksiList = transaksiContext.GetAllTransaksi();

                decimal totalPenghasilan = transaksiList.Sum(t => t.TotalHarga);

                totalPenghasilanLabel.Text = $"Rp{totalPenghasilan:N0}"; 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat total penghasilan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadRiwayat()
        {
            try
            {
                TransaksiContext transaksiContext = new TransaksiContext();
                List<Transaksi> transaksiList = transaksiContext.GetAllTransaksi();

                var riwayatTerbaru = transaksiList
                    .OrderByDescending(t => t.TanggalTransaksi)
                    .Take(5)
                    .ToList();

                panelStruk.Controls.Clear();

                foreach (var transaksi in riwayatTerbaru)
                {
                    AddRiwayatCard(
                        transaksi.TanggalTransaksi.ToString("dd/MM/yyyy"), 
                        transaksi.Nama, 
                        transaksi.TotalHarga, 
                        transaksi.TanggalKembali.ToString("dd/MM/yyyy"), 
                        transaksi.Status 
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat riwayat transaksi: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddRiwayatCard(string tanggalTransaksi, string penyewa, decimal totalHarga, string tanggalKembali, string status)
        {
            Panel card = new Panel
            {
                Size = new Size(1294, 60), 
                BackColor = Color.Transparent,
                BorderStyle = BorderStyle.None,
                Margin = new Padding(5)
            };

            Label tanggalTransaksiLabel = new Label
            {
                Text = tanggalTransaksi,
                Font = new Font("Poppins", 14, FontStyle.Regular),
                BackColor = Color.Transparent,
                ForeColor = Color.Black,
                Location = new Point(18, 12),
                AutoSize = true
            };

            Label penyewaLabel = new Label
            {
                Text = penyewa,
                Font = new Font("Poppins", 14, FontStyle.Regular),
                BackColor = Color.Transparent,
                ForeColor = Color.Black,
                Location = new Point(267, 12),
                AutoSize = true
            };

            Label totalHargaLabel = new Label
            {
                Text = $"Rp{totalHarga:N0}",
                Font = new Font("Poppins", 14, FontStyle.Regular),
                BackColor = Color.Transparent,
                ForeColor = Color.Black,
                Location = new Point(550, 12),
                AutoSize = true
            };

            Label tanggalKembaliLabel = new Label
            {
                Text = tanggalKembali,
                Font = new Font("Poppins", 14, FontStyle.Regular),
                BackColor = Color.Transparent,
                ForeColor = Color.Black,
                Location = new Point(841, 12),
                AutoSize = true
            };

            Label statusLabel = new Label
            {
                Text = status,
                Font = new Font("Poppins", 14, FontStyle.Regular),
                BackColor = Color.Transparent,
                ForeColor = Color.Black,
                Location = new Point(1130, 12),
                AutoSize = true
            };

            card.Controls.Add(tanggalTransaksiLabel);
            card.Controls.Add(penyewaLabel);
            card.Controls.Add(totalHargaLabel);
            card.Controls.Add(tanggalKembaliLabel);
            card.Controls.Add(statusLabel);

            panelStruk.Controls.Add(card);
        }

        private void btnAddRiwayat_Click(object sender, EventArgs e)
        {
            ShowAddRiwayat();
        }

        public void ShowAddRiwayat()
        {
            addRiwayat.Visible = true;
            addRiwayat.BringToFront();
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

        }

        private void LogoutBox_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                FormParent.ShowLogin();
            }
        }
    }
}

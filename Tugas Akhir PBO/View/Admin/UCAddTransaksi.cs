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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tugas_Akhir_PBO.View.Admin
{
    public partial class UCAddTransaksi : UserControl
    {
        UserControlTransaksi UCTransaksi;
        Label totalHargaLabel;
        Label kembaliLabel;
        LandingPage FormParent;

        public UCAddTransaksi(UserControlTransaksi UCTransaksi, LandingPage FormParent)
        {
            InitializeComponent();
            this.UCTransaksi = UCTransaksi;
            this.FormParent = FormParent;
            InitializeTotalHargaLabel();
            InitializeKembaliLabel();
        }

        private void InitializeTotalHargaLabel()
        {
            totalHargaLabel = new Label
            {
                Text = "Rp0",
                Font = new Font("Poppins", 12, FontStyle.Bold),
                ForeColor = Color.Black,
                BackColor = Color.Transparent,
                Location = new Point(735, 400),
                AutoSize = true
            };

            this.Controls.Add(totalHargaLabel);
        }

        private void InitializeKembaliLabel()
        {
            kembaliLabel = new Label
            {
                Text = "Rp0",
                Font = new Font("Poppins", 12, FontStyle.Bold),
                ForeColor = Color.Black,
                BackColor = Color.Transparent,
                Location = new Point(735, 560),
                AutoSize = true
            };
            
            this.Controls.Add(kembaliLabel);
        }

        private void CetakStruk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NamaBox.Text) || string.IsNullOrWhiteSpace(NIKBox.Text) || string.IsNullOrWhiteSpace(TanggalKembaliBox.Text))
            {
                MessageBox.Show("Semua field harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Transaksi transaksi = new Transaksi
                {
                    Nama = NamaBox.Text,
                    NIK = NIKBox.Text,
                    TotalHarga = UCTransaksi.TotalHarga,
                    TanggalKembali = DateTime.Parse(TanggalKembaliBox.Text),
                    TanggalTransaksi = DateTime.Now
                };

                TransaksiContext transaksiContext = new TransaksiContext();
                KatalogContext katalogContext = new KatalogContext();
                int idTransaksi = transaksiContext.AddTransaksi(transaksi);

                List<(string NamaProduk, int Jumlah, decimal HargaSatuan)> produkDisewa = new List<(string, int, decimal)>();
                foreach (Panel card in UCTransaksi.GetPanelTransaksi().Controls.OfType<Panel>())
                {
                    Label jumlahLabel = card.Controls.OfType<Label>().FirstOrDefault(l => l.Location == new Point(362, 88));
                    Label hargaLabel = card.Controls.OfType<Label>().FirstOrDefault(l => l.Location == new Point(145, 40));
                    Label namaLabel = card.Controls.OfType<Label>().FirstOrDefault(l => l.Location == new Point(145, 78));

                    int jumlah = int.Parse(jumlahLabel.Text);
                    decimal harga = decimal.Parse(hargaLabel.Text.Replace("Rp", "").Replace(".", ""));
                    string namaProduk = namaLabel.Text;

                    produkDisewa.Add((namaProduk, jumlah, harga));

                    int idKatalog = (int)card.Tag; 
                    DetailTransaksi detail = new DetailTransaksi
                    {
                        id_transaksi = idTransaksi,
                        id_katalog = idKatalog,
                        Jumlah = jumlah
                    };

                    transaksiContext.AddDetailTransaksi(detail);
                    katalogContext.UpdateStokProduk(idKatalog, jumlah);
                }

                MessageBox.Show("Transaksi berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                NamaBox.Text = string.Empty;
                NIKBox.Text = string.Empty;
                TanggalKembaliBox.Text = string.Empty;

                UCTransaksi.ShowAddStruk();
                UCTransaksi.addStruk.LoadProduk(produkDisewa);
                UCTransaksi.addStruk.LoadTransaksi(transaksi);
                UCTransaksi.ClearTransaksi();

                UserControlStok ucStok = FormParent.Controls.OfType<UserControlStok>().FirstOrDefault();
                if (ucStok != null)
                {
                    ucStok.LoadKatalog();
                }

                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UCAddTransaksi_Load(object sender, EventArgs e)
        {
            decimal totalHarga = UCTransaksi.TotalHarga;

            totalHargaLabel.Text = $"Rp{totalHarga:N0}";

            kembaliLabel.Text = "Rp0";
        }

        private void BayarBox_TextChanged(object sender, EventArgs e)
        {
            UpdateKembalian();
        }

        private void BayarBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                UpdateKembalian();
            }
        }

        public void UpdateTotalHarga(decimal totalHarga)
        {
            totalHargaLabel.Text = $"Rp{totalHarga:N0}";
        }


        private void UpdateKembalian()
        {
            decimal bayar = 0;

            decimal totalHarga = UCTransaksi.TotalHarga;

            if (decimal.TryParse(BayarBox.Text, out bayar))
            {
                decimal kembali = bayar - totalHarga;

                kembaliLabel.Text = $"Rp{Math.Max(0, kembali):N0}";
            }
            else
            {
                kembaliLabel.Text = "Rp0";
            }
        }

        private void CloseBox_Click(object sender, EventArgs e)
        {
            NamaBox.Text = string.Empty;
            NIKBox.Text = string.Empty;
            TanggalKembaliBox.Text = string.Empty;
            BayarBox.Text = string.Empty;
            kembaliLabel.Text = "Rp0"; 
            this.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

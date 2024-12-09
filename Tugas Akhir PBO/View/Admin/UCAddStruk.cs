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

namespace Tugas_Akhir_PBO.View.Admin
{
    public partial class UCAddStruk : UserControl
    {
        UserControlTransaksi UCTransaksi;
        FlowLayoutPanel panelStruk;
        Label tanggalTransaksi;
        Label tanggalKembali;
        Label penyewa;
        Label totalHarga;

        public UCAddStruk(UserControlTransaksi UCTransaksi)
        {
            InitializeComponent();
            this.UCTransaksi = UCTransaksi;
            InitializePanelStruk();
            InitializeTanggalTransaksiLabel();
            InitializeTanggalKembaliLabel();
            InitializePenyewaLabel();
            InitializeTotalHargaLabel();
        }

        private void InitializeTanggalTransaksiLabel()
        {
            tanggalTransaksi = new Label
            {
                Text = "",
                Font = new Font("Poppins", 7, FontStyle.Regular),
                ForeColor = Color.Black,
                BackColor = Color.Transparent,
                Location = new Point(200, 72), 
                AutoSize = true
            };

            this.Controls.Add(tanggalTransaksi);
        }

        private void InitializeTanggalKembaliLabel()
        {
            tanggalKembali = new Label
            {
                Text = "",
                Font = new Font("Poppins", 7, FontStyle.Regular),
                ForeColor = Color.Black,
                BackColor = Color.Transparent,
                Location = new Point(200, 111), 
                AutoSize = true
            };

            this.Controls.Add(tanggalKembali);
        }

        private void InitializePenyewaLabel()
        {
            penyewa = new Label
            {
                Text = "",
                Font = new Font("Poppins", 7, FontStyle.Regular),
                ForeColor = Color.Black,
                BackColor = Color.Transparent,
                Location = new Point(200, 91),
                AutoSize = true
            };

            this.Controls.Add(penyewa);
        }

        private void InitializeTotalHargaLabel()
        {
            totalHarga = new Label
            {
                Text = "Rp0",
                Font = new Font("Poppins", 9, FontStyle.Bold),
                ForeColor = Color.Black,
                BackColor = Color.Transparent,
                Location = new Point(338, 509), 
                AutoSize = true
            };

            this.Controls.Add(totalHarga);
        }

        private void InitializePanelStruk()
        {
            panelStruk = new FlowLayoutPanel
            {
                Location = new Point(20, 230),
                Size = new Size(420, 275),
                AutoScroll = false,
                BackColor = Color.Transparent,
                Name = "panelStruk",
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false
            };

            this.Controls.Add(panelStruk);
        }

        public void LoadTransaksi(Transaksi transaksi)
        {
            tanggalTransaksi.Text = $"{transaksi.TanggalTransaksi:dd-MM-yyyy}";
            tanggalKembali.Text = $"{transaksi.TanggalKembali:dd-MM-yyyy}";
            penyewa.Text = $"{transaksi.Nama}";
            totalHarga.Text = $"Rp{transaksi.TotalHarga:N0}";
        }


        private void UCAddStruk_Load(object sender, EventArgs e)
        {

        }

        public void LoadProduk(List<(string NamaProduk, int Jumlah, decimal HargaSatuan)> produkList)
        {
            panelStruk.Controls.Clear(); 

            foreach (var produk in produkList)
            {
                AddProdukCard(produk.NamaProduk, produk.Jumlah, produk.HargaSatuan);
            }
        }

        private void AddProdukCard(string namaProduk, int jumlah, decimal hargaSatuan)
        {
            decimal totalHargaProduk = jumlah * hargaSatuan;

            Panel card = new Panel
            {
                Size = new Size(414, 40), 
                BackColor = Color.Transparent,
                BorderStyle = BorderStyle.None,
                Margin = new Padding(5)
            };

            Label namaProdukLabel = new Label
            {
                Text = namaProduk,
                Font = new Font("Poppins", 9, FontStyle.Regular),
                BackColor = Color.Transparent,
                ForeColor = Color.Black,
                Location = new Point(3, 7),
                AutoSize = true
            };

            Label jumlahLabel = new Label
            {
                Text = jumlah.ToString(),
                Font = new Font("Poppins", 9, FontStyle.Regular),
                BackColor = Color.Transparent,
                ForeColor = Color.Black,
                Location = new Point(150, 7),
                AutoSize = true
            };

            Label hargaPerSatuanLabel = new Label
            {
                Text = $"{hargaSatuan:N0}",
                Font = new Font("Poppins", 9, FontStyle.Regular),
                BackColor = Color.Transparent,
                ForeColor = Color.Black,
                Location = new Point(235, 7),
                AutoSize = true
            };

            Label totalHargaLabel = new Label
            {
                Text = $"{totalHargaProduk:N0}",
                Font = new Font("Poppins", 9, FontStyle.Regular),
                BackColor = Color.Transparent,
                ForeColor = Color.Black,
                Location = new Point(335, 7),
                AutoSize = true
            };

            card.Controls.Add(namaProdukLabel);
            card.Controls.Add(jumlahLabel);
            card.Controls.Add(hargaPerSatuanLabel);
            card.Controls.Add(totalHargaLabel);

            panelStruk.Controls.Add(card);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            tanggalTransaksi.Text = "";
            tanggalKembali.Text = "";
            penyewa.Text = "";
            totalHarga.Text = "Rp0";

            panelStruk.Controls.Clear();

            this.Visible = false;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

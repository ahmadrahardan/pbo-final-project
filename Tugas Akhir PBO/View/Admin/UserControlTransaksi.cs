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
    public partial class UserControlTransaksi : UserControl
    {
        LandingPage FormParent;
        UCAddTransaksi addTransaksi;
        FlowLayoutPanel panelKatalog;
        FlowLayoutPanel panelTransaksi;
        Label totalHargaLabel;
        public UCAddStruk addStruk;

        public UserControlTransaksi(LandingPage FormParent)
        {
            InitializeComponent();
            this.FormParent = FormParent;

            addTransaksi = new UCAddTransaksi(this, FormParent);
            this.Controls.Add(addTransaksi);
            addTransaksi.Visible = false;

            addStruk = new UCAddStruk(this);
            this.Controls.Add(addStruk);
            addStruk.Visible = false;

            InitializePanelKatalog();
            InitializePanelTransaksi();
            InitializeTotalHargaLabel();
            LoadKatalog();

        }

        private void InitializePanelKatalog()
        {
            panelKatalog = new FlowLayoutPanel
            {
                Location = new Point(445, 150),
                Size = new Size(860, 857),
                AutoScroll = true,
                BackColor = Color.Transparent,
                Name = "panelKatalog",
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = true
            };

            this.Controls.Add(panelKatalog);
        }

        private void InitializePanelTransaksi()
        {
            panelTransaksi = new FlowLayoutPanel
            {
                Location = new Point(1355, 237),
                Size = new Size(465, 565),
                AutoScroll = true,
                BackColor = Color.Transparent,
                Name = "panelTransaksi",
                FlowDirection = FlowDirection.TopDown,
                WrapContents = true
            };

            this.Controls.Add(panelTransaksi);
        }

        private void InitializeTotalHargaLabel()
        {
            totalHargaLabel = new Label
            {
                Text = "Rp0",
                Font = new Font("Poppins", 14, FontStyle.Bold),
                ForeColor = Color.Black,
                BackColor = Color.Transparent,
                Location = new Point(1650, 827), 
                AutoSize = true
            };

            this.Controls.Add(totalHargaLabel);
        }

        public void LoadKatalog()
        {
            panelKatalog.Controls.Clear();
            KatalogContext katalogContext = new KatalogContext();
            List<Katalog> katalogList = katalogContext.GetAllKatalog();

            var availableKatalogList = katalogList.Where(k => k.Stok > 0).ToList();

            foreach (var katalog in availableKatalogList)
            {
                AddKatalogCard(katalog);
            }
        }


        private void AddKatalogCard(Katalog katalog)
        {
            Panel card = new Panel
            {
                Size = new Size(195, 243),
                BackColor = Color.Transparent,
                BackgroundImage = Properties.Resources.Panel_BarangAllUse,
                Margin = new Padding(10)
            };

            Label namaLabel = new Label
            {
                Text = katalog.NamaProduk,
                Font = new Font("Poppins", 9, FontStyle.Bold),
                BackColor = Color.Transparent,
                ForeColor = Color.Gold,
                Location = new Point(13, 167),
                AutoSize = true
            };

            Label hargaLabel = new Label
            {
                Text = $"{katalog.Harga:C}",
                Font = new Font("Poppins", 7, FontStyle.Bold),
                BackColor = Color.Transparent,
                ForeColor = Color.BlueViolet,
                Location = new Point(13, 144),
                AutoSize = true
            };

            PictureBox pictureBox = new PictureBox
            {
                Size = new Size(170, 107),
                Location = new Point(13, 7),
                BackColor = Color.Transparent,
                Image = Image.FromStream(new MemoryStream(katalog.Gambar)),
                SizeMode = PictureBoxSizeMode.Zoom
            };

            PictureBox plusBox = new PictureBox
            {
                Size = new Size(32, 32),
                Location = new Point(81, 205),
                BackColor = Color.Transparent,
                BackgroundImage = Properties.Resources.Button_PlusTransaksi,
            };

            plusBox.Click += (object sender, EventArgs e) =>
            {
                AddTransaksiCard(katalog);
                UpdateTotalHarga();
            };

            card.Controls.Add(namaLabel);
            card.Controls.Add(hargaLabel);
            card.Controls.Add(pictureBox);
            card.Controls.Add(plusBox);

            panelKatalog.Controls.Add(card);
        }

        private void AddTransaksiCard(Katalog katalog)
        {
            Panel existingCard = panelTransaksi.Controls.OfType<Panel>().FirstOrDefault(c => c.Tag != null && (int)c.Tag == katalog.id_katalog);

            if (existingCard != null)
            {
                MessageBox.Show("Produk ini sudah ada di daftar transaksi.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Panel card = new Panel
            {
                Size = new Size(442, 131),
                BackColor = Color.Transparent,
                Margin = new Padding(10),
                BackgroundImage = Properties.Resources.Panel_BarangDaftarTransaksi,
                Tag = katalog.id_katalog
            };

            Label namaLabel = new Label
            {
                Text = katalog.NamaProduk,
                Font = new Font("Poppins", 10, FontStyle.Bold),
                BackColor = Color.Transparent,
                ForeColor = Color.Gold,
                Location = new Point(145, 78),
                AutoSize = true
            };

            Label hargaLabel = new Label
            {
                Text = $"{katalog.Harga:C}",
                Font = new Font("Poppins", 10, FontStyle.Bold),
                BackColor = Color.Transparent,
                ForeColor = Color.BlueViolet,
                Location = new Point(145, 40),
                AutoSize = true
            };

            PictureBox pictureBox = new PictureBox
            {
                Size = new Size(98, 102),
                Location = new Point(15, 16),
                BackColor = Color.Transparent,
                Image = Image.FromStream(new MemoryStream(katalog.Gambar)),
                SizeMode = PictureBoxSizeMode.Zoom
            };

            PictureBox deleteBox = new PictureBox
            {
                Size = new Size(62, 16),
                Location = new Point(367, 4),
                BackColor = Color.Transparent,
                BackgroundImage = Properties.Resources.Group_2,
            };

            deleteBox.Click += (object sender, EventArgs e) =>
            {
                panelTransaksi.Controls.Remove(card);
                UpdateTotalHarga();
            };

            Label jumlahLabel = new Label
            {
                Text = "1",
                Font = new Font("Poppins", 10, FontStyle.Bold),
                BackColor = Color.Transparent,
                ForeColor = Color.Black,
                Location = new Point(362, 88),
                AutoSize = true
            };

            PictureBox plusBox = new PictureBox
            {
                Size = new Size(32, 32),
                Location = new Point(397, 86),
                BackColor = Color.Transparent,
                BackgroundImage = Properties.Resources.Button_PlusTransaksi,
            };

            plusBox.Click += (object sender, EventArgs e) =>
            {
                int jumlah = int.Parse(jumlahLabel.Text);
                if (jumlah < katalog.Stok) 
                {
                    jumlah++;
                    jumlahLabel.Text = jumlah.ToString();
                    UpdateTotalHarga();
                }
            };

            PictureBox minusBox = new PictureBox
            {
                Size = new Size(32, 32),
                Location = new Point(324, 86),
                BackColor = Color.Transparent,
                BackgroundImage = Properties.Resources.Button_MinusTransaksi,
            };

            minusBox.Click += (object sender, EventArgs e) =>
            {
                int jumlah = int.Parse(jumlahLabel.Text);
                if (jumlah > 1) 
                {
                    jumlah--; 
                    jumlahLabel.Text = jumlah.ToString();
                    UpdateTotalHarga();
                }

            };

            card.Controls.Add(namaLabel);
            card.Controls.Add(hargaLabel);
            card.Controls.Add(pictureBox);
            card.Controls.Add(deleteBox);
            card.Controls.Add(jumlahLabel);
            card.Controls.Add(plusBox);
            card.Controls.Add(minusBox);

            panelTransaksi.Controls.Add(card);
        }

        public decimal TotalHarga
        {
            get
            {
                decimal totalHarga = 0;

                foreach (Panel card in panelTransaksi.Controls.OfType<Panel>())
                {
                    Label jumlahLabel = card.Controls.OfType<Label>().FirstOrDefault(l => l.Location == new Point(362, 88));
                    Label hargaLabel = card.Controls.OfType<Label>().FirstOrDefault(l => l.Location == new Point(145, 40));

                    if (jumlahLabel != null && hargaLabel != null)
                    {
                        int jumlah = int.Parse(jumlahLabel.Text);
                        string hargaText = hargaLabel.Text.Replace("Rp", "").Replace(".", "").Trim();
                        decimal harga = decimal.Parse(hargaText);

                        totalHarga += jumlah * harga;
                    }
                }

                return totalHarga;
            }
        }

        private void UpdateTotalHarga()
        {
            totalHargaLabel.Text = $"Rp{TotalHarga:N0}";
        }

        public FlowLayoutPanel GetPanelTransaksi()
        {
            return panelTransaksi;
        }

        public void ResetTransaksi()
        {
            panelTransaksi.Controls.Clear();
            UpdateTotalHarga();
        }

        public void ShowAddTransaksi()
        {
            addTransaksi.UpdateTotalHarga(this.TotalHarga);
            addTransaksi.Visible = true;
            addTransaksi.BringToFront();
        }

        public void ShowAddStruk()
        {
            addStruk.Visible = true;
            addStruk.BringToFront();
        }

        private void btnAddTransaksi_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(totalHargaLabel.Text) && totalHargaLabel.Text != "Rp0")
            {
                ShowAddTransaksi();
            }
            else
            {
                MessageBox.Show("Tidak ada item dalam daftar transaksi. Tambahkan item terlebih dahulu!",
                    "Informasi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
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

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FormParent.ShowDashboard();
        }

        private void LogoutBox_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                FormParent.ShowLogin();
            }
        }

        public void ClearTransaksi()
        {
            panelTransaksi.Controls.Clear();

            totalHargaLabel.Text = "Rp0";
        }


        private void UserControlTransakasi_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

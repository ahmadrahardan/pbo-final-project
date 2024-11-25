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
    public partial class UserControlTransaksi : UserControl
    {
        LandingPage FormParent;
        FlowLayoutPanel panelKatalog;
        FlowLayoutPanel panelTransaksi;
        public UserControlTransaksi(LandingPage FormParent)
        {
            InitializeComponent();
            this.FormParent = FormParent;

            InitializePanelKatalog();
            InitializePanelTransaksi();
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

        public void LoadKatalog()
        {
            panelKatalog.Controls.Clear();
            KatalogContext katalogContext = new KatalogContext();
            List<Katalog> katalogList = katalogContext.GetAllKatalog();

            foreach (var katalog in katalogList)
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
                SizeMode = PictureBoxSizeMode.StretchImage
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
            };

            card.Controls.Add(namaLabel);
            card.Controls.Add(hargaLabel);
            card.Controls.Add(pictureBox);
            card.Controls.Add(plusBox);

            panelKatalog.Controls.Add(card);
        }

        private void AddTransaksiCard(Katalog katalog)
        {
            Panel existingCard = panelTransaksi.Controls
                .OfType<Panel>()
                .FirstOrDefault(c => c.Tag != null && (int)c.Tag == katalog.id_katalog);

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
                Font = new Font("Poppins", 14, FontStyle.Bold),
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
                SizeMode = PictureBoxSizeMode.StretchImage
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
                jumlah++; 
                jumlahLabel.Text = jumlah.ToString();
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

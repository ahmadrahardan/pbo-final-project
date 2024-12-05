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
    public partial class UserControlStok : UserControl
    {
        LandingPage FormParent;
        FlowLayoutPanel panelKatalog;
        UserControlTransaksi UCTransaksi;
        public UserControlStok(LandingPage FormParent, UserControlTransaksi UCTransaksi)
        {
            InitializeComponent();
            this.FormParent = FormParent;
            this.UCTransaksi = UCTransaksi;

            InitializePanelKatalog();
            LoadKatalog();
        }

        private void InitializePanelKatalog()
        {
            panelKatalog = new FlowLayoutPanel
            {
                Location = new Point(445, 150),
                Size = new Size(1411, 857),
                AutoScroll = true,
                BackColor = Color.Transparent,
                Name = "panelKatalog",
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = true
            };

            this.Controls.Add(panelKatalog);
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
                SizeMode = PictureBoxSizeMode.Zoom
            };

            Label stokLabel = new Label
            {
                Text = $"{katalog.Stok}",
                Font = new Font("Poppins", 11, FontStyle.Bold),
                BackColor = Color.Transparent,
                ForeColor = Color.Black,
                Location = new Point(80, 205),
                AutoSize = true
            };

            PictureBox plusBox = new PictureBox
            {
                Size = new Size(32, 32),
                Location = new Point(150, 205),
                BackColor = Color.Transparent,
                BackgroundImage = Properties.Resources.Button_PlusTransaksi,
            };

            plusBox.Click += (object sender, EventArgs e) =>
            {
                katalog.Stok++;
                stokLabel.Text = katalog.Stok.ToString();

                try
                {
                    StokContext.UpdateStok(katalog.id_katalog, katalog.Stok);
                    UCTransaksi.LoadKatalog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Gagal memperbarui stok: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };

            PictureBox minusBox = new PictureBox
            {
                Size = new Size(32, 32),
                Location = new Point(13, 205),
                BackColor = Color.Transparent,
                BackgroundImage = Properties.Resources.Button_MinusTransaksi,
            };

            minusBox.Click += (object sender, EventArgs e) =>
            {
                if (katalog.Stok > 0)
                {
                    katalog.Stok--;
                    stokLabel.Text = katalog.Stok.ToString();

                    try
                    {
                        StokContext.UpdateStok(katalog.id_katalog, katalog.Stok);
                        UCTransaksi.LoadKatalog();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Gagal memperbarui stok: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Stok tidak bisa kurang dari 0.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            };

            card.Controls.Add(namaLabel);
            card.Controls.Add(hargaLabel);
            card.Controls.Add(stokLabel);
            card.Controls.Add(pictureBox);
            card.Controls.Add(plusBox);
            card.Controls.Add(minusBox);

            panelKatalog.Controls.Add(card);
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

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
    public partial class UCAddProduk : UserControl
    {
        UserControlKatalog UCKatalog;
        public UCAddProduk(UserControlKatalog UCKatalog)
        {
            InitializeComponent();
            this.UCKatalog = UCKatalog;
        }

        private void UCAddProduk_Load(object sender, EventArgs e)
        {

        }

        private void NamaProdukBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UppicBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp",
                Title = "Pilih Gambar Produk"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = Image.FromFile(openFileDialog.FileName);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void DoneBox_Click(object sender, EventArgs e)
        {
            string namaProduk = NamaProdukBox.Text;
            int hargaProduk;
            int.TryParse(HargaProdukBox.Text, out hargaProduk);
            int kategori = KategoriBox.SelectedIndex + 1;

            if (string.IsNullOrWhiteSpace(namaProduk) || hargaProduk <= 0 || kategori <= 0 || pictureBox.Image == null)
            {
                MessageBox.Show("Pastikan semua data terisi dengan benar, termasuk gambar.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            byte[] imageBytes;
            using (MemoryStream ms = new MemoryStream())
            {
                pictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                imageBytes = ms.ToArray();
            }

            KatalogContext katalogContext = new KatalogContext();
            Katalog katalog = new Katalog
            {
                Nama = namaProduk,
                Harga = hargaProduk,
                id_kategori = kategori,
                Gambar = imageBytes
            };

            try
            {
                katalogContext.AddKatalog(katalog);
                MessageBox.Show("Produk berhasil ditambahkan ke katalog.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                NamaProdukBox.Text = "";
                HargaProdukBox.Text = "";
                KategoriBox.SelectedIndex = -1;
                pictureBox.Image = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HargaProdukBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void KategoriBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}

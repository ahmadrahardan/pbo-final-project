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

namespace Tugas_Akhir_PBO.View
{
    public partial class UCAddProduk : UserControl
    {
        public bool IsEditMode { get; set; } = false;
        public int KatalogId { get; set; }
        UserControlKatalog UCKatalog;
        public UCAddProduk(UserControlKatalog UCKatalog)
        {
            InitializeComponent();
            this.UCKatalog = UCKatalog;
        }

        private void UCAddProduk_Load(object sender, EventArgs e)
        {
            LoadKategori();
        }

        public void LoadProdukForEdit(Katalog katalog)
        {
            NamaProdukBox.Text = katalog.Nama;
            HargaProdukBox.Text = katalog.Harga.ToString();
            KategoriBox.SelectedValue = katalog.id_kategori;

            using (MemoryStream ms = new MemoryStream(katalog.Gambar))
            {
                pictureBox.Image = Image.FromStream(ms);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            KatalogId = katalog.id;
            IsEditMode = true;
        }

        private void LoadKategori()
        {
            DataTable dataKategori = KategoriContext.All();
            KategoriBox.DisplayMember = "nama";
            KategoriBox.ValueMember = "id";
            KategoriBox.DataSource = dataKategori;
            KategoriBox.DropDownStyle = ComboBoxStyle.DropDownList;
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

            if (string.IsNullOrWhiteSpace(namaProduk) || hargaProduk <= 0 ||  pictureBox.Image == null)
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
                id = KatalogId,
                Nama = namaProduk,
                Harga = hargaProduk,
                id_kategori = (int)KategoriBox.SelectedValue,
                Gambar = imageBytes
            };

            try
            {
                if (IsEditMode)
                {
                    katalogContext.UpdateKatalog(katalog); 
                    MessageBox.Show("Produk berhasil diperbarui.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    katalogContext.AddKatalog(katalog); 
                    MessageBox.Show("Produk berhasil ditambahkan ke katalog.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                ResetForm();

                UCKatalog.LoadKatalog();

                this.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CloseBox_Click(object sender, EventArgs e)
        {
            ResetForm();

            this.Visible = false;
        }

        public void ResetForm()
        {
            NamaProdukBox.Text = "";
            HargaProdukBox.Text = "";
            pictureBox.Image = null;

            IsEditMode = false; 
            KatalogId = 0; 
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Akhir_PBO.App.Models.Admin
{
    internal class Katalog
    {
        public int id { get; set; }
        public string Nama { get; set; }
        public int Harga { get; set; }
        public int id_kategori { get; set; }
        public byte[] Gambar { get; set; }

        //public Katalog(string nama, string harga)
        //{
        //    Nama = nama;
        //    Harga = harga;
        //}
    }
}

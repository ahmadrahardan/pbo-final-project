using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Akhir_PBO.App.Models.Admin
{
    public class Katalog
    {
        public int id_katalog { get; set; }
        public string NamaProduk { get; set; }
        public int Harga { get; set; }
        public int Stok { get; set; }
        public int id_kategori { get; set; }
        public byte[] Gambar { get; set; }
    }
}

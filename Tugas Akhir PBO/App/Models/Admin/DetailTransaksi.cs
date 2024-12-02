using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Akhir_PBO.App.Models.Admin
{
    internal class DetailTransaksi
    {
        public int id_detail { get; set; }
        public int id_transaksi { get; set; }
        public int id_katalog { get; set; }
        public int Jumlah { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Akhir_PBO.App.Models.Admin
{
    public class Transaksi
    {
        public int id_transaksi { get; set; }
        public string Nama { get; set; }
        public string NIK { get; set; }
        public decimal TotalHarga { get; set; }
        public DateTime TanggalKembali { get; set; }
        public DateTime TanggalTransaksi { get; set; }
        public string Status { get; set; }
    }
}

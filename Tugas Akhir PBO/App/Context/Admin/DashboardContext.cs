using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tugas_Akhir_PBO.App.Core;
using Tugas_Akhir_PBO.App.Models.Admin;

namespace Tugas_Akhir_PBO.App.Context.Admin
{
    internal class DashboardContext : Database
    {
        private static string table = "transaksi";

        public static DataTable All()
        {
            string query = @"
            SELECT
                t.id_transaksi,
                t.tanggal_transaksi,
                t.nama,
                t.total_harga,
                t.tanggal_kembali,
                STRING_AGG(k.nama_produk, ',') AS daftar_produk
            FROM
                transaksi t
            JOIN
                detailtransaksi dt ON t.id_transaksi = dt.id_transaksi
            JOIN
                katalog k ON dt.id_katalog = k.id_katalog
            GROUP BY
                t.id_transaksi, t.tanggal_transaksi, t.nama, t.total_harga, t.tanggal_kembali";
            DataTable dataTransaksi = Database.queryExecutor(query);
            return dataTransaksi;
        }
    }
}
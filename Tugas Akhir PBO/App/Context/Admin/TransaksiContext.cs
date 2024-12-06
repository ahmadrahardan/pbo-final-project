using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using Tugas_Akhir_PBO.App.Core;
using Tugas_Akhir_PBO.App.Models.Admin;

namespace Tugas_Akhir_PBO.App.Context.Admin
{
    internal class TransaksiContext : Database
    {
        private static string transaksiTable = "Transaksi";
        private static string detailTransaksiTable = "DetailTransaksi";

        public int AddTransaksi(Transaksi transaksi)
        {
            string query = $"INSERT INTO {transaksiTable} (nama, nik, total_harga, tanggal_kembali, tanggal_transaksi) VALUES (@nama, @nik, @total_harga, @tanggal_kembali, @tanggal_transaksi) RETURNING id_transaksi";

            NpgsqlParameter[] parameters = {
                new NpgsqlParameter("@nama", transaksi.Nama),
                new NpgsqlParameter("@nik", transaksi.NIK),
                new NpgsqlParameter("@total_harga", transaksi.TotalHarga),
                new NpgsqlParameter("@tanggal_kembali", transaksi.TanggalKembali),
                new NpgsqlParameter("@tanggal_transaksi", transaksi.TanggalTransaksi)
            };

            return commandExecutorReturnId(query, parameters);
        }

        public void AddDetailTransaksi(DetailTransaksi detail)
        {
            string query = $"INSERT INTO {detailTransaksiTable} (id_transaksi, id_katalog, jumlah) VALUES (@id_transaksi, @id_katalog, @jumlah)";

            NpgsqlParameter[] parameters = {
                new NpgsqlParameter("@id_transaksi", detail.id_transaksi),
                new NpgsqlParameter("@id_katalog", detail.id_katalog),
                new NpgsqlParameter("@jumlah", detail.Jumlah)
            };

            commandExecutor(query, parameters);
        }

        public int GetTotalHargaSum()
        {
            string query = "SELECT SUM (total_harga) FROM transaksi";

            DataTable result = Database.queryExecutor(query);
            return Convert.ToInt32(result.Rows[0][0]);
        }

        public int GetJumlahBarangDisewa()
        {
            string query = @"SELECT 
                SUM(dt.jumlah) AS total_barang_disewa
            FROM 
                detailtransaksi dt
            JOIN 
                transaksi t ON dt.id_transaksi = t.id_transaksi
            WHERE 
                t.tanggal_kembali > CURRENT_DATE";

            DataTable result = Database.queryExecutor(query);
            return result.Rows.Count > 0 && !DBNull.Value.Equals(result.Rows[0][0])
                ? Convert.ToInt32(result.Rows[0][0])
                : 0;
        }
    }
}

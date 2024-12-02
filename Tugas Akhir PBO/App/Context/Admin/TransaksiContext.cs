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
    }
}

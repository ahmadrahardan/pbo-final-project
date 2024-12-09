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

        public List<Transaksi> GetAllTransaksi()
        {
            string query = "SELECT * FROM Transaksi";
            DataTable dt = queryExecutor(query);

            List<Transaksi> transaksiList = new List<Transaksi>();

            foreach (DataRow row in dt.Rows)
            {
                transaksiList.Add(new Transaksi
                {
                    id_transaksi = Convert.ToInt32(row["id_transaksi"]),
                    Nama = row["nama"].ToString(),
                    NIK = row["nik"].ToString(),
                    TotalHarga = Convert.ToDecimal(row["total_harga"]),
                    TanggalKembali = Convert.ToDateTime(row["tanggal_kembali"]),
                    TanggalTransaksi = Convert.ToDateTime(row["tanggal_transaksi"]),
                    Status = row["status"].ToString()
                });
            }

            return transaksiList;
        }

        public int AddTransaksi(Transaksi transaksi)
        {
            string query = $"INSERT INTO {transaksiTable} (nama, nik, total_harga, tanggal_kembali, tanggal_transaksi, status) VALUES (@nama, @nik, @total_harga, @tanggal_kembali, @tanggal_transaksi, @status) RETURNING id_transaksi";

            NpgsqlParameter[] parameters = {
                new NpgsqlParameter("@nama", transaksi.Nama),
                new NpgsqlParameter("@nik", transaksi.NIK),
                new NpgsqlParameter("@total_harga", transaksi.TotalHarga),
                new NpgsqlParameter("@tanggal_kembali", transaksi.TanggalKembali),
                new NpgsqlParameter("@tanggal_transaksi", transaksi.TanggalTransaksi),
                new NpgsqlParameter("@status", transaksi.Status)
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

        public void UpdateStokProduk(int idTransaksi)
        {
            string getDetailsQuery = "SELECT id_katalog, jumlah FROM DetailTransaksi WHERE id_transaksi = @id_transaksi";

            NpgsqlParameter[] getDetailsParams = {new NpgsqlParameter("@id_transaksi", idTransaksi)};

            DataTable detailDataTable = queryExecutor(getDetailsQuery, getDetailsParams);

            foreach (DataRow row in detailDataTable.Rows)
            {
                int idKatalog = Convert.ToInt32(row["id_katalog"]);
                int jumlah = Convert.ToInt32(row["jumlah"]);

                string updateStockQuery = "UPDATE Katalog SET stok = stok + @jumlah WHERE id_katalog = @id_katalog";

                NpgsqlParameter[] updateStockParams = {new NpgsqlParameter("@jumlah", jumlah),new NpgsqlParameter("@id_katalog", idKatalog)};

                commandExecutor(updateStockQuery, updateStockParams);
            }
        }

        public void UpdateStatusToSelesai(int idTransaksi)
        {
            string query = "UPDATE Transaksi SET status = @status WHERE id_transaksi = @id_transaksi";

            NpgsqlParameter[] parameters = {new NpgsqlParameter("@status", "Selesai"),new NpgsqlParameter("@id_transaksi", idTransaksi)};

            commandExecutor(query, parameters);
        }
    }
}

using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tugas_Akhir_PBO.App.Core;
using Tugas_Akhir_PBO.App.Models.Mitra;

namespace Tugas_Akhir_PBO.App.Context.Mitra
{
    internal class mKatalogContext : Database
    {
        private static string table = "Katalog_Mitra";

        public void AddKatalog(mKatalog katalog)
        {
            string query = $"INSERT INTO {table} (nama_produk, harga, stok, id_kategori, gambar) VALUES (@nama_produk, @harga, @stok, @id_kategori, @gambar)";

            NpgsqlParameter[] parameters = {
                new NpgsqlParameter("@nama_produk", katalog.NamaProduk),
                new NpgsqlParameter("@harga", katalog.Harga),
                new NpgsqlParameter("@stok", katalog.Stok),
                new NpgsqlParameter("@id_kategori", katalog.id_kategori),
                new NpgsqlParameter("@gambar", katalog.Gambar)
            };

            commandExecutor(query, parameters);
        }

        public List<mKatalog> GetAllKatalog()
        {
            string query = $"SELECT id_katalog, nama_produk, harga, stok, id_kategori, gambar FROM {table}";
            DataTable dataTable = queryExecutor(query);
            List<mKatalog> katalogList = new List<mKatalog>();

            foreach (DataRow row in dataTable.Rows)
            {
                katalogList.Add(new mKatalog
                {
                    id_katalog = Convert.ToInt32(row["id_katalog"]),
                    NamaProduk = row["nama_produk"].ToString(),
                    Harga = Convert.ToInt32(row["harga"]),
                    Stok = Convert.ToInt32(row["stok"]),
                    id_kategori = Convert.ToInt32(row["id_kategori"]),
                    Gambar = (byte[])row["gambar"]
                });
            }

            return katalogList;
        }

        public void UpdateKatalog(mKatalog katalog)
        {
            string query = $"UPDATE {table} SET nama_produk = @nama_produk, harga = @harga, id_kategori = @id_kategori, gambar = @gambar WHERE id_katalog = @id_katalog";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@nama_produk", katalog.NamaProduk),
                new NpgsqlParameter("@harga", katalog.Harga),
                new NpgsqlParameter("@id_kategori", katalog.id_kategori),
                new NpgsqlParameter("@gambar", katalog.Gambar)
            };

            commandExecutor(query, parameters);
        }

        public static void DeleteKatalog(int id)
        {
            string query = $"DELETE FROM {table} WHERE id_katalog = @id_katalog";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id_katalog", id)
            };

            commandExecutor(query, parameters);
        }
    }
}

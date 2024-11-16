using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tugas_Akhir_PBO.App.Core;
using Tugas_Akhir_PBO.App.Models.Admin;

namespace Tugas_Akhir_PBO.App.Context.Admin
{
    internal class KatalogContext : Database
    {
        private static string table = "produk";

        public void AddKatalog(Katalog katalog)
        {
            string query = $"INSERT INTO {table} (nama, harga, kategori, gambar) VALUES (@nama, @harga, @kategori, @gambar)";

            NpgsqlParameter[] parameters = {
                new NpgsqlParameter("@nama", katalog.Nama),
                new NpgsqlParameter("@harga", katalog.Harga),
                new NpgsqlParameter("@kategori", katalog.id_kategori),
                new NpgsqlParameter("@gambar", katalog.Gambar)
            };

            commandExecutor(query, parameters);
        }

        public void UpdateKatalog(Katalog katalog)
        {
            string query = $"UPDATE {table} SET nama = @nama, harga = @harga, id_kategori = @id_kategori WHERE id = @id";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@nama", katalog.Nama),
                new NpgsqlParameter("@harga", katalog.Harga),
                new NpgsqlParameter("@id_kategori", katalog.id_kategori)
            };

            commandExecutor(query, parameters);
        }

        public static void DeleteKatalog(int id)
        {
            string query = $"DELETE FROM {table} WHERE id = @id";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id", id)
            };

            commandExecutor(query, parameters);
        }
    }
}

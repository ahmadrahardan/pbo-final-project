using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tugas_Akhir_PBO.App.Core;
using Tugas_Akhir_PBO.App.Models.Mitra;

namespace Tugas_Akhir_PBO.App.Context.Mitra
{
    internal class mStokContext : Database
    {
        private static string table = "Katalog_Mitra";

        public static void UpdateStok(int id, int stok)
        {
            string query = $"UPDATE {table} SET stok = @stok WHERE id_katalog = @id_katalog";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@stok", stok),
                new NpgsqlParameter("@id_katalog", id)
            };

            commandExecutor(query, parameters);
        }
    }
}

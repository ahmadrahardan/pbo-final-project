using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tugas_Akhir_PBO.App.Core;
using Tugas_Akhir_PBO.App.Models;

namespace Tugas_Akhir_PBO.App.Context.Admin
{
    internal class KategoriContext : Database
    {
        private static string table = "kategori";

        public static DataTable All()
        {
            string query = $"SELECT * FROM {table}";
            DataTable dataKategori = queryExecutor(query);
            return dataKategori;
        }
    }
}

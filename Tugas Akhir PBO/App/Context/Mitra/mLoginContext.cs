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
    internal class mLoginContext : Database
    {
        public mLogin Validate(string email, string password)
        {
            mLogin loginMitra = null;
            string query = "SELECT * FROM Mitra WHERE email = @email AND password = @password";

            NpgsqlParameter[] parameters = {
                new NpgsqlParameter("@email", email),
                new NpgsqlParameter("@password", password)
            };

            DataTable resultTable = queryExecutor(query, parameters);

            if (resultTable.Rows.Count > 0)
            {
                DataRow row = resultTable.Rows[0];
                loginMitra = new mLogin(email, password)
                {
                    Email = row["email"].ToString(),
                    Password = row["password"].ToString()
                };
            }

            return loginMitra;
        }
    }
}

using Npgsql;
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
    internal class LoginContext : Database
    {
        public Login Validate(string email, string password)
        {
            Login loginAdmin = null;
            string query = "SELECT * FROM Admin WHERE email = @email AND password = @password";

            NpgsqlParameter[] parameters = {
                new NpgsqlParameter("@email", email),
                new NpgsqlParameter("@password", password)
            };

            DataTable resultTable = queryExecutor(query, parameters);

            if (resultTable.Rows.Count > 0)
            {
                DataRow row = resultTable.Rows[0];
                loginAdmin = new Login(email, password)
                {
                    Email = row["email"].ToString(),
                    Password = row["password"].ToString()
                };
            }

            return loginAdmin;
        }
    }
}

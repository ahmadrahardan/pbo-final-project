using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tugas_Akhir_PBO.App.Core;
using Tugas_Akhir_PBO.App.Models;

namespace Tugas_Akhir_PBO.App.Context
{
    internal class LoginContext
    {
        public Login Validate(string email, string password)
        {
            Login loginAdmin = null;
            string query = "SELECT * FROM admin WHERE email = @email AND password = @password";

            NpgsqlParameter[] parameters = {
                new NpgsqlParameter("@email", email),
                new NpgsqlParameter("@password", password)
            };

            DataTable resultTable = Database.queryExecutor(query, parameters);

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

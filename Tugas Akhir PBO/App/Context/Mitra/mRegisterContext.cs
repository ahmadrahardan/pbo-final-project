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
    internal class mRegisterContext : Database
    {
        public bool Register(mRegister register)
        {
            string query = "INSERT INTO Mitra (username, email, password) VALUES (@username, @email, @password)";

            NpgsqlParameter[] parameters = {
                new NpgsqlParameter("@username", register.Username),
                new NpgsqlParameter("@email", register.Email),
                new NpgsqlParameter("@password", register.Password)
            };

            try
            {
                commandExecutor(query, parameters);
                return true;
            }
            catch (NpgsqlException npgsqlEx)
            {
                Console.WriteLine("Database Error: " + npgsqlEx.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }
    }
}

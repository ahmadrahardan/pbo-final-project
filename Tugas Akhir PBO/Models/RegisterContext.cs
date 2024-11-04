using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Tugas_Akhir_PBO.Models;

namespace Tugas_Akhir_PBO.Models
{
    internal class RegisterContext
    {
        private readonly string connStr;
        public RegisterContext()
        {
            connStr = "Server=localhost;Port=5432;Username=postgres;Password=310305;Database=BonsaRental;CommandTimeout=10";
        }

        public bool Register(string username, string email, string password)
        {
            string query = "INSERT INTO admin (username, email, password) VALUES (@username, @email, @password)";
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", password);

                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0; 
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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Akhir_PBO.App.Models.Mitra
{
    internal class mLogin
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public mLogin(string email, string password)
        {
            Email = email;
            Password = password;
        }
    }
}

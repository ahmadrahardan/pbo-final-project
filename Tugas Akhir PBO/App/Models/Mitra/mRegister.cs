﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Akhir_PBO.App.Models.Mitra
{
    internal class mRegister
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public mRegister(string username, string email, string password)
        {
            Username = username;
            Email = email;
            Password = password;
        }
    }
}
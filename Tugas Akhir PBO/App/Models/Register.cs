﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tugas_Akhir_PBO.App.Context;

namespace Tugas_Akhir_PBO.App.Models
{
    internal class Register
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public Register(string username, string email, string password)
        {
            Username = username;
            Email = email;
            Password = password;
        }
    }
}

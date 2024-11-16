using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_Akhir_PBO.View
{
    public partial class LandingPage : Form
    {
        UserControlSplashScreen splashScreen;
        UserControlLogin login;
        UserControlRegister register;
        UserControlDashboard dashboard;
        UserControlStok pengelolaanStok;
        UserControlKatalog pengelolaanProduk;
        UserControlTransaksi transaksi;
        //UCAddProduk addProduk;
        System.Windows.Forms.Timer timer;
        public LandingPage()
        {
            InitializeComponent();
            splashScreen = new UserControlSplashScreen();
            login = new UserControlLogin(this);
            register = new UserControlRegister(this);
            dashboard = new UserControlDashboard(this);
            pengelolaanStok = new UserControlStok(this);
            pengelolaanProduk = new UserControlKatalog(this);
            transaksi = new UserControlTransaksi(this);
            //addProduk = new UCAddProduk(this);

            this.Controls.Add(splashScreen);
            this.Controls.Add(login);
            this.Controls.Add(register);
            this.Controls.Add(dashboard);
            this.Controls.Add(pengelolaanStok);
            this.Controls.Add(pengelolaanProduk);
            this.Controls.Add(transaksi);
            //this.Controls.Add(addProduk);

            HideAllUserControl();
            ShowSplashScreen();


            timer = new System.Windows.Forms.Timer();
            timer.Interval = 3000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            ShowLogin();
        }

        public void HideAllUserControl()
        {
            foreach (UserControl userControl in this.Controls)
            {
                userControl.Visible = false;
            }
        }

        public void ShowSplashScreen()
        {
            HideAllUserControl();
            splashScreen.Visible = true;
        }

        public void ShowLogin()
        {
            HideAllUserControl();
            login.Visible = true;
        }

        public void ShowRegister()
        {
            HideAllUserControl();
            register.Visible = true;
        }

        public void ShowDashboard()
        {
            HideAllUserControl();
            dashboard.Visible = true;
        }

        public void ShowKelolaStok()
        {
            HideAllUserControl();
            pengelolaanStok.Visible = true;
        }

        public void ShowKelolaProduk()
        {
            HideAllUserControl();
            pengelolaanProduk.Visible = true;
        }

        public void ShowTransaksi()
        {
            HideAllUserControl();
            transaksi.Visible = true;
        }

        //public void ShowAddProduk()
        //{
        //    HideAllUserControl();
        //    addProduk.Visible = true;
        //}

        private void LandingPage_Load(object sender, EventArgs e)
        {

        }
    }
}


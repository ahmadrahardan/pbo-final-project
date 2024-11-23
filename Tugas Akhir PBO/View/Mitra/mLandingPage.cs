using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tugas_Akhir_PBO.App.Models.Admin;

namespace Tugas_Akhir_PBO.View.Mitra
{
    public partial class mLandingPage : Form
    {
        mUserControlLogin login;
        mUserControlRegister register;
        mUserControlDashboard dashboard;
        mUserControlStok pengelolaanStok;
        mUserControlKatalog pengelolaanProduk;
        public mLandingPage()
        {
            InitializeComponent();
            login = new mUserControlLogin(this);
            register = new mUserControlRegister(this);
            dashboard = new mUserControlDashboard(this);
            pengelolaanStok = new mUserControlStok(this);
            pengelolaanProduk = new mUserControlKatalog(this, pengelolaanStok);

            this.Controls.Add(login);
            this.Controls.Add(register);
            this.Controls.Add(dashboard);
            this.Controls.Add(pengelolaanStok);
            this.Controls.Add(pengelolaanProduk);

            HideAllUserControl();
            ShowLogin();
        }

        public void HideAllUserControl()
        {
            foreach (UserControl userControl in this.Controls)
            {
                userControl.Visible = false;
            }
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

        private void mLandingPage_Load(object sender, EventArgs e)
        {

        }
    }
}

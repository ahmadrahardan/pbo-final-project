using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tugas_Akhir_PBO.App.Context.Admin;
using Tugas_Akhir_PBO.App.Models.Admin;

namespace Tugas_Akhir_PBO.View.Admin
{
    public partial class UCAddRiwayat : UserControl
    {
        UserControlDashboard UCDashboard;

        public UCAddRiwayat(UserControlDashboard UCDashboard)
        {
            InitializeComponent();
            this.UCDashboard = UCDashboard;
        }

        private void CloseBox_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void UCAddRiwayat_Load(object sender, EventArgs e)
        {

        }
    }
}

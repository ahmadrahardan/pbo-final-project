namespace Tugas_Akhir_PBO.View
{
    partial class UserControlDashboard
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LogoutBox = new PictureBox();
            DashboardBox = new PictureBox();
            StokBox = new PictureBox();
            KatalogBox = new PictureBox();
            TransaksiBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)LogoutBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DashboardBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)StokBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)KatalogBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TransaksiBox).BeginInit();
            SuspendLayout();
            // 
            // LogoutBox
            // 
            LogoutBox.BackColor = Color.Transparent;
            LogoutBox.BackgroundImage = Properties.Resources.Button_Logout;
            LogoutBox.Location = new Point(73, 920);
            LogoutBox.Name = "LogoutBox";
            LogoutBox.Size = new Size(183, 55);
            LogoutBox.TabIndex = 0;
            LogoutBox.TabStop = false;
            LogoutBox.Click += LogoutBox_Click;
            // 
            // DashboardBox
            // 
            DashboardBox.BackColor = Color.Transparent;
            DashboardBox.BackgroundImage = Properties.Resources.Button_DB_OnClick;
            DashboardBox.Location = new Point(73, 210);
            DashboardBox.Name = "DashboardBox";
            DashboardBox.Size = new Size(340, 57);
            DashboardBox.TabIndex = 1;
            DashboardBox.TabStop = false;
            // 
            // StokBox
            // 
            StokBox.BackColor = Color.Transparent;
            StokBox.BackgroundImage = Properties.Resources.Button_ST_Idle;
            StokBox.Location = new Point(73, 280);
            StokBox.Name = "StokBox";
            StokBox.Size = new Size(340, 57);
            StokBox.TabIndex = 2;
            StokBox.TabStop = false;
            StokBox.Click += btnPengelolaanStok_Click;
            // 
            // KatalogBox
            // 
            KatalogBox.BackColor = Color.Transparent;
            KatalogBox.BackgroundImage = Properties.Resources.Button_KT_Idle;
            KatalogBox.Location = new Point(73, 350);
            KatalogBox.Name = "KatalogBox";
            KatalogBox.Size = new Size(340, 57);
            KatalogBox.TabIndex = 3;
            KatalogBox.TabStop = false;
            KatalogBox.Click += btnPengelolaanProduk_Click;
            // 
            // TransaksiBox
            // 
            TransaksiBox.BackColor = Color.Transparent;
            TransaksiBox.BackgroundImage = Properties.Resources.Button_TR_Idle;
            TransaksiBox.Location = new Point(73, 420);
            TransaksiBox.Name = "TransaksiBox";
            TransaksiBox.Size = new Size(340, 57);
            TransaksiBox.TabIndex = 4;
            TransaksiBox.TabStop = false;
            TransaksiBox.Click += btnTransaksi_Click;
            // 
            // UserControlDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Dashboard_No_Panel__2_;
            Controls.Add(TransaksiBox);
            Controls.Add(KatalogBox);
            Controls.Add(StokBox);
            Controls.Add(DashboardBox);
            Controls.Add(LogoutBox);
            Name = "UserControlDashboard";
            Size = new Size(1920, 1080);
            Load += UserControlDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)LogoutBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)DashboardBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)StokBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)KatalogBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)TransaksiBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox LogoutBox;
        private PictureBox DashboardBox;
        private PictureBox StokBox;
        private PictureBox KatalogBox;
        private PictureBox TransaksiBox;
    }
}

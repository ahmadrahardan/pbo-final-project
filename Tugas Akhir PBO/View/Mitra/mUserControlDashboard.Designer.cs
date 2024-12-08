namespace Tugas_Akhir_PBO.View.Mitra
{
    partial class mUserControlDashboard
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
            DashboardBox = new PictureBox();
            StokBox = new PictureBox();
            KatalogBox = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)DashboardBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)StokBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)KatalogBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // DashboardBox
            // 
            DashboardBox.BackColor = Color.Transparent;
            DashboardBox.BackgroundImage = Properties.Resources.Button_DB_OnClick;
            DashboardBox.Location = new Point(73, 210);
            DashboardBox.Name = "DashboardBox";
            DashboardBox.Size = new Size(340, 57);
            DashboardBox.TabIndex = 0;
            DashboardBox.TabStop = false;
            // 
            // StokBox
            // 
            StokBox.BackColor = Color.Transparent;
            StokBox.BackgroundImage = Properties.Resources.Button_ST_Idle;
            StokBox.Location = new Point(73, 280);
            StokBox.Name = "StokBox";
            StokBox.Size = new Size(340, 57);
            StokBox.TabIndex = 1;
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
            KatalogBox.TabIndex = 2;
            KatalogBox.TabStop = false;
            KatalogBox.Click += btnPengelolaanProduk_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.Button_Logout;
            pictureBox1.Location = new Point(73, 920);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(183, 55);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += LogoutBox_Click;
            // 
            // mUserControlDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Dashboard_No_Panel__3_;
            Controls.Add(pictureBox1);
            Controls.Add(KatalogBox);
            Controls.Add(StokBox);
            Controls.Add(DashboardBox);
            Name = "mUserControlDashboard";
            Size = new Size(1920, 1080);
            Load += mUserControlDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)DashboardBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)StokBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)KatalogBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox DashboardBox;
        private PictureBox StokBox;
        private PictureBox KatalogBox;
        private PictureBox pictureBox1;
    }
}

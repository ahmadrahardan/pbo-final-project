namespace Tugas_Akhir_PBO.View.Mitra
{
    partial class mUserControlKatalog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mUserControlKatalog));
            DashboardBox = new PictureBox();
            StokBox = new PictureBox();
            KatalogBox = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)DashboardBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)StokBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)KatalogBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // DashboardBox
            // 
            DashboardBox.BackColor = Color.Transparent;
            DashboardBox.BackgroundImage = Properties.Resources.Button_DB_Idle;
            DashboardBox.Location = new Point(73, 210);
            DashboardBox.Name = "DashboardBox";
            DashboardBox.Size = new Size(340, 57);
            DashboardBox.TabIndex = 0;
            DashboardBox.TabStop = false;
            DashboardBox.Click += btnDashboard_Click;
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
            KatalogBox.BackgroundImage = Properties.Resources.Button_KT_OnClick;
            KatalogBox.Location = new Point(73, 350);
            KatalogBox.Name = "KatalogBox";
            KatalogBox.Size = new Size(340, 57);
            KatalogBox.TabIndex = 2;
            KatalogBox.TabStop = false;
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
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.Location = new Point(1379, 86);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(477, 52);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            pictureBox2.Click += btnAddProduk_Click;
            // 
            // mUserControlKatalog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Mitra_Katalog_No_Panel;
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(KatalogBox);
            Controls.Add(StokBox);
            Controls.Add(DashboardBox);
            Name = "mUserControlKatalog";
            Size = new Size(1920, 1080);
            Load += mUserControlKatalog_Load;
            ((System.ComponentModel.ISupportInitialize)DashboardBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)StokBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)KatalogBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox DashboardBox;
        private PictureBox StokBox;
        private PictureBox KatalogBox;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}

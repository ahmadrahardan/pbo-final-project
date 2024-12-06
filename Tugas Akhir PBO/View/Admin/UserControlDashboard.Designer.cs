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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlDashboard));
            LogoutBox = new PictureBox();
            DashboardBox = new PictureBox();
            StokBox = new PictureBox();
            KatalogBox = new PictureBox();
            TransaksiBox = new PictureBox();
            DGVriwayat = new DataGridView();
            pictureBox_sedangdisewa = new PictureBox();
            pictureBox_barang = new PictureBox();
            pictureBox_totalpenghasilan = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)LogoutBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DashboardBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)StokBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)KatalogBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TransaksiBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGVriwayat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_sedangdisewa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_barang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_totalpenghasilan).BeginInit();
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
            // DGVriwayat
            // 
            DGVriwayat.AllowUserToResizeColumns = false;
            DGVriwayat.AllowUserToResizeRows = false;
            DGVriwayat.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ControlDark;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DGVriwayat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DGVriwayat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DGVriwayat.DefaultCellStyle = dataGridViewCellStyle2;
            DGVriwayat.GridColor = Color.White;
            DGVriwayat.Location = new Point(474, 490);
            DGVriwayat.Name = "DGVriwayat";
            DGVriwayat.RowHeadersWidth = 51;
            DGVriwayat.Size = new Size(1356, 230);
            DGVriwayat.TabIndex = 5;
            // 
            // pictureBox_sedangdisewa
            // 
            pictureBox_sedangdisewa.BackColor = Color.Transparent;
            pictureBox_sedangdisewa.BackgroundImage = Properties.Resources.True_SedangDisewa;
            pictureBox_sedangdisewa.Location = new Point(474, 210);
            pictureBox_sedangdisewa.Name = "pictureBox_sedangdisewa";
            pictureBox_sedangdisewa.Size = new Size(419, 227);
            pictureBox_sedangdisewa.TabIndex = 6;
            pictureBox_sedangdisewa.TabStop = false;
            // 
            // pictureBox_barang
            // 
            pictureBox_barang.BackColor = Color.Transparent;
            pictureBox_barang.BackgroundImage = Properties.Resources.True_TotalKatalog;
            pictureBox_barang.Location = new Point(942, 210);
            pictureBox_barang.Name = "pictureBox_barang";
            pictureBox_barang.Size = new Size(419, 227);
            pictureBox_barang.TabIndex = 7;
            pictureBox_barang.TabStop = false;
            // 
            // pictureBox_totalpenghasilan
            // 
            pictureBox_totalpenghasilan.BackColor = Color.Transparent;
            pictureBox_totalpenghasilan.BackgroundImage = Properties.Resources.True_TotalPenghasilan;
            pictureBox_totalpenghasilan.Location = new Point(1411, 210);
            pictureBox_totalpenghasilan.Name = "pictureBox_totalpenghasilan";
            pictureBox_totalpenghasilan.Size = new Size(419, 227);
            pictureBox_totalpenghasilan.TabIndex = 8;
            pictureBox_totalpenghasilan.TabStop = false;
            // 
            // UserControlDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(pictureBox_totalpenghasilan);
            Controls.Add(pictureBox_barang);
            Controls.Add(pictureBox_sedangdisewa);
            Controls.Add(DGVriwayat);
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
            ((System.ComponentModel.ISupportInitialize)DGVriwayat).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_sedangdisewa).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_barang).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_totalpenghasilan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox LogoutBox;
        private PictureBox DashboardBox;
        private PictureBox StokBox;
        private PictureBox KatalogBox;
        private PictureBox TransaksiBox;
        private DataGridView DGVriwayat;
        private PictureBox pictureBox_sedangdisewa;
        private PictureBox pictureBox_barang;
        private PictureBox pictureBox_totalpenghasilan;
    }
}

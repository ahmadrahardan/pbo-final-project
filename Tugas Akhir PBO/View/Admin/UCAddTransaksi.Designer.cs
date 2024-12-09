namespace Tugas_Akhir_PBO.View.Admin
{
    partial class UCAddTransaksi
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
            pictureBox1 = new PictureBox();
            BayarBox = new TextBox();
            pictureBox2 = new PictureBox();
            TanggalKembaliBox = new TextBox();
            NIKBox = new TextBox();
            NamaBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.CETAK_STRUK;
            pictureBox1.Location = new Point(503, 620);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(277, 47);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += CetakStruk_Click;
            // 
            // BayarBox
            // 
            BayarBox.BorderStyle = BorderStyle.None;
            BayarBox.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BayarBox.Location = new Point(450, 476);
            BayarBox.Name = "BayarBox";
            BayarBox.Size = new Size(380, 23);
            BayarBox.TabIndex = 3;
            BayarBox.TextChanged += BayarBox_TextChanged;
            BayarBox.KeyPress += BayarBox_KeyPress;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.Button_close1;
            pictureBox2.Location = new Point(1200, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(80, 40);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            pictureBox2.Click += CloseBox_Click;
            // 
            // TanggalKembaliBox
            // 
            TanggalKembaliBox.BorderStyle = BorderStyle.None;
            TanggalKembaliBox.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TanggalKembaliBox.Location = new Point(450, 320);
            TanggalKembaliBox.Name = "TanggalKembaliBox";
            TanggalKembaliBox.Size = new Size(380, 23);
            TanggalKembaliBox.TabIndex = 5;
            TanggalKembaliBox.TextChanged += TanggalKembaliBox_TextChanged;
            // 
            // NIKBox
            // 
            NIKBox.BorderStyle = BorderStyle.None;
            NIKBox.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NIKBox.Location = new Point(450, 234);
            NIKBox.Name = "NIKBox";
            NIKBox.Size = new Size(380, 23);
            NIKBox.TabIndex = 6;
            // 
            // NamaBox
            // 
            NamaBox.BorderStyle = BorderStyle.None;
            NamaBox.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NamaBox.Location = new Point(450, 143);
            NamaBox.Name = "NamaBox";
            NamaBox.Size = new Size(380, 23);
            NamaBox.TabIndex = 7;
            // 
            // UCAddTransaksi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.FORM_TRANSAKSI;
            Controls.Add(NamaBox);
            Controls.Add(NIKBox);
            Controls.Add(TanggalKembaliBox);
            Controls.Add(pictureBox2);
            Controls.Add(BayarBox);
            Controls.Add(pictureBox1);
            Location = new Point(320, 180);
            Name = "UCAddTransaksi";
            Size = new Size(1280, 720);
            Load += UCAddTransaksi_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox BayarBox;
        private PictureBox pictureBox2;
        private TextBox TanggalKembaliBox;
        private TextBox NIKBox;
        private TextBox NamaBox;
    }
}

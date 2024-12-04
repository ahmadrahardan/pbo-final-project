namespace Tugas_Akhir_PBO.View
{
    partial class UCAddProduk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCAddProduk));
            KategoriBox = new ComboBox();
            NamaProdukBox = new TextBox();
            HargaProdukBox = new TextBox();
            UppicBox = new PictureBox();
            DoneBox = new PictureBox();
            pictureBox = new PictureBox();
            closeBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)UppicBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DoneBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)closeBox).BeginInit();
            SuspendLayout();
            // 
            // KategoriBox
            // 
            KategoriBox.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KategoriBox.ForeColor = Color.Black;
            KategoriBox.FormattingEnabled = true;
            KategoriBox.Location = new Point(430, 533);
            KategoriBox.Name = "KategoriBox";
            KategoriBox.Size = new Size(424, 34);
            KategoriBox.TabIndex = 0;
            KategoriBox.SelectedIndexChanged += KategoriBox_SelectedIndexChanged;
            // 
            // NamaProdukBox
            // 
            NamaProdukBox.BorderStyle = BorderStyle.None;
            NamaProdukBox.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NamaProdukBox.Location = new Point(450, 365);
            NamaProdukBox.Name = "NamaProdukBox";
            NamaProdukBox.Size = new Size(380, 23);
            NamaProdukBox.TabIndex = 1;
            NamaProdukBox.TextChanged += NamaProdukBox_TextChanged;
            // 
            // HargaProdukBox
            // 
            HargaProdukBox.BorderStyle = BorderStyle.None;
            HargaProdukBox.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HargaProdukBox.Location = new Point(450, 455);
            HargaProdukBox.Name = "HargaProdukBox";
            HargaProdukBox.Size = new Size(380, 23);
            HargaProdukBox.TabIndex = 2;
            HargaProdukBox.TextChanged += HargaProdukBox_TextChanged;
            // 
            // UppicBox
            // 
            UppicBox.BackColor = Color.Transparent;
            UppicBox.BackgroundImage = Properties.Resources.Button_UploadGambar;
            UppicBox.Location = new Point(433, 258);
            UppicBox.Name = "UppicBox";
            UppicBox.Size = new Size(347, 47);
            UppicBox.TabIndex = 3;
            UppicBox.TabStop = false;
            UppicBox.Click += UppicBox_Click;
            // 
            // DoneBox
            // 
            DoneBox.BackColor = Color.Transparent;
            DoneBox.BackgroundImage = Properties.Resources.Buttton_Selesai;
            DoneBox.Location = new Point(433, 619);
            DoneBox.Name = "DoneBox";
            DoneBox.Size = new Size(347, 47);
            DoneBox.TabIndex = 4;
            DoneBox.TabStop = false;
            DoneBox.Click += DoneBox_Click;
            // 
            // pictureBox
            // 
            pictureBox.BackColor = Color.Transparent;
            pictureBox.Location = new Point(563, 82);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(154, 151);
            pictureBox.TabIndex = 5;
            pictureBox.TabStop = false;
            pictureBox.Click += pictureBox_Click;
            // 
            // closeBox
            // 
            closeBox.BackColor = Color.Transparent;
            closeBox.BackgroundImage = Properties.Resources.Button_close;
            closeBox.Location = new Point(1200, 0);
            closeBox.Name = "closeBox";
            closeBox.Size = new Size(80, 40);
            closeBox.TabIndex = 6;
            closeBox.TabStop = false;
            closeBox.Click += CloseBox_Click;
            // 
            // UCAddProduk
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(closeBox);
            Controls.Add(pictureBox);
            Controls.Add(DoneBox);
            Controls.Add(UppicBox);
            Controls.Add(HargaProdukBox);
            Controls.Add(NamaProdukBox);
            Controls.Add(KategoriBox);
            Location = new Point(320, 180);
            Name = "UCAddProduk";
            Size = new Size(1280, 720);
            Load += UCAddProduk_Load;
            ((System.ComponentModel.ISupportInitialize)UppicBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)DoneBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)closeBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox KategoriBox;
        private TextBox NamaProdukBox;
        private TextBox HargaProdukBox;
        private PictureBox UppicBox;
        private PictureBox DoneBox;
        private PictureBox pictureBox;
        private PictureBox closeBox;
    }
}

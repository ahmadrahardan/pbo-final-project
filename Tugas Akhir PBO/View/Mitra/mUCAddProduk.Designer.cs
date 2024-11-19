namespace Tugas_Akhir_PBO.View.Mitra
{
    partial class mUCAddProduk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mUCAddProduk));
            pictureBox = new PictureBox();
            UppicBox = new PictureBox();
            DoneBox = new PictureBox();
            NamaProdukBox = new TextBox();
            HargaProdukBox = new TextBox();
            KategoriBox = new ComboBox();
            closeBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UppicBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DoneBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)closeBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.BackColor = Color.Transparent;
            pictureBox.Location = new Point(563, 82);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(154, 151);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // UppicBox
            // 
            UppicBox.BackColor = Color.Transparent;
            UppicBox.BackgroundImage = (Image)resources.GetObject("UppicBox.BackgroundImage");
            UppicBox.Location = new Point(433, 258);
            UppicBox.Name = "UppicBox";
            UppicBox.Size = new Size(347, 47);
            UppicBox.TabIndex = 1;
            UppicBox.TabStop = false;
            UppicBox.Click += UppicBox_Click;
            // 
            // DoneBox
            // 
            DoneBox.BackColor = Color.Transparent;
            DoneBox.BackgroundImage = (Image)resources.GetObject("DoneBox.BackgroundImage");
            DoneBox.Location = new Point(433, 619);
            DoneBox.Name = "DoneBox";
            DoneBox.Size = new Size(347, 47);
            DoneBox.TabIndex = 2;
            DoneBox.TabStop = false;
            DoneBox.Click += DoneBox_Click;
            // 
            // NamaProdukBox
            // 
            NamaProdukBox.BorderStyle = BorderStyle.None;
            NamaProdukBox.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NamaProdukBox.Location = new Point(450, 365);
            NamaProdukBox.Name = "NamaProdukBox";
            NamaProdukBox.Size = new Size(380, 23);
            NamaProdukBox.TabIndex = 3;
            // 
            // HargaProdukBox
            // 
            HargaProdukBox.BorderStyle = BorderStyle.None;
            HargaProdukBox.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HargaProdukBox.Location = new Point(450, 455);
            HargaProdukBox.Name = "HargaProdukBox";
            HargaProdukBox.Size = new Size(380, 23);
            HargaProdukBox.TabIndex = 4;
            // 
            // KategoriBox
            // 
            KategoriBox.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KategoriBox.FormattingEnabled = true;
            KategoriBox.Location = new Point(430, 533);
            KategoriBox.Name = "KategoriBox";
            KategoriBox.Size = new Size(424, 34);
            KategoriBox.TabIndex = 5;
            // 
            // closeBox
            // 
            closeBox.BackColor = Color.Transparent;
            closeBox.BackgroundImage = (Image)resources.GetObject("closeBox.BackgroundImage");
            closeBox.Location = new Point(1234, 13);
            closeBox.Name = "closeBox";
            closeBox.Size = new Size(35, 35);
            closeBox.TabIndex = 6;
            closeBox.TabStop = false;
            closeBox.Click += CloseBox_Click;
            // 
            // mUCAddProduk
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(closeBox);
            Controls.Add(KategoriBox);
            Controls.Add(HargaProdukBox);
            Controls.Add(NamaProdukBox);
            Controls.Add(DoneBox);
            Controls.Add(UppicBox);
            Controls.Add(pictureBox);
            Location = new Point(320, 180);
            Name = "mUCAddProduk";
            Size = new Size(1280, 720);
            Load += mUCAddProduk_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)UppicBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)DoneBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)closeBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox;
        private PictureBox UppicBox;
        private PictureBox DoneBox;
        private TextBox NamaProdukBox;
        private TextBox HargaProdukBox;
        private ComboBox KategoriBox;
        private PictureBox closeBox;
    }
}

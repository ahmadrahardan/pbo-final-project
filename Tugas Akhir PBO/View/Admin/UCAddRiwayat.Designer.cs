namespace Tugas_Akhir_PBO.View.Admin
{
    partial class UCAddRiwayat
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
            dataGridViewRiwayat = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRiwayat).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.Button_Kembali;
            pictureBox1.Location = new Point(1579, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(206, 53);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += CloseBox_Click;
            // 
            // dataGridViewRiwayat
            // 
            dataGridViewRiwayat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRiwayat.Location = new Point(126, 152);
            dataGridViewRiwayat.Name = "dataGridViewRiwayat";
            dataGridViewRiwayat.RowHeadersWidth = 51;
            dataGridViewRiwayat.Size = new Size(1659, 823);
            dataGridViewRiwayat.TabIndex = 1;
            dataGridViewRiwayat.CellContentClick += dataGridViewRiwayat_CellClick;
            // 
            // UCAddRiwayat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Riwayat1;
            Controls.Add(dataGridViewRiwayat);
            Controls.Add(pictureBox1);
            Name = "UCAddRiwayat";
            Size = new Size(1920, 1080);
            Load += UCAddRiwayat_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRiwayat).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private DataGridView dataGridViewRiwayat;
    }
}

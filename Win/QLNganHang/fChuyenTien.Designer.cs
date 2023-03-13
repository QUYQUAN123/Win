namespace QLNganHang
{
    partial class fChuyenTien
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnChuyen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbTkChuyen = new System.Windows.Forms.TextBox();
            this.txbSoTienChuyen = new System.Windows.Forms.TextBox();
            this.gvChuyentien = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txbTkNhan = new System.Windows.Forms.TextBox();
            this.btnKiemTra = new System.Windows.Forms.Button();
            this.gvNhanTien = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvChuyentien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhanTien)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChuyen
            // 
            this.btnChuyen.Location = new System.Drawing.Point(429, 328);
            this.btnChuyen.Name = "btnChuyen";
            this.btnChuyen.Size = new System.Drawing.Size(104, 40);
            this.btnChuyen.TabIndex = 0;
            this.btnChuyen.Text = "Chuyen";
            this.btnChuyen.UseVisualStyleBackColor = true;
            this.btnChuyen.Click += new System.EventHandler(this.btnChuyen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tai Khoan Chuyen Tien";
            // 
            // txbTkChuyen
            // 
            this.txbTkChuyen.Location = new System.Drawing.Point(182, 249);
            this.txbTkChuyen.Name = "txbTkChuyen";
            this.txbTkChuyen.Size = new System.Drawing.Size(182, 22);
            this.txbTkChuyen.TabIndex = 2;
            // 
            // txbSoTienChuyen
            // 
            this.txbSoTienChuyen.Location = new System.Drawing.Point(182, 346);
            this.txbSoTienChuyen.Name = "txbSoTienChuyen";
            this.txbSoTienChuyen.Size = new System.Drawing.Size(182, 22);
            this.txbSoTienChuyen.TabIndex = 3;
            // 
            // gvChuyentien
            // 
            this.gvChuyentien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvChuyentien.Location = new System.Drawing.Point(16, 52);
            this.gvChuyentien.Name = "gvChuyentien";
            this.gvChuyentien.RowHeadersWidth = 51;
            this.gvChuyentien.RowTemplate.Height = 24;
            this.gvChuyentien.Size = new System.Drawing.Size(338, 150);
            this.gvChuyentien.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tai Khoan Nhan Tien";
            // 
            // txbTkNhan
            // 
            this.txbTkNhan.Location = new System.Drawing.Point(182, 294);
            this.txbTkNhan.Name = "txbTkNhan";
            this.txbTkNhan.Size = new System.Drawing.Size(182, 22);
            this.txbTkNhan.TabIndex = 7;
            // 
            // btnKiemTra
            // 
            this.btnKiemTra.Location = new System.Drawing.Point(429, 249);
            this.btnKiemTra.Name = "btnKiemTra";
            this.btnKiemTra.Size = new System.Drawing.Size(104, 46);
            this.btnKiemTra.TabIndex = 8;
            this.btnKiemTra.Text = "KiemTra";
            this.btnKiemTra.UseVisualStyleBackColor = true;
            this.btnKiemTra.Click += new System.EventHandler(this.btnKiemTra_Click);
            // 
            // gvNhanTien
            // 
            this.gvNhanTien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvNhanTien.Location = new System.Drawing.Point(389, 52);
            this.gvNhanTien.Name = "gvNhanTien";
            this.gvNhanTien.RowHeadersWidth = 51;
            this.gvNhanTien.RowTemplate.Height = 24;
            this.gvNhanTien.Size = new System.Drawing.Size(374, 150);
            this.gvNhanTien.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "So Tien Can Chuyen";
            // 
            // fChuyenTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gvNhanTien);
            this.Controls.Add(this.btnKiemTra);
            this.Controls.Add(this.txbTkNhan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gvChuyentien);
            this.Controls.Add(this.txbSoTienChuyen);
            this.Controls.Add(this.txbTkChuyen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChuyen);
            this.Name = "fChuyenTien";
            this.Text = "fChuyenTien";
            this.Load += new System.EventHandler(this.fChuyenTien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvChuyentien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhanTien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChuyen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbTkChuyen;
        private System.Windows.Forms.TextBox txbSoTienChuyen;
        private System.Windows.Forms.DataGridView gvChuyentien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbTkNhan;
        private System.Windows.Forms.Button btnKiemTra;
        private System.Windows.Forms.DataGridView gvNhanTien;
        private System.Windows.Forms.Label label3;
    }
}

namespace QLNganHang
{
    partial class ThongTinSoTietKiem
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
            this.btnDKMoSoTK = new System.Windows.Forms.Button();
            this.btnGuiTien = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.tbxMaKH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gridviewThanhToan = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewThanhToan)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDKMoSoTK
            // 
            this.btnDKMoSoTK.Location = new System.Drawing.Point(148, 510);
            this.btnDKMoSoTK.Name = "btnDKMoSoTK";
            this.btnDKMoSoTK.Size = new System.Drawing.Size(183, 64);
            this.btnDKMoSoTK.TabIndex = 66;
            this.btnDKMoSoTK.Text = "Đăng ký mở sổ";
            this.btnDKMoSoTK.UseVisualStyleBackColor = true;
            this.btnDKMoSoTK.Click += new System.EventHandler(this.btnDKMoSoTK_Click_1);
            // 
            // btnGuiTien
            // 
            this.btnGuiTien.Location = new System.Drawing.Point(446, 510);
            this.btnGuiTien.Name = "btnGuiTien";
            this.btnGuiTien.Size = new System.Drawing.Size(183, 64);
            this.btnGuiTien.TabIndex = 65;
            this.btnGuiTien.Text = "Nộp tiền vào sổ";
            this.btnGuiTien.UseVisualStyleBackColor = true;
            this.btnGuiTien.Click += new System.EventHandler(this.btnGuiTien_Click_1);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(753, 510);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(183, 64);
            this.btnThanhToan.TabIndex = 64;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(500, 56);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(176, 35);
            this.btnTimKiem.TabIndex = 63;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click_1);
            // 
            // tbxMaKH
            // 
            this.tbxMaKH.Location = new System.Drawing.Point(148, 55);
            this.tbxMaKH.Name = "tbxMaKH";
            this.tbxMaKH.Size = new System.Drawing.Size(302, 31);
            this.tbxMaKH.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 61;
            this.label2.Text = "Mã KH:";
            // 
            // gridviewThanhToan
            // 
            this.gridviewThanhToan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewThanhToan.Location = new System.Drawing.Point(51, 119);
            this.gridviewThanhToan.Name = "gridviewThanhToan";
            this.gridviewThanhToan.RowHeadersWidth = 82;
            this.gridviewThanhToan.RowTemplate.Height = 33;
            this.gridviewThanhToan.Size = new System.Drawing.Size(990, 342);
            this.gridviewThanhToan.TabIndex = 60;
            // 
            // ThongTinSoTietKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 621);
            this.Controls.Add(this.btnDKMoSoTK);
            this.Controls.Add(this.btnGuiTien);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.tbxMaKH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridviewThanhToan);
            this.Name = "ThongTinSoTietKiem";
            this.Text = "ThongTinSoTietKiem";
            ((System.ComponentModel.ISupportInitialize)(this.gridviewThanhToan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDKMoSoTK;
        private System.Windows.Forms.Button btnGuiTien;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox tbxMaKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridviewThanhToan;
    }
}
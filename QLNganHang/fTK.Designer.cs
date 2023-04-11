
namespace QLNganHang
{
    partial class fTK
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
            this.btnTatToan = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnDKSoTK = new System.Windows.Forms.Button();
            this.btnGuiTien = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTatToan
            // 
            this.btnTatToan.Location = new System.Drawing.Point(455, 291);
            this.btnTatToan.Name = "btnTatToan";
            this.btnTatToan.Size = new System.Drawing.Size(210, 83);
            this.btnTatToan.TabIndex = 5;
            this.btnTatToan.Text = "Tất Toán";
            this.btnTatToan.UseVisualStyleBackColor = true;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(455, 98);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(210, 83);
            this.btnThanhToan.TabIndex = 4;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            // 
            // btnDKSoTK
            // 
            this.btnDKSoTK.Location = new System.Drawing.Point(101, 98);
            this.btnDKSoTK.Name = "btnDKSoTK";
            this.btnDKSoTK.Size = new System.Drawing.Size(210, 83);
            this.btnDKSoTK.TabIndex = 3;
            this.btnDKSoTK.Text = "Đăng Ký Mở Sổ";
            this.btnDKSoTK.UseVisualStyleBackColor = true;
            this.btnDKSoTK.Click += new System.EventHandler(this.btnDKSoTK_Click);
            // 
            // btnGuiTien
            // 
            this.btnGuiTien.Location = new System.Drawing.Point(101, 291);
            this.btnGuiTien.Name = "btnGuiTien";
            this.btnGuiTien.Size = new System.Drawing.Size(210, 83);
            this.btnGuiTien.TabIndex = 6;
            this.btnGuiTien.Text = "Gửi Tiền Vào Sổ";
            this.btnGuiTien.UseVisualStyleBackColor = true;
            this.btnGuiTien.Click += new System.EventHandler(this.btnGuiTien_Click);
            // 
            // fTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 463);
            this.Controls.Add(this.btnGuiTien);
            this.Controls.Add(this.btnTatToan);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnDKSoTK);
            this.Name = "fTK";
            this.Text = "fTK";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTatToan;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnDKSoTK;
        private System.Windows.Forms.Button btnGuiTien;
    }
}
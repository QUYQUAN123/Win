namespace QLNganHang
{
    partial class fTinDung
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
            this.gvKhachHang = new System.Windows.Forms.DataGridView();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTaoTinDung = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // gvKhachHang
            // 
            this.gvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvKhachHang.Location = new System.Drawing.Point(12, 31);
            this.gvKhachHang.Name = "gvKhachHang";
            this.gvKhachHang.RowHeadersWidth = 51;
            this.gvKhachHang.RowTemplate.Height = 24;
            this.gvKhachHang.Size = new System.Drawing.Size(543, 185);
            this.gvKhachHang.TabIndex = 0;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(109, 241);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(327, 22);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tim kiem";
            // 
            // btnTaoTinDung
            // 
            this.btnTaoTinDung.Location = new System.Drawing.Point(468, 241);
            this.btnTaoTinDung.Name = "btnTaoTinDung";
            this.btnTaoTinDung.Size = new System.Drawing.Size(97, 22);
            this.btnTaoTinDung.TabIndex = 3;
            this.btnTaoTinDung.Text = "Tao tin dung";
            this.btnTaoTinDung.UseVisualStyleBackColor = true;
            this.btnTaoTinDung.Click += new System.EventHandler(this.btnTaoTinDung_Click);
            // 
            // fTinDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 300);
            this.Controls.Add(this.btnTaoTinDung);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.gvKhachHang);
            this.Name = "fTinDung";
            this.Text = "fTinDung";
            this.Load += new System.EventHandler(this.fTinDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvKhachHang;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTaoTinDung;
    }
}
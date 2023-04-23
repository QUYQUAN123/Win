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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.gvTinDung = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnKiemTra = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMaTD = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtThuNhap = new System.Windows.Forms.TextBox();
            this.txtCccd = new System.Windows.Forms.TextBox();
            this.cmbLoaiThe = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbHanMuc = new System.Windows.Forms.ComboBox();
            this.txtNoTD = new System.Windows.Forms.TextBox();
            this.cmbLaiXuat = new System.Windows.Forms.ComboBox();
            this.txtNoXau = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoLan = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvTinDung)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Location = new System.Drawing.Point(577, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(142, 170);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(31, 105);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(85, 36);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xoa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(31, 61);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(85, 34);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sua";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(31, 18);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(85, 35);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Them";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // gvTinDung
            // 
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            this.gvTinDung.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvTinDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTinDung.Location = new System.Drawing.Point(9, 487);
            this.gvTinDung.Name = "gvTinDung";
            this.gvTinDung.RowHeadersWidth = 51;
            this.gvTinDung.RowTemplate.Height = 24;
            this.gvTinDung.Size = new System.Drawing.Size(574, 140);
            this.gvTinDung.TabIndex = 3;
            this.gvTinDung.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvTinDung_CellContentClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 421);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 16);
            this.label12.TabIndex = 26;
            this.label12.Text = "Tim kiem";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(137, 415);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(327, 22);
            this.txtTimKiem.TabIndex = 27;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnThanhToan);
            this.groupBox3.Controls.Add(this.btnKiemTra);
            this.groupBox3.Location = new System.Drawing.Point(577, 226);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(142, 187);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(31, 68);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(91, 45);
            this.btnThanhToan.TabIndex = 1;
            this.btnThanhToan.Text = "Thanh toan tin dung";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnKiemTra
            // 
            this.btnKiemTra.Location = new System.Drawing.Point(31, 19);
            this.btnKiemTra.Name = "btnKiemTra";
            this.btnKiemTra.Size = new System.Drawing.Size(91, 43);
            this.btnKiemTra.TabIndex = 0;
            this.btnKiemTra.Text = "Kiem tra tin dung";
            this.btnKiemTra.UseVisualStyleBackColor = true;
            this.btnKiemTra.Click += new System.EventHandler(this.btnKiemTra_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ma tin dung";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(0, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ten khach hang";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(0, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Thu Nhap";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.OrangeRed;
            this.label5.Location = new System.Drawing.Point(3, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Cccd";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.OrangeRed;
            this.label6.Location = new System.Drawing.Point(3, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Loai the";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.OrangeRed;
            this.label7.Location = new System.Drawing.Point(372, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Ngay tra";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.OrangeRed;
            this.label8.Location = new System.Drawing.Point(209, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Lai xuat tin dung";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.OrangeRed;
            this.label9.Location = new System.Drawing.Point(209, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "No tin dung";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.OrangeRed;
            this.label10.Location = new System.Drawing.Point(209, 185);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 16);
            this.label10.TabIndex = 8;
            this.label10.Text = "No xau";
            // 
            // txtMaTD
            // 
            this.txtMaTD.Location = new System.Drawing.Point(3, 54);
            this.txtMaTD.Name = "txtMaTD";
            this.txtMaTD.Size = new System.Drawing.Size(144, 22);
            this.txtMaTD.TabIndex = 10;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(3, 99);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(144, 22);
            this.txtTenKH.TabIndex = 11;
            // 
            // txtThuNhap
            // 
            this.txtThuNhap.Location = new System.Drawing.Point(3, 146);
            this.txtThuNhap.Name = "txtThuNhap";
            this.txtThuNhap.Size = new System.Drawing.Size(144, 22);
            this.txtThuNhap.TabIndex = 12;
            // 
            // txtCccd
            // 
            this.txtCccd.Location = new System.Drawing.Point(0, 204);
            this.txtCccd.Name = "txtCccd";
            this.txtCccd.Size = new System.Drawing.Size(144, 22);
            this.txtCccd.TabIndex = 13;
            // 
            // cmbLoaiThe
            // 
            this.cmbLoaiThe.FormattingEnabled = true;
            this.cmbLoaiThe.Items.AddRange(new object[] {
            "Kim cuong",
            "Vang",
            "Bac"});
            this.cmbLoaiThe.Location = new System.Drawing.Point(3, 259);
            this.cmbLoaiThe.Name = "cmbLoaiThe";
            this.cmbLoaiThe.Size = new System.Drawing.Size(144, 24);
            this.cmbLoaiThe.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.Color.OrangeRed;
            this.label11.Location = new System.Drawing.Point(209, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 16);
            this.label11.TabIndex = 15;
            this.label11.Text = "Han muc";
            // 
            // cmbHanMuc
            // 
            this.cmbHanMuc.FormattingEnabled = true;
            this.cmbHanMuc.Items.AddRange(new object[] {
            "40000000",
            "60000000",
            "80000000"});
            this.cmbHanMuc.Location = new System.Drawing.Point(212, 57);
            this.cmbHanMuc.Name = "cmbHanMuc";
            this.cmbHanMuc.Size = new System.Drawing.Size(144, 24);
            this.cmbHanMuc.TabIndex = 16;
            // 
            // txtNoTD
            // 
            this.txtNoTD.Location = new System.Drawing.Point(212, 157);
            this.txtNoTD.Name = "txtNoTD";
            this.txtNoTD.Size = new System.Drawing.Size(144, 22);
            this.txtNoTD.TabIndex = 19;
            // 
            // cmbLaiXuat
            // 
            this.cmbLaiXuat.FormattingEnabled = true;
            this.cmbLaiXuat.Items.AddRange(new object[] {
            "0.04",
            "0.05",
            "0.06"});
            this.cmbLaiXuat.Location = new System.Drawing.Point(212, 105);
            this.cmbLaiXuat.Name = "cmbLaiXuat";
            this.cmbLaiXuat.Size = new System.Drawing.Size(144, 24);
            this.cmbLaiXuat.TabIndex = 20;
            // 
            // txtNoXau
            // 
            this.txtNoXau.Location = new System.Drawing.Point(212, 204);
            this.txtNoXau.Name = "txtNoXau";
            this.txtNoXau.Size = new System.Drawing.Size(144, 22);
            this.txtNoXau.TabIndex = 21;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(375, 60);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(163, 22);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(209, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "So lan";
            // 
            // txtSoLan
            // 
            this.txtSoLan.Location = new System.Drawing.Point(212, 259);
            this.txtSoLan.Name = "txtSoLan";
            this.txtSoLan.Size = new System.Drawing.Size(144, 22);
            this.txtSoLan.TabIndex = 24;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Linen;
            this.groupBox1.Controls.Add(this.txtSoLan);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.txtNoXau);
            this.groupBox1.Controls.Add(this.cmbLaiXuat);
            this.groupBox1.Controls.Add(this.txtNoTD);
            this.groupBox1.Controls.Add(this.cmbHanMuc);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cmbLoaiThe);
            this.groupBox1.Controls.Add(this.txtCccd);
            this.groupBox1.Controls.Add(this.txtThuNhap);
            this.groupBox1.Controls.Add(this.txtTenKH);
            this.groupBox1.Controls.Add(this.txtMaTD);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(-2, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(562, 302);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // fTinDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 639);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.gvTinDung);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "fTinDung";
            this.Text = "fTinDung";
            this.Load += new System.EventHandler(this.fTinDung_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvTinDung)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView gvTinDung;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnKiemTra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMaTD;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtThuNhap;
        private System.Windows.Forms.TextBox txtCccd;
        private System.Windows.Forms.ComboBox cmbLoaiThe;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbHanMuc;
        private System.Windows.Forms.TextBox txtNoTD;
        private System.Windows.Forms.ComboBox cmbLaiXuat;
        private System.Windows.Forms.TextBox txtNoXau;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoLan;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
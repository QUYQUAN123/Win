﻿namespace QLNganHang
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
            this.gvTinDung = new System.Windows.Forms.DataGridView();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.gvTinDung)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvTinDung
            // 
            this.gvTinDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTinDung.Location = new System.Drawing.Point(3, 292);
            this.gvTinDung.Name = "gvTinDung";
            this.gvTinDung.RowHeadersWidth = 51;
            this.gvTinDung.RowTemplate.Height = 24;
            this.gvTinDung.Size = new System.Drawing.Size(580, 180);
            this.gvTinDung.TabIndex = 0;
            this.gvTinDung.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvTinDung_CellContentClick);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(68, 264);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(327, 22);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tim kiem";
            // 
            // groupBox1
            // 
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
            this.groupBox1.Location = new System.Drawing.Point(12, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(571, 228);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ma tin dung";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ten khach hang";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Thu Nhap";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Cccd";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Loai the";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(282, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Ngay tra";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(282, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Lai xuat tin dung";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(282, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "No tin dung";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(282, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 16);
            this.label10.TabIndex = 8;
            this.label10.Text = "No xau";
            // 
            // txtMaTD
            // 
            this.txtMaTD.Location = new System.Drawing.Point(115, 12);
            this.txtMaTD.Name = "txtMaTD";
            this.txtMaTD.Size = new System.Drawing.Size(144, 22);
            this.txtMaTD.TabIndex = 10;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(115, 49);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(144, 22);
            this.txtTenKH.TabIndex = 11;
            // 
            // txtThuNhap
            // 
            this.txtThuNhap.Location = new System.Drawing.Point(115, 80);
            this.txtThuNhap.Name = "txtThuNhap";
            this.txtThuNhap.Size = new System.Drawing.Size(144, 22);
            this.txtThuNhap.TabIndex = 12;
            // 
            // txtCccd
            // 
            this.txtCccd.Location = new System.Drawing.Point(115, 110);
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
            this.cmbLoaiThe.Location = new System.Drawing.Point(115, 138);
            this.cmbLoaiThe.Name = "cmbLoaiThe";
            this.cmbLoaiThe.Size = new System.Drawing.Size(144, 24);
            this.cmbLoaiThe.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(282, 18);
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
            this.cmbHanMuc.Location = new System.Drawing.Point(396, 12);
            this.cmbHanMuc.Name = "cmbHanMuc";
            this.cmbHanMuc.Size = new System.Drawing.Size(144, 24);
            this.cmbHanMuc.TabIndex = 16;
            // 
            // txtNoTD
            // 
            this.txtNoTD.Location = new System.Drawing.Point(396, 110);
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
            this.cmbLaiXuat.Location = new System.Drawing.Point(396, 80);
            this.cmbLaiXuat.Name = "cmbLaiXuat";
            this.cmbLaiXuat.Size = new System.Drawing.Size(144, 24);
            this.cmbLaiXuat.TabIndex = 20;
            // 
            // txtNoXau
            // 
            this.txtNoXau.Location = new System.Drawing.Point(396, 146);
            this.txtNoXau.Name = "txtNoXau";
            this.txtNoXau.Size = new System.Drawing.Size(144, 22);
            this.txtNoXau.TabIndex = 21;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Location = new System.Drawing.Point(617, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(145, 234);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(31, 18);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(85, 35);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Them";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(396, 52);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(143, 22);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // fTinDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 487);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.gvTinDung);
            this.Name = "fTinDung";
            this.Text = "fTinDung";
            this.Load += new System.EventHandler(this.fTinDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvTinDung)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvTinDung;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNoXau;
        private System.Windows.Forms.ComboBox cmbLaiXuat;
        private System.Windows.Forms.TextBox txtNoTD;
        private System.Windows.Forms.ComboBox cmbHanMuc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbLoaiThe;
        private System.Windows.Forms.TextBox txtCccd;
        private System.Windows.Forms.TextBox txtThuNhap;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtMaTD;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThem;
    }
}
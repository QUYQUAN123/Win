﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNganHang
{
    public partial class fNapRut : Form
    {
        DataQLNganHangDataContext db = new DataQLNganHangDataContext();
        public fNapRut()
        {
            InitializeComponent();
        }

        private void btnRut_Click(object sender, EventArgs e)
        {
            int soTien = int.Parse(txbSoTien.Text);
            db.TaiKhoans.Where(tk => tk.SoTK == txbSoTK.Text).ToList().ForEach(tk => tk.SoDu -= soTien);
            KiemTra();
            // Lưu các thay đổi vào cơ sở dữ liệu
            db.SubmitChanges();
            
        }
        public void KiemTra()
        {

            string d = txbSoTK.Text;
            var item = (from u in db.TaiKhoans
                        where u.SoTK == d
                        select u).FirstOrDefault();
            txbTen.Text = item.TenKH;
            txbSDT.Text = item.SDT;
            txbCccd.Text = item.Cccd;
            txbSoDu.Text = Convert.ToString(item.SoDu);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fNapRut_Load(object sender, EventArgs e)
        {

        }

        private void btnNap_Click_1(object sender, EventArgs e)
        {
            int soTien = int.Parse(txbSoTien.Text);
            db.TaiKhoans.Where(tk => tk.SoTK == txbSoTK.Text).ToList().ForEach(tk => tk.SoDu += soTien);
            KiemTra();
            db.SubmitChanges();
        }

        private void btnKiemTra_Click_1(object sender, EventArgs e)
        {
            KiemTra();
        }

        private void btnRut_Click_1(object sender, EventArgs e)
        {
            int soTien = int.Parse(txbSoTien.Text);
            db.TaiKhoans.Where(tk => tk.SoTK == txbSoTK.Text).ToList().ForEach(tk => tk.SoDu -= soTien);
            KiemTra();
            // Lưu các thay đổi vào cơ sở dữ liệu
            db.SubmitChanges();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            fMain f = new fMain();
            f.ShowDialog();
            this.Close();
        }
    }
}

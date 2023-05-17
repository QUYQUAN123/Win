using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNganHang
{

    public partial class fThanhToanTinDung : Form
    {
        DataQLNganHangDataContext db = new DataQLNganHangDataContext();
        public fThanhToanTinDung()
        {
            InitializeComponent();
        }
        public void KiemTraTD()
        {
            if (txtCccd.Text != "")
            {
                string cccd = txtCccd.Text;
                var stexist = from u in db.TinDungs
                              where u.Cccd == cccd
                              select u.Cccd;
                if (stexist.Count() > 0)
                {
                    var item = (from u in db.TinDungs
                                where u.Cccd == cccd
                                select u).FirstOrDefault();
                    txtTenKH.Text = item.TenKH;
                    txtNoTD.Text = Convert.ToString(item.NoTD);
                    txtNX.Text = Convert.ToString(item.NoXau);
                    txtHanMuc.Text = Convert.ToString(item.HanMuc);
                }
                else
                {
                    MessageBox.Show("Ma tin dung khong dung");

                }
            }
            else
            {
                MessageBox.Show("Nhap ma tin dung");
            }
        }

        private void fTinDung_Load(object sender, EventArgs e)
        {

        }

        private void btnChuyen_Click(object sender, EventArgs e)
        {
            this.Hide();
            fKiemTraTD f = new fKiemTraTD();
            f.ShowDialog();
            this.Close();
        }

        private void btnTN_Click_1(object sender, EventArgs e)
        {

            int sotien = int.Parse(txtST.Text);


            db.TinDungs.Where(tk => tk.Cccd == txtCccd.Text).ToList().ForEach(tk => tk.NoTD -= sotien);
            KiemTraTD();
            db.SubmitChanges();


        }

        private void btnKT_Click_1(object sender, EventArgs e)
        {
            KiemTraTD();
        }

        private void btnCNNoXau_Click_1(object sender, EventArgs e)
        {
            decimal notd = decimal.Parse(txtNoTD.Text);
            decimal noxau = decimal.Parse(txtNX.Text);

            db.TinDungs.Where(td => td.Cccd == txtCccd.Text).ToList().ForEach(td => td.NoXau = (notd + noxau));
            KiemTraTD();
            db.SubmitChanges();
        }

        private void btnChuyen_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            fKiemTraTD f = new fKiemTraTD();
            f.ShowDialog();
            this.Close();
        }

        private void btnTinDung_Click(object sender, EventArgs e)
        {
            this.Hide();
            fTinDung f = new fTinDung();
            f.ShowDialog();
            this.Close();
        }

        private void btnRTTD_Click(object sender, EventArgs e)
        {
            int sotien = int.Parse(txtST.Text);
            db.TinDungs.Where(tk => tk.Cccd == txtCccd.Text).ToList().ForEach(tk => tk.HanMuc -= sotien);
            KiemTraTD();
            db.SubmitChanges();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
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

    public partial class fNoTinDung : Form
    {
        DataQLNganHangDataContext db = new DataQLNganHangDataContext();
        public fNoTinDung()
        {
            InitializeComponent();
        }
        public void KiemTraTD()
        {
            string std = txtSoTD.Text;

            var item = (from u in db.TinDungs
                        where u.MaTD == std
                        select u).FirstOrDefault();
            txtTenKH.Text = item.TenKH;
            txtNoTD.Text = Convert.ToString(item.NoTD);
            txtNX.Text = Convert.ToString(item.NoXau);
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
            db.TinDungs.Where(tk => tk.MaTD == txtSoTD.Text).ToList().ForEach(tk => tk.NoTD -= sotien);
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

            db.TinDungs.Where(td => td.MaTD == txtSoTD.Text).ToList().ForEach(td => td.NoXau = (notd + noxau));
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

        
    }
}

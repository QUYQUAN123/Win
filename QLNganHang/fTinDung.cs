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
    public partial class fTinDung : Form
    {
        DataQLNganHangDataContext db = new DataQLNganHangDataContext();
        public fTinDung()
        {
            InitializeComponent();
        }

        private void fTinDung_Load(object sender, EventArgs e)
        {
            db = new DataQLNganHangDataContext();
            gvTinDung.DataSource = db.TinDungs;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            var lst = (from s in db.TinDungs where s.Cccd.Contains(txtTimKiem.Text) select s).ToList();
            gvTinDung.DataSource = lst;

        }

        private void gvTinDung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i= gvTinDung.CurrentRow.Index;
            txtMaTD.Text= gvTinDung.Rows[i].Cells[0].Value.ToString();
            txtTenKH.Text= gvTinDung.Rows[i].Cells[1].Value.ToString();
            txtThuNhap.Text= gvTinDung.Rows[i].Cells[2].Value.ToString();
            txtCccd.Text= gvTinDung.Rows[i].Cells[3].Value.ToString();
            cmbLoaiThe.Text= gvTinDung.Rows[i].Cells[4].Value.ToString();
            cmbHanMuc.Text= gvTinDung.Rows[i].Cells[5].Value.ToString();
            dateTimePicker1.Text= gvTinDung.Rows[i].Cells[6].Value.ToString();
            cmbLaiXuat.Text= gvTinDung.Rows[i].Cells[7].Value.ToString();
            txtNoTD.Text= gvTinDung.Rows[i].Cells[8].Value.ToString();
            txtNoXau.Text= gvTinDung.Rows[i].Cells[9].Value.ToString();

        }

        
    }
}

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
            LoadData();
        }
        void LoadData()
        {
            db = new DataQLNganHangDataContext();
            gvTinDung.DataSource = db.TinDungs;
        }

        private void gvTinDung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = gvTinDung.CurrentRow.Index;
            txtMaTD.Text = gvTinDung.Rows[i].Cells[0].Value.ToString();
            txtTenKH.Text = gvTinDung.Rows[i].Cells[1].Value.ToString();
            txtThuNhap.Text = gvTinDung.Rows[i].Cells[2].Value.ToString();
            txtCccd.Text = gvTinDung.Rows[i].Cells[3].Value.ToString();
            cmbLoaiThe.Text = gvTinDung.Rows[i].Cells[4].Value.ToString();
            cmbHanMuc.Text = gvTinDung.Rows[i].Cells[5].Value.ToString();
            dateTimePicker1.Text = gvTinDung.Rows[i].Cells[6].Value.ToString();
            cmbLaiXuat.Text = gvTinDung.Rows[i].Cells[7].Value.ToString();
            txtNoTD.Text = gvTinDung.Rows[i].Cells[8].Value.ToString();
            txtNoXau.Text = gvTinDung.Rows[i].Cells[9].Value.ToString();
            txtSoLan.Text = gvTinDung.Rows[i].Cells[10].Value.ToString();
        }

       

        private void btnKiemTra_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            fKiemTraTD f = new fKiemTraTD();
            f.ShowDialog();
            this.Close();
        }

        private void btnThanhToan_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            fThanhToanTinDung f = new fThanhToanTinDung();
            f.ShowDialog();
            this.Close();
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban co muon xoa khong", "Xoa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string tenkh = txtTenKH.Text, cccd = txtCccd.Text, loaithe = cmbLoaiThe.Text, solan = txtSoLan.Text;
                double laixuattd = double.Parse(cmbLaiXuat.Text);
                DateTime ngaytra = DateTime.Parse(dateTimePicker1.Text);
                decimal thunhap = decimal.Parse(txtThuNhap.Text), hanmuc = decimal.Parse(cmbHanMuc.Text)
                , notd = decimal.Parse(txtNoTD.Text), noxau = decimal.Parse(txtNoXau.Text);
                var st = (from s in db.TinDungs where s.MaTD == txtMaTD.Text select s).First();
                st.TenKH = tenkh;
                st.ThuNhap = thunhap;
                st.Cccd = cccd;
                st.LoaiThe = loaithe;
                st.HanMuc = hanmuc;
                st.NgayTra = ngaytra;
                st.LaiXuatTD = laixuattd;
                st.NoTD = notd;
                st.NoXau = noxau;
                st.SoLan = solan;
                db.TinDungs.DeleteOnSubmit(st);
                db.SubmitChanges();
                MessageBox.Show("Xoa thanh cong");
                LoadData();
            }
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            string tenkh = txtTenKH.Text, cccd = txtCccd.Text, loaithe = cmbLoaiThe.Text, solan = txtSoLan.Text;
            double laixuattd = double.Parse(cmbLaiXuat.Text);
            DateTime ngaytra = DateTime.Parse(dateTimePicker1.Text);
            decimal thunhap = decimal.Parse(txtThuNhap.Text), hanmuc = decimal.Parse(cmbHanMuc.Text)
            , notd = decimal.Parse(txtNoTD.Text), noxau = decimal.Parse(txtNoXau.Text);
            var st = (from s in db.TinDungs where s.MaTD == txtMaTD.Text select s).First();
            st.TenKH = tenkh;
            st.ThuNhap = thunhap;
            st.Cccd = cccd;
            st.LoaiThe = loaithe;
            st.HanMuc = hanmuc;
            st.NgayTra = ngaytra;
            st.LaiXuatTD = laixuattd;
            st.NoTD = notd;
            st.NoXau = noxau;
            st.SoLan = solan;
            db.SubmitChanges();
            MessageBox.Show("Sua thanh cong");
            LoadData();
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            fThemTinDung f = new fThemTinDung();
            f.ShowDialog();
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            var lst = (from s in db.TinDungs where s.Cccd.Contains(txtTimKiem.Text) select s).ToList();
            gvTinDung.DataSource = lst;
        }
    }
}

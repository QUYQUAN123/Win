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
    public partial class fThemTinDung : Form
    {
        DataQLNganHangDataContext db = new DataQLNganHangDataContext();
        public fThemTinDung()
        {
            InitializeComponent();
        }
        void KiemTraTD()
        {
            string d = txtCccd.Text;
            var item = (from u in db.TaiKhoans
                        where u.Cccd == d
                        select u).FirstOrDefault();
            txtTenKH.Text = item.TenKH;
        }
        void LayThongTinKhachHang()
        {

            string cccd = txtCccd.Text;
            List<KhachHang> lstKhachHang = KhachHangDAO.Instance.ThongTinKH(cccd);
            if (lstKhachHang.Count > 0)
            {
                // Hiển thị thông tin lên các button tương ứng
                txtTenKH.Text = lstKhachHang[0].TenKH;
                txtCccd.Text = lstKhachHang[0].CCCD;
                txtThuNhap.Text = lstKhachHang[0].ThuNhap.ToString();
            }

        }

        private void btnLayThongTin_Click(object sender, EventArgs e)
        {
            LayThongTinKhachHang();
        }

        private void btnThemTD_Click(object sender, EventArgs e)
        {
            string matd = txtMaTD.Text, tenkh = txtTenKH.Text, cccd = txtCccd.Text, loaithe = cmbLoaiThe.Text, solan = txtSoLan.Text;
            double laixuattd = double.Parse(cmbLaiXuat.Text);
            DateTime ngaytra = DateTime.Parse(dateTimePicker1.Text);
            decimal thunhap = decimal.Parse(txtThuNhap.Text), hanmuc = decimal.Parse(cmbHanMuc.Text)
                , notd = decimal.Parse(txtNoTD.Text), noxau = decimal.Parse(txtNoXau.Text);
            var item = new TinDung
            {
                MaTD = matd,
                TenKH = tenkh,
                ThuNhap = thunhap,
                Cccd = cccd,
                LoaiThe = loaithe,
                HanMuc = hanmuc,
                NgayTra = ngaytra,
                LaiXuatTD = laixuattd,
                NoTD = notd,
                NoXau = noxau,
                SoLan = solan,

            };
            db.TinDungs.InsertOnSubmit(item);
            db.SubmitChanges();
            MessageBox.Show("Them thanh cong");
        }
        private void btnTinDung_Click(object sender, EventArgs e)
        {
            this.Hide();
            fTinDung f = new fTinDung();
            f.ShowDialog();
            this.Close();
        }

        private void fThemTinDung_Load(object sender, EventArgs e)
        {

        }
    }
}

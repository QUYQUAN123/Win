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
    public partial class fMoTaiKhoancs : Form
    {
        DataQLNganHangDataContext db = new DataQLNganHangDataContext();
        string ma, ten, sdt;
        public string TextBoxValue { get; set; }
        public fMoTaiKhoancs()
        {
            InitializeComponent();
        }
        
        private void fMoTaiKhoancs_Load(object sender, EventArgs e)
        {
            txbCCCD.Text = TextBoxValue;
        }
        private void XoaDuLieuTaiKhoan(string soTK)
        {
            var taiKhoan = db.TaiKhoans.FirstOrDefault(tk => tk.SoTK == soTK);
            if (taiKhoan != null)
            {
                db.TaiKhoans.DeleteOnSubmit(taiKhoan);
                db.SubmitChanges();
            }
        }

        private bool KiemTraTrungSoTK(string soTK)
        {
            return db.TaiKhoans.Count(tk => tk.SoTK == soTK) > 0;
        }


        private void btn2_Click_1(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string cccd = TextBoxValue;
                bool result = KhachHangDAO.Instance.XoaKhachHangTheoCCCD(cccd);
                bool resultn = AccountDAO.Instance.DeleteAccount(cccd);
                this.Close();
            }
        }

        private void btnMoTK_Click_1(object sender, EventArgs e)
        {
            string cccd = txbCCCD.Text;
            if (KhachHangDAO.Instance.KiemTraCCCD(cccd))
            {
                thongtin();
                string soTK = txbSoTk.Text;
                if (KiemTraTrungSoTK(soTK))
                {
                    MessageBox.Show("Số tài khoản đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    TaiKhoan taiKhoan = new TaiKhoan
                    {
                        SoTK = soTK,
                        MaKH = ma,
                        TenKH = ten,
                        SDT = sdt,
                        Cccd = txbCCCD.Text,
                        SoDu = 0,
                        SoTienVay = 0,
                        SoTKhoanTK = "0"
                    };

                    db.TaiKhoans.InsertOnSubmit(taiKhoan);
                    db.SubmitChanges();

                    MessageBox.Show("Mở tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Khách hàng chưa đăng kí! Bạn có muốn đăng kí mới?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    fDangKiKhachHangMoi f = new fDangKiKhachHangMoi();
                    f.ShowDialog();
                }
            }
        }

       
       
        private void thongtin()
        {
            string cccd = txbCCCD.Text;
            List<KhachHang> lstKhachHang = KhachHangDAO.Instance.TimKhachHangTheoCCCD(cccd);
            if (lstKhachHang.Count > 0)
            {
                // Hiển thị thông tin lên các button tương ứng
                ma = lstKhachHang[0].MaKH;
                ten = lstKhachHang[0].TenKH;
                sdt = lstKhachHang[0].SDT;
   
            }
        }

    }
}

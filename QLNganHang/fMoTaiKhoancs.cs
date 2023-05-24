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
         QLNganHangEntities db = new QLNganHangEntities();
        string ma, ten, sdt;

        public fNewAccount fnewAccount;
        private fNhanVien _fNhanVien;
        public string TextBoxValue { get; set; }
        public fMoTaiKhoancs()
        {
            InitializeComponent();
        }
        
        private void fMoTaiKhoancs_Load(object sender, EventArgs e)
        {
            txbCCCD.Text = TextBoxValue;
            txbCCCD.ReadOnly = true;
            txbSoTk.Text = SinhSoTK();
            txbSoTk.ReadOnly = true;
        }
        public void XoaDuLieuTaiKhoan(string cccd)
        {
            fnewAccount.XoaDuLieuAccount(cccd);
            var cc = db.TaiKhoans.FirstOrDefault(Cc => Cc.Cccd == cccd);
            if (cc != null)
            {
                db.TaiKhoans.Remove(cc);
                db.SaveChanges();
            }
        }
        private string SinhSoTK()
        {
            string soTK;
            Random random = new Random();

            do
            {
                // Sinh ngẫu nhiên 4 chữ số
                int randomNumber = random.Next(1000, 10000);
                soTK = "TK" + randomNumber.ToString();
            } while (KiemTraTrungSoTK(soTK)); // Kiểm tra tính duy nhất

            return soTK;
        }

        private bool KiemTraTrungSoTK(string soTK)
        {
            return db.TaiKhoans.Count(tk => tk.SoTK == soTK) > 0;
        }

        private void btn2_Click_1(object sender, EventArgs e)
        {

            XoaDuLieuTaiKhoan(txbSoTk.Text);
        }

        private void btnMoTK_Click_1(object sender, EventArgs e)
        {
            thongtin();
            string soTK = txbSoTk.Text;
            if (KiemTraTrungSoTK(soTK))
            {
                MessageBox.Show("Số tài khoản đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                KhachHang khachHang = db.KhachHangs.FirstOrDefault(kh => kh.Cccd == txbCCCD.Text);
                if (khachHang != null)
                {
                    TaiKhoan taiKhoan = new TaiKhoan
                    {
                        SoTK = soTK,
                        MaKH = khachHang.MaKH,
                        TenKH = khachHang.TenKH,
                        SDT = khachHang.SDT,
                        Cccd = txbCCCD.Text,
                        SoDu = 0,
                        SoTienVay = 0
                    };

                    db.TaiKhoans.Add(taiKhoan);
                    db.SaveChanges();

                    MessageBox.Show("Mở tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }



        private void thongtin()
        {
            string cccd = txbCCCD.Text;
            KhachHang khachHang = db.KhachHangs.FirstOrDefault(kh => kh.Cccd == cccd);
            if (khachHang != null)
            {
                // Hiển thị thông tin lên các button tương ứng
                ma = khachHang.MaKH;
                ten = khachHang.TenKH;
                sdt = khachHang.SDT;
            }
        }

    }
}

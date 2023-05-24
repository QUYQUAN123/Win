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
    public partial class fDangKiKhachHangMoi : Form
    {
        QLNganHangEntities db = new QLNganHangEntities();
        public fDangKiKhachHangMoi()
        {
            InitializeComponent();
        }


        private void fDangKiKhachHangMoi_Load(object sender, EventArgs e)
        {
            txbMaKH.Text = SinhSoMa();
            txbMaKH.ReadOnly = true;
        }
        private bool KiemTraCCCD(string cccd)
        {
            return db.KhachHangs.Any(kh => kh.Cccd == cccd);
        }

        private bool ThemKhachHang(string maKH, string tenKH, DateTime ngaySinh, string sdt, string email, string cccd, string diaChi, decimal thuNhap)
        {
            try
            {
                KhachHang kh = new KhachHang
                {
                    MaKH = maKH,
                    TenKH = tenKH,
                    NgaySinh = ngaySinh,
                    SDT = sdt,
                    Email = email,
                    Cccd = cccd,
                    DiaChi = diaChi,
                    ThuNhap = thuNhap
                };

                db.KhachHangs.Add(kh);
                db.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            string maKH = txbMaKH.Text;
            string tenKH = txbTenKH.Text;
            DateTime ngaySinh = dtNgaySinh.Value;
            string sdt = txbSDT.Text;
            string email = txbEmail.Text;
            string cccd = txbCCCD.Text;
            string diaChi = txbDiaChi.Text;
            Decimal thuNhap = decimal.Parse(txbThuNhap.Text);

            if (KiemTraCCCD(cccd))
            {
                MessageBox.Show("CCCD đã tồn tại, vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ThemKhachHang(maKH, tenKH, ngaySinh, sdt, email, cccd, diaChi, thuNhap))
            {
                MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                fNewAccount fn = new fNewAccount();
                fn.TextBoxValue = cccd;
                fn.fdangKiKhachHangMoi = this;
                fn.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm khách hàng thất bại, vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string SinhSoMa()
        {
            string ma;
            Random random = new Random();

            do
            {
                // Sinh ngẫu nhiên 4 chữ số
                int randomNumber = random.Next(1000, 10000);
                ma = "KH" + randomNumber.ToString();
            } while (KiemTraTrungSoMa(ma)); // Kiểm tra tính duy nhất

            return ma;
        }

        private bool KiemTraTrungSoMa(string ma)
        {
            return db.KhachHangs.Count(Ma => Ma.MaKH == ma) > 0;
        }
        public void XoaDuLieuKhachHang(string cccd)
        {
            var kh = db.KhachHangs.FirstOrDefault(Kh => Kh.Cccd == cccd);
            if (kh != null)
            {
                db.KhachHangs.Remove(kh);
                db.SaveChanges();
            }
        }


    }
}

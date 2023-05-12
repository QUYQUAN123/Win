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
        public fDangKiKhachHangMoi()
        {
            InitializeComponent();
        }


        private void fDangKiKhachHangMoi_Load(object sender, EventArgs e)
        {
            txbMaKH.Text = KhachHangDAO.Instance.SinhSoMa();
            txbMaKH.ReadOnly = true;
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

            if (KhachHangDAO.Instance.KiemTraCCCD(cccd))
            {
                MessageBox.Show("CCCD đã tồn tại, vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (KhachHangDAO.Instance.ThemKhachHang(maKH, tenKH, ngaySinh, sdt, email, cccd, diaChi, thuNhap))
            {
                MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                fNewAccount fn = new fNewAccount();
                fn.TextBoxValue = cccd;
                fn.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm khách hàng thất bại, vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
    }
}

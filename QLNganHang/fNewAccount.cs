using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace QLNganHang
{
    public partial class fNewAccount : Form
    {
        public string TextBoxValue { get; set; }
        public fNewAccount()
        {
            InitializeComponent();
        }

        private void fNewAccount_Load(object sender, EventArgs e)
        {
            txtnCCCD.Text = TextBoxValue;
        }
        public void Themaccount()
        {
            string userName = txtNAccount.Text;
            string citizenID = txtnCCCD.Text;
            int type = 0;
            string password = txtNPass.Text;

            bool result = AccountDAO.Instance.InsertAccount(userName, citizenID, type, password);

            if (result)
            {
                MessageBox.Show("Them Thang Cong");
            }
            else
            {
                 MessageBox.Show("Thêm tài khoản thất bại");
            }
        }
        private bool CheckCCCD(string cccd)
        {
            // Kiểm tra xem CCCD đã có trong bảng KhachHang chưa
            if (KhachHangDAO.Instance.KiemTraCCCD(cccd))
            {
                // Nếu đã có trong bảng KhachHang, kiểm tra xem có trong bảng Account chưa
                if (AccountDAO.Instance.CheckExistAccount(cccd))
                {
                    // Nếu đã có trong bảng Account, thông báo thêm tài khoản thất bại
                    MessageBox.Show("Khách hàng này đã có tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                else
                {
                    // Nếu chưa có trong bảng Account, gọi hàm thêm tài khoản
                    Themaccount();
                    return true;
                }
            }
            else
            {
                // Nếu chưa có trong bảng KhachHang, thông báo cần đăng kí khách hàng và hỏi có muốn đăng kí không
                DialogResult result = MessageBox.Show("Khách hàng chưa được đăng kí! Bạn có muốn đăng kí mới không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    // Nếu chọn đồng ý, gọi form đăng kí mới
                    fDangKiKhachHangMoi form = new fDangKiKhachHangMoi();
                    form.Show();
                }
                return false;
            }
        }

     

      

        private void btnDangKi_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            string cccd = txtnCCCD.Text;
            CheckCCCD(cccd);
            fMoTaiKhoancs fmo = new fMoTaiKhoancs();
            fmo.TextBoxValue = cccd;
            fmo.ShowDialog();
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string cccd = TextBoxValue;
                bool result = KhachHangDAO.Instance.XoaKhachHangTheoCCCD(cccd);
                this.Close();
            }
        }
    }
}

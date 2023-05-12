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
            txtnCCCD.ReadOnly = true;
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
        private void ChecKAccount()
        {
            string tenDangNhap = txtNAccount.Text;

            bool trungTenDangNhap = AccountDAO.Instance.KiemTraTrungTenDangNhap(tenDangNhap);
            if (trungTenDangNhap)
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string cccd = txtnCCCD.Text;
                fMoTaiKhoancs fmo = new fMoTaiKhoancs();
                fmo.TextBoxValue = cccd;
                fmo.ShowDialog();
            }
        }

     

      

        private void btnDangKi_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            
            ChecKAccount();
            
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

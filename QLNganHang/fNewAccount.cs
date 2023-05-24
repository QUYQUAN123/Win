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
        QLNganHangEntities db = new QLNganHangEntities();
        public fDangKiKhachHangMoi fdangKiKhachHangMoi;
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
            int type = 0; // Giá trị type của tài khoản, bạn có thể thay đổi theo yêu cầu
            string password = txtNPass.Text;

            using (var db = new QLNganHangEntities())
            {
                Account newAccount = new Account()
                {
                    UserName = userName,
                    CitizenID = citizenID,
                    Type = type,
                    PassWord = password
                };

                db.Accounts.Add(newAccount);
                db.SaveChanges();
            }

            MessageBox.Show("Thêm tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void ChecKAccount()
        {
            string tenDangNhap = txtNAccount.Text;
            string matKhau = txtNPass.Text;
            string nhapLaiMatKhau = txtNrPass.Text;

            if (string.IsNullOrEmpty(tenDangNhap) || string.IsNullOrEmpty(matKhau) || string.IsNullOrEmpty(nhapLaiMatKhau))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (matKhau != nhapLaiMatKhau)
            {
                MessageBox.Show("Mật khẩu không khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                using (var db = new QLNganHangEntities())
                {
                    bool trungTenDangNhap = KiemTraTrungTenDangNhap(db, tenDangNhap);
                    if (trungTenDangNhap)
                    {
                        MessageBox.Show("Tên đăng nhập đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        string cccd = txtnCCCD.Text;
                        fMoTaiKhoancs fmo = new fMoTaiKhoancs();
                        fmo.TextBoxValue = cccd;
                        fmo.fnewAccount = this;
                        fmo.ShowDialog();
                        this.Close();
                    }
                }
            }
        }

        private bool KiemTraTrungTenDangNhap(QLNganHangEntities db, string tenDangNhap)
        {
            var account = db.Accounts.FirstOrDefault(a => a.UserName == tenDangNhap);
            return account != null;
        }




        private void btnDangKi_Click_1(object sender, EventArgs e)
        {
   
            ChecKAccount();
       }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xoá không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                XoaDuLieuAccount(TextBoxValue);

            }
        }
        public void XoaDuLieuAccount(string cccd)
        {
            if (fdangKiKhachHangMoi != null)
            {
                fdangKiKhachHangMoi.XoaDuLieuKhachHang(cccd);
            }
            var ac = db.Accounts.FirstOrDefault(Ac => Ac.CitizenID == cccd);
            if (ac != null)
            {
                db.Accounts.Remove(ac);
                db.SaveChanges();
            }
        }
    }
}

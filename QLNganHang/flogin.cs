using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNganHang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string passWord = txbPassWord.Text;
            if (Login(userName, passWord))
            {
                using (var context = new QLNganHangEntities())
                {
                    var loginAccount = context.Accounts.FirstOrDefault(a => a.UserName == userName);

                    if (loginAccount.Type == 0)
                    {
                        fKhachHang f = new fKhachHang(loginAccount);
                        this.Hide();
                        f.ShowDialog();
                        this.Show();

                    }
                    if (loginAccount.Type == 1)
                    {
                        fNhanVien f = new fNhanVien(loginAccount);
                        this.Hide();
                        f.ShowDialog();
                        this.Show();

                    }
                }
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
            }
        }
        private bool Login(string userName, string passWord)
        {
            using (var context = new QLNganHangEntities())
            {
                var account = context.Accounts.FirstOrDefault(a => a.UserName == userName && a.PassWord == passWord);
                return account != null;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txbUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}

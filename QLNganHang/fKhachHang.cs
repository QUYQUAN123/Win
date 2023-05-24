using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNganHang
{
    public partial class fKhachHang : Form
    {

      QLNganHangEntities db = new QLNganHangEntities();
        string nt;
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; }
        }
        public fKhachHang(Account acc)
        {
            InitializeComponent();
            loginAccount = acc;
        }


        void LoadData()
        {
            try
            {
                var Lst = (from Cccd in db.TaiKhoans where Cccd.Cccd.Contains(LoginAccount.CitizenID) select Cccd).ToList();
                gvTaikhoanKH.DataSource = Lst;
              

            }
            catch (SqlException)
            {
                MessageBox.Show("Không kết nối lấy được dữ liệu ", "Lỗi dữ liệu!");
            }


        }

        private void fKhachHang_Load(object sender, EventArgs e)
        {
            LoadData();

        }


        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccountProfile f = new fAccountProfile(LoginAccount);
            f.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FThongTinKhacHang fkh =new FThongTinKhacHang();
            fkh.ShowDialog();

        }

        private void btnChuyenTien_Click(object sender, EventArgs e)
        {
            this.Hide();
            fChuyenTien f = new fChuyenTien();
            string nt = db.TaiKhoans.Where(p => p.Cccd == LoginAccount.CitizenID).Select(p => p.SoTK).FirstOrDefault();
            f.TextBoxValue = nt;
            f.ShowDialog();
            this.Close();
        }
    }
}

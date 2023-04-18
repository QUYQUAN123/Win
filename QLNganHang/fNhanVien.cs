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
    public partial class fNhanVien : Form
    {
        DataQLNganHangDataContext db = new DataQLNganHangDataContext();


        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount.Type); }
        }
        public fNhanVien(Account acc)
        {
            InitializeComponent();
            this.LoginAccount = acc;

        }

        private void fNhanVien_Load(object sender, EventArgs e)
        {
            this.LoadData();
        }

        void LoadData()
        {
           
            try
            {
                var data = db.View_KhachHangs.Select(View_KhacHang => new
                {
                    View_KhacHang.MaKH,
                    View_KhacHang.TenKH,
                    View_KhacHang.NgaySinh,
                    View_KhacHang.SDT,
                    View_KhacHang.Email,
                    View_KhacHang.Cccd,
                    View_KhacHang.DiaChi,
                    View_KhacHang.SoTK,
                    View_KhacHang.SoDu,
                });
                gvKhachHang.DataSource = data;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không kết nối lấy được dữ liệu ", "Lỗi dữ liệu!");
            }

          
        }


        void ChangeAccount(int type)
        {
            đổiMậtKhẩuToolStripMenuItem.Text += " (" + LoginAccount.CitizenID + ")";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var Lst = (from Cccd in db.View_KhachHangs where Cccd.Cccd.Contains(txbNhapCccd.Text) select Cccd).ToList();
            dataGridView1.DataSource = Lst;

        }
        private void btnChuyenTien_Click(object sender, EventArgs e)
        {
           
            fChuyenTien f =new fChuyenTien();
            string nt = db.View_KhachHangs.Where(p => p.Cccd == txbNhapCccd.Text).Select(p => p.SoTK).FirstOrDefault();
            f.TextBoxValue = nt;
            f.ShowDialog();
            
        }
        void f_UpdateAccount(object sender, AccountEvent e)
        {
            thôngTinCáNhânToolStripMenuItem.Text = "Thông tin (" + e.Acc.CitizenID + ")";
        }
        private void đổiMậtKhẩuToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            fAccountProfile f = new fAccountProfile(LoginAccount);
            f.ShowDialog();
        }

        private void vayTiềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VayTien v = new VayTien();
            v.ShowDialog();
        }

        private void gửiTiềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuiTien g = new GuiTien();
            g.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fNapRut f =new fNapRut();
            f.ShowDialog();
            
        }

        private void sổTiếtKiệmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTinSoTietKiem tk = new ThongTinSoTietKiem();
            tk.ShowDialog();
        }
    }
}


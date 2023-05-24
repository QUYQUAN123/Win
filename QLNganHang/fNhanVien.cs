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
        QLNganHangEntities db = new QLNganHangEntities();


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
                var data = db.View_KhachHang.Select(view => new
                {
                    view.MaKH,
                    view.TenKH,
                    view.NgaySinh,
                    view.SDT,
                    view.Email,
                    view.Cccd,
                    view.DiaChi,
                    view.SoTK,
                    view.SoDu
                }).ToList();

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
        private void btnChuyenTien_Click(object sender, EventArgs e)
        {

            fChuyenTien f = new fChuyenTien();
            string nt = db.View_KhachHang.Where(p => p.Cccd == txbNhapCccd.Text).Select(p => p.SoTK).FirstOrDefault();
            f.TextBoxValue = nt;
            f.ShowDialog();

        }
       
        private void đổiMậtKhẩuToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            fAccountProfile f = new fAccountProfile(LoginAccount);
            f.ShowDialog();
        }

        private void vayTiềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
           HomeVayTien v = new HomeVayTien();
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

        private void thêmKhachHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fDangKiKhachHangMoi fnew = new fDangKiKhachHangMoi();
            fnew.ShowDialog();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fThongTinNV f = new fThongTinNV();
            f.TextBoxValue = LoginAccount.CitizenID;
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.LoadData();
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string cccd = txbNhapCccd.Text;

                // Tạo một instance của form fMoTaiKhoancs
                fMoTaiKhoancs fMoTaiKhoancs = new fMoTaiKhoancs();

                // Gọi phương thức XoaDuLieuTaiKhoan trong fMoTaiKhoancs
                fMoTaiKhoancs.XoaDuLieuTaiKhoan(cccd);

                MessageBox.Show("Xóa thành công");
            }
        }

        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            LoadData();
            var Lst = (from Cccd in db.View_KhachHang where Cccd.Cccd.Contains(txbNhapCccd.Text) select Cccd).ToList();
            dataGridView1.DataSource = Lst;
        }

        private void tínDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fTinDung f = new fTinDung();
            f.ShowDialog();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void lichSuGiaoDichToolStripMenuItem_Click(object sender, EventArgs e)
        {/*
            LichSuGiaoDich s= new LichSuGiaoDich();
            s.ShowDialog();*/
        }
    }
}


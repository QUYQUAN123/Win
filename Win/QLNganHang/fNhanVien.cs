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
        public fNhanVien()
        {
            InitializeComponent();
        }

        private void fNhanVien_Load(object sender, EventArgs e)
        {
            this.LoadData();
        }

        void LoadData()
        {
           
            try
            {
                var data = db.View_KhacHangs.Select(View_KhacHang => new
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
                MessageBox.Show("Không kết nối lấy được dữ liệu từ loại hàng", "Lỗi dữ liệu!");
            }

          
        }


        private void txbNhapCccd_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var Lst = (from Cccd in db.View_KhacHangs where Cccd.Cccd.Contains(txbNhapCccd.Text) select Cccd).ToList();
            dataGridView1.DataSource = Lst;

        }

        private void txbNhapCccd_TextChanged_1(object sender, KeyEventArgs  e)
        {
        }

        private void btnChuyenTien_Click(object sender, EventArgs e)
        {
            this.Hide();
            fChuyenTien f =new fChuyenTien();
            string nt = db.View_KhacHangs.Where(p => p.Cccd == txbNhapCccd.Text).Select(p => p.SoTK).FirstOrDefault();
            f.TextBoxValue = nt;
            f.ShowDialog();
            this.Close();
        }
    }
}


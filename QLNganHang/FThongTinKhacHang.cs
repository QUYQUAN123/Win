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
    public partial class FThongTinKhacHang : Form
    {
        public FThongTinKhacHang()
        {
            InitializeComponent();
        }

        private void FThongTinKhacHang_Load(object sender, EventArgs e)
        {
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbTenKH.Text) || string.IsNullOrWhiteSpace(txbSDT.Text) || string.IsNullOrWhiteSpace(txbEmail.Text) || string.IsNullOrWhiteSpace(txbDiaChi.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }

            KhachHang kh = new KhachHang();
            kh.MaKH = txbMaKH.Text;
            kh.TenKH = txbTenKH.Text;
            kh.NgaySinh = dtNgaySinh.Value;
            kh.SDT = txbSDT.Text;
            kh.Email = txbEmail.Text;
            kh.CCCD = txbCCCD.Text;
            kh.DiaChi = txbDiaChi.Text;
            kh.ThuNhap = decimal.Parse(txbThuNhap.Text);


            if (KhachHangDAO.Instance.CapNhatThongTinKhachHang(kh))
            {
                MessageBox.Show("Cập nhật thông tin thành công.");
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin không thành công.");
            }
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cccd = txbCCCD.Text;
            List<KhachHang> lstKhachHang = KhachHangDAO.Instance.TimKhachHangTheoCCCD(cccd);
            if (lstKhachHang.Count > 0)
            {
                // Hiển thị thông tin lên các button tương ứng
                txbMaKH.Text = lstKhachHang[0].MaKH;
                txbTenKH.Text = lstKhachHang[0].TenKH;
                dtNgaySinh.Text = lstKhachHang[0].NgaySinh.ToString("dd/MM/yyyy");
                txbSDT.Text = lstKhachHang[0].SDT;
                txbEmail.Text = lstKhachHang[0].Email;
                txbCCCD.Text = lstKhachHang[0].CCCD;
                txbDiaChi.Text = lstKhachHang[0].DiaChi;
                txbThuNhap.Text = lstKhachHang[0].ThuNhap.ToString();
            }
        }
    }
    }


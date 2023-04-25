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
    public partial class fThongTinNV : Form
    {
        public string TextBoxValue { get; set; }
        public fThongTinNV()
        {
            InitializeComponent();
            
        }

        private void fThongTin_Load(object sender, EventArgs e)
        {
            txbCCCD.Text = TextBoxValue;
            string cccd = txbCCCD.Text;
            List<NhanVien> lstNhanVien = NhanVienDAO.Instance.ThongTinNV(cccd);
            if (lstNhanVien.Count > 0)
            {
                // Hiển thị thông tin lên các button tương ứng
                txbMaNV.Text = lstNhanVien[0].MaNV;
                txbTenNV.Text = lstNhanVien[0].TenNV;
                dtNgaySinh.Text = lstNhanVien[0].NgaySinh.ToString("dd/MM/yyyy");
                txbSDT.Text = lstNhanVien[0].SDT;
                txbEmail.Text = lstNhanVien[0].Email;
                txbCCCD.Text = lstNhanVien[0].CCCD;
                txbDiaChi.Text = lstNhanVien[0].DiaChi;
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin nhân viên có CCCD là " + TextBoxValue);
            }
        }


        private void dtNgaySinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCapNhat_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbTenNV.Text) || string.IsNullOrWhiteSpace(txbSDT.Text) || string.IsNullOrWhiteSpace(txbEmail.Text) || string.IsNullOrWhiteSpace(txbDiaChi.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }

            NhanVien nv = new NhanVien();
            nv.MaNV = txbMaNV.Text;
            nv.TenNV = txbTenNV.Text;
            nv.NgaySinh = dtNgaySinh.Value;
            nv.SDT = txbSDT.Text;
            nv.Email = txbEmail.Text;
            nv.CCCD = txbCCCD.Text;
            nv.DiaChi = txbDiaChi.Text;

            if (NhanVienDAO.Instance.CapNhatThongTinNhanVien(nv))
            {
                MessageBox.Show("Cập nhật thông tin thành công.");
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin không thành công.");
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
    }

}

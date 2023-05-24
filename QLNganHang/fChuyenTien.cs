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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QLNganHang
{
    public partial class fChuyenTien : Form
    {

        QLNganHangEntities db = new QLNganHangEntities();
        public fChuyenTien()
        {
            InitializeComponent();

        }

        public string TextBoxValue { get; set; }

        private void fChuyenTien_Load(object sender, EventArgs e)
        {
            txbTkChuyen.Text = TextBoxValue;
            txbSoDuC.ReadOnly = true;
            txbCCCDC.ReadOnly = true;
            txbCCCDN.ReadOnly = true;
            txbSoDuN.ReadOnly = true;
            txbTenKHC.ReadOnly = true; 
            txbTenKHN.ReadOnly = true;


        }
        void Check()
        {
            var khachHangChuyen = db.View_KhachHang.FirstOrDefault(tkc => tkc.SoTK.Contains(txbTkChuyen.Text));
            if (khachHangChuyen != null)
            {
                txbTenKHC.Text = khachHangChuyen.TenKH;
                txbCCCDC.Text = khachHangChuyen.Cccd;
                txbSoDuC.Text = khachHangChuyen.SoDu.ToString();
            }

            var khachHangNhan = db.View_KhachHang.FirstOrDefault(tkn => tkn.SoTK.Contains(txbTkNhan.Text));
            if (khachHangNhan != null)
            {
                txbTenKHN.Text = khachHangNhan.TenKH;
                txbCCCDN.Text = khachHangNhan.Cccd;
                txbSoDuN.Text = khachHangNhan.SoDu.ToString();
            }
        }
        void LoadData()
        {

            try
            {
                var data = db.View_KhachHang.Select(View_KhacHang => new
                {
                    View_KhacHang.Cccd,
                    View_KhacHang.MaKH,
                    View_KhacHang.TenKH,
                    View_KhacHang.NgaySinh,
                    View_KhacHang.SDT,
                    View_KhacHang.DiaChi,
                    View_KhacHang.SoTK,
                    View_KhacHang.SoDu,
                });

            }
            catch (SqlException)
            {
                MessageBox.Show("Không kết nối lấy được dữ liệu từ loại hàng", "Lỗi dữ liệu!");
            }
        }



        private void btnKiemTra_Click_1(object sender, EventArgs e)
        {
            Check();
        }

        private void btnChuyen_Click_1(object sender, EventArgs e)
        {
            String amountText = txbSoTienChuyen.Text;
            if (!string.IsNullOrEmpty(amountText) && double.TryParse(amountText, out double amount))
            {
                var tkChuyen = txbTkChuyen.Text; // Tài khoản cần cộng tiền
                var tkNhan = txbTkNhan.Text; // Tài khoản nhận tiền
                int SoTien = int.Parse(txbSoTienChuyen.Text); // Số tiền cần chuyển
                var tenKh = txbTenKHC.Text;
                var noidung = txbNoiDung.Text;
                var tenKhn = txbTenKHN.Text;

                // Lấy số dư của tài khoản cần chuyển tiền
                var soDuChuyen = db.TaiKhoans.Where(tk => tk.SoTK == tkChuyen).Select(tk => tk.SoDu).FirstOrDefault();

                if (soDuChuyen >= SoTien) // Nếu số dư đủ để chuyển tiền
                {
                    string message = "Ban co chac muon chuyen tien ?";
                    string title = "ChuyenTien";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.No)
                    {
                        this.Hide();
                        fChuyenTien f = new fChuyenTien();
                        f.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        var taiKhoanChuyen = db.TaiKhoans.FirstOrDefault(tk => tk.SoTK == tkChuyen);
                        if (taiKhoanChuyen != null)
                        {
                            taiKhoanChuyen.SoDu -= SoTien;
                        }

                        // Cập nhật số dư của tài khoản nhận tiền
                        var taiKhoanNhan = db.TaiKhoans.FirstOrDefault(tk => tk.SoTK == tkNhan);
                        if (taiKhoanNhan != null)
                        {
                            taiKhoanNhan.SoDu += SoTien;
                        }
                        /*string noidungc = noidung += "  (chuyen tien toi so TK " + tkNhan + ")";
                        // Lưu các thay đổi vào cơ sở dữ liệu
                        LsGiaoDichDAO.Instance.ThemLichSuGiaoDich(tenKh, SoTien, tkChuyen, noidungc);
                        string noidungn = noidung += "  (Nhan tien tu so TK " + tkChuyen + ")";
                        LsGiaoDichDAO.Instance.ThemLichSuGiaoDich(tenKhn, SoTien, tkNhan, noidungn);*/
                        db.SaveChanges();
                        MessageBox.Show("Chuyen tien Thanh cong");
                        Check();
                    }
                }
                else
                {
                    // Hiển thị thông báo cho người dùng rằng số dư không đủ để chuyển tiền
                    MessageBox.Show("Số dư không đủ để thực hiện giao dịch này!");
                }
            }
            else { MessageBox.Show("Vui Long Nhap dung so tien"); }
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            /*LichSuGiaoDich ls = new LichSuGiaoDich();
            ls.ShowDialog();*/
        }

        

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gbtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

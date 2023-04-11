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
        DataQLNganHangDataContext db = new DataQLNganHangDataContext();
        public fChuyenTien()
        {
            InitializeComponent();

        }

        public string TextBoxValue { get; set; }

        private void fChuyenTien_Load(object sender, EventArgs e)
        {
            txbTkChuyen.Text = TextBoxValue;


        }
        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            Check();

        }
        void Check()
        {
            var Lst = (from tkc in db.View_KhachHangs where tkc.SoTK.Contains(txbTkChuyen.Text) select tkc).ToList();
            gvChuyentien.DataSource = Lst;


            var nt = (from tkn in db.View_KhachHangs where tkn.SoTK.Contains(txbTkNhan.Text) select tkn).ToList();
            gvNhanTien.DataSource = nt;

        }
        void LoadData()
        {

            try
            {
                var data = db.View_KhachHangs.Select(View_KhacHang => new
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
        private void btnChuyen_Click(object sender, EventArgs e)
        {
            var tkChuyen = txbTkChuyen.Text; // Tài khoản cần cộng tiền
            var tkNhan = txbTkNhan.Text; // Tài khoản nhận tiền
            int soTien = int.Parse(txbSoTienChuyen.Text); // Số tiền cần chuyển

            // Lấy số dư của tài khoản cần chuyển tiền
            var soDuChuyen = db.TaiKhoans.Where(tk => tk.SoTK == tkChuyen).Select(tk => tk.SoDu).FirstOrDefault();

            if (soDuChuyen >= soTien) // Nếu số dư đủ để chuyển tiền
            {
                string message = "Ban co chac muon chuyen tien ?";
                string title = "ChuyenTien";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.No)
                {
                    this.Hide();
                    fChuyenTien f= new fChuyenTien();
                    f.ShowDialog();
                    this.Close();
                }
                else
                {
                    db.TaiKhoans.Where(tk => tk.SoTK == tkChuyen).ToList().ForEach(tk => tk.SoDu -= soTien);

                    // Cập nhật số dư của tài khoản nhận tiền
                    db.TaiKhoans.Where(tk => tk.SoTK == tkNhan).ToList().ForEach(tk => tk.SoDu += soTien);

                    // Lưu các thay đổi vào cơ sở dữ liệu
                    db.SubmitChanges();
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

     
        private void btnExit_Click(object sender, EventArgs e)
        { 
                
                this.Close();
          
        }
    }
}

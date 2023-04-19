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
    public partial class fTinDung : Form
    {
        public fTinDung()
        {
            InitializeComponent();
        }

        private void fTinDung_Load(object sender, EventArgs e)
        {
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {  
                // Trường hợp ô tìm kiếm CCCD có chứa ký tự thì tìm kiếm khách hàng theo CCCD và hiển thị kết quả
                string cccd = txtTimKiem.Text;
                List<KhachHang> lst = KhachHangDAO.Instance.TimKhachHangTheoCCCD(cccd);
                gvKhachHang.DataSource = lst;         

        }

        
    }
}

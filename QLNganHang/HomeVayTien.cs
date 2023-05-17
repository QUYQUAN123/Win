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
    public partial class HomeVayTien : Form
    {
        DataQLNganHangDataContext NH = new DataQLNganHangDataContext();
        public HomeVayTien()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            string d = txbCCCD.Text;
            var item = (from u in NH.VayTiens 
                        where u.Cccd == d
                        select u).FirstOrDefault();
            if(item == null)
            {
                MessageBox.Show("Không có thông tin. Khách hàng chưa tạo tài khoản hoặc không có lịch sử nợ xấu");
            }
            else if(item.NoXau == 0)
            {
                MessageBox.Show("Khách hàng này không có lịch sử nợ xấu, đủ điều kiện giao dịch!");              
            }
            else
            {
                var item1 = (from u in NH.VayTiens
                            where u.Cccd == d
                            select u).ToList();
                gridVayTien.DataSource = item1;
            }
        }

        private void btnDK_Click(object sender, EventArgs e)
        {
            VayTien vt = new VayTien();
            vt.ShowDialog();
        }

        private void btnDSden_Click(object sender, EventArgs e)
        {
            DSden ds = new DSden();
            ds.ShowDialog();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            ThanhToanVayTien tt = new ThanhToanVayTien();
            tt.ShowDialog();
        }
    }
}

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

        private void button1_Click(object sender, EventArgs e)
        {
            string d = txbCCCD.Text;
            var item = (from u in NH.VayTiens 
                        where u.Cccd == d
                        select u).FirstOrDefault();
            if(item.NoXau == 1)
            {
                gridVayTien.DataSource = item;
            }
            else
            {
                labelResult.Text = "Khách hàng này không có lịch sử nợ xấu, đủ điều kiện giao dịch!";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VayTien vt = new VayTien();
            vt.ShowDialog();
        }
    }
}

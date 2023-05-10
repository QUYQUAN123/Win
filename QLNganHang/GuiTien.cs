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
    public partial class GuiTien : Form
    {
        DataQLNganHangDataContext NH = new DataQLNganHangDataContext();
        public GuiTien()
        {
            InitializeComponent();
            loaddate();
        }

        private void loaddate()
        {
            txtDate.Text = DateTime.UtcNow.ToString("dd/mm/yyyy");
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void GuiTien_Load(object sender, EventArgs e)
        {

        }

        private void tbxTienLai_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLayThongTin_Click_1(object sender, EventArgs e)
        {

            string d = tbxSTKTK.Text;
            var item = (from u in NH.SoTietKiems
                        where u.MaSo == d
                        select u).FirstOrDefault();
            tbxTenKH.Text = item.TenKH;
            tbxSDT.Text = item.SDT;
            tbxCCCD.Text = item.Cccd;
            tbxSoDU.Text = Convert.ToString(item.TienGui);
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            if (tbxSTKTK.Text == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            else
            {

                string d = tbxSTKTK.Text;
                var item = (from u in NH.SoTietKiems
                            where u.MaSo == d
                            select u).FirstOrDefault();
                if (Convert.ToInt32(tbxSoTienGui.Text) == 0)
                {
                    MessageBox.Show("Vui lòng nhập số tiền trên 500.000 VNĐ.");
                }
                else
                {
                    item.TienGui = item.TienGui + Convert.ToDecimal(tbxSoTienGui.Text);
                    NH.SubmitChanges();
                    MessageBox.Show("Giao dịch gửi tiền thành công!");
                }
            }
        }

        
    }
}

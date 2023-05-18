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
            string d = tbxSTKTK.Text;
            string t = tbxCCCD.Text;
            var item = (from u in NH.SoTietKiems
                        where u.MaSo == d
                        select u).FirstOrDefault();
            var item1 = (from u in NH.TaiKhoans
                        where u.Cccd == t
                        select u).FirstOrDefault();
            if (item.DaThanhToan == 2)
            {
                MessageBox.Show("Sổ đã đóng!");
            }
            else if(item.DaThanhToan == 1)
            {
                MessageBox.Show("Sổ đã hoàn tất kỳ hạn chỉ có thể thể tiến hành đóng sổ.");
            }
            else
            {
                if (item1.SoDu < Convert.ToDecimal(tbxSoTienGui.Text))
                {
                    MessageBox.Show("Tài khoản không đủ tiền để thêm vào sổ!");
                }
                else
                {
                    item.TienGui = item.TienGui + Convert.ToDecimal(tbxSoTienGui.Text);
                    item1.SoDu -= Convert.ToDecimal(tbxSoTienGui.Text);
                    double SoTien = double.Parse(tbxSoTienGui.Text);
                    string tenkh = tbxTenKH.Text;
                    string SoTK = item1.SoTK;
                    string noidung = "Gui tien vao So Tiet Kiem  ";
                    LsGiaoDichDAO.Instance.ThemLichSuGiaoDich(tenkh, SoTien, SoTK, noidung);
                    NH.SubmitChanges();
                    MessageBox.Show("Giao dịch gửi tiền thành công!");
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

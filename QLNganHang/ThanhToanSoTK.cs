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
    public partial class ThanhToanSoTK : Form
    {
        DataQLNganHangDataContext NH = new DataQLNganHangDataContext();
        public ThanhToanSoTK()
        {
            InitializeComponent();
        }

        //hbyub
      

        private void btnThanhToan_Click_1(object sender, EventArgs e)
        {
            string d = tbxSTKTK.Text;
            var item = (from u in NH.SoTietKiems
                        where u.MaSo == d
                        select u).FirstOrDefault();
            if (item.DaThanhToan == 0)
            {
                DialogResult tb = MessageBox.Show("Sổ tiết kiệm của bạn chưa hoàn tất thời hạn đăng ký, bạn có muốn tiến hành tất toán không?", "Lưu ý!", MessageBoxButtons.YesNo);
                if (tb == DialogResult.Yes)
                {
                    DialogResult tb2 = MessageBox.Show("Sau khi tất toán, phần tiền lãi tương đương với lãi xuất 1% so với mức ban đầu. Bạn có muốn tiếp tục tất toán hay không?", "Lưu ý quan trọng!", MessageBoxButtons.YesNo);
                    if (tb2 == DialogResult.Yes)
                    {
                        decimal temp = Convert.ToDecimal(tbxSoTienGui.Text) + Convert.ToDecimal(tbxSoTienGui.Text) / 100;
                        DialogResult tb3 = MessageBox.Show("Số tiền bạn nhận được là:" + temp + ". Bạn có muốn tiền được gửi vào tài khoản ngân hàng hay không?", "Thông báo", MessageBoxButtons.YesNoCancel);
                        if (tb3 == DialogResult.Yes)
                        {
                            string a = txbMaKH.Text;
                            var item1 = (from u in NH.TaiKhoans
                                         where u.MaKH == a
                                         select u).FirstOrDefault();
                            item1.SoDu += temp;
                            item.DaThanhToan += 2;
                            NH.SubmitChanges();
                            MessageBox.Show("Giao dịch hoàn tất!");
                        }
                        else if (tb3 == DialogResult.No)
                        {
                            item.DaThanhToan += 2;
                            NH.SubmitChanges();
                            MessageBox.Show("Giao dịch hoàn tất! Vui lòng nhận lại tiền lời.");
                        }
                        else
                        {
                            MessageBox.Show("Giao dịch bị huỷ bỏ");
                        }
                    }
                }
            } 
        }

        private void bntKiemTra_Click(object sender, EventArgs e)
        {
            string d = tbxSTKTK.Text;
            var item = (from u in NH.SoTietKiems
                        where u.MaSo == d
                        select u).FirstOrDefault();
            if (item == null)
            {
                MessageBox.Show("Vui lòng nhập Mã sổ hoặc kiểm tra lại thông tin");
            }
            else
            {
                tbxTenKH.Text = item.TenKH;
                txbMaKH.Text = item.MaKH;
                tbxSDT.Text = item.SDT;
                tbxCCCD.Text = item.Cccd;
                tbxSoTienGui.Text = Convert.ToString(item.TienGui);
                txbNgayGui.Text = Convert.ToString(item.NgayGui);
                txbKyHan.Text = Convert.ToString(item.KyHan);
                txbLaiXuat.Text = Convert.ToString(item.LaiXuat);
                tbxTienLai.Text = Convert.ToString(Convert.ToDecimal(tbxSoTienGui.Text) + Convert.ToDecimal(tbxSoTienGui.Text) * Convert.ToDecimal(txbLaiXuat.Text) / 100);
            }
        }
    }
}


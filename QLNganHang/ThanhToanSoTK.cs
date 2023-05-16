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


        private void btnDongSo_Click(object sender, EventArgs e)
        {
            string d = tbxSoTKTK.Text;
            var item = (from u in NH.SoTietKiems
                        where u.MaSo == d
                        select u).FirstOrDefault();
            DateTime now = DateTime.Now;
            DateTime ngayGui = DateTime.Parse(txbNgayGui.Text);
            DateTime NgayDong = ngayGui.AddMonths(Convert.ToInt32(txbKyHan.Text));
            int soSanh = NgayDong.CompareTo(now);
            if (soSanh > 0)
            {
                DialogResult tb = MessageBox.Show("Sổ tiết kiệm của bạn chưa hoàn tất thời hạn, bạn có muốn tiến hành tất toán không?", "Lưu ý!", MessageBoxButtons.YesNo);
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
            else
            {
                decimal temp = Convert.ToDecimal(tbxSoTienGui.Text) + ((Convert.ToDecimal(tbxSoTienGui.Text) * Convert.ToDecimal(txbLaiXuat.Text) / 100));
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
    
        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            string d = tbxSoTKTK.Text;
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
                tbxTienLai.Text = Convert.ToString(Convert.ToDecimal(tbxSoTienGui.Text) * Convert.ToDecimal(txbLaiXuat.Text) * Convert.ToDecimal(txbKyHan.Text) / 100);
            }
        }

        private void btnTiepTucGuiVoiLai_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            DateTime ngayGui = DateTime.Parse(txbNgayGui.Text);
            DateTime NgayDong = ngayGui.AddMonths(Convert.ToInt32(txbKyHan.Text));
            int soSanh = NgayDong.CompareTo(now);
            decimal temp = (Convert.ToDecimal(tbxSoTienGui.Text) * Convert.ToDecimal(txbLaiXuat.Text) / 100);
            string d = tbxSoTKTK.Text;
            string t = txbMaKH.Text;
            var item = (from u in NH.SoTietKiems
                        where u.MaSo == d
                        select u).FirstOrDefault();
            if (soSanh > 0)
            {
                MessageBox.Show("Lỗi! Sổ này chưa đến kỳ hạn đóng.");
            }
            else
            {
                item.NgayGui = NgayDong;
                item.TienGui += temp;
                MessageBox.Show("Làm mới kỳ hạn thành công! Lãi nhập gốc.");
                NH.SubmitChanges();
            }
        }

        private void btnChuyenLai_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            DateTime ngayGui = DateTime.Parse(txbNgayGui.Text);
            DateTime NgayDong = ngayGui.AddMonths(Convert.ToInt32(txbKyHan.Text));
            int soSanh = NgayDong.CompareTo(now);
            decimal temp = (Convert.ToDecimal(tbxSoTienGui.Text) * Convert.ToDecimal(txbLaiXuat.Text)
                        * Convert.ToDecimal(txbKyHan.Text) / 100);
            string d = tbxSoTKTK.Text;
            string t = txbMaKH.Text;
            var item = (from u in NH.SoTietKiems
                        where u.MaSo == d
                        select u).FirstOrDefault();
            var item1 = (from u in NH.TaiKhoans
                        where u.MaKH == t
                        select u).FirstOrDefault();
            if (soSanh > 0)
            {
                MessageBox.Show("Lỗi! Sổ này chưa đến kỳ hạn đóng.");
            }
            else
            {
                item1.SoDu += temp;
                item.NgayGui = NgayDong;
                MessageBox.Show("Chuyển lãi qua tài khoản thành công! Sổ tiết kiệm sẽ được làm mới kỳ hạn.");
                NH.SubmitChanges();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}


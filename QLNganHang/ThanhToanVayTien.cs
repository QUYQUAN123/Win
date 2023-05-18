using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNganHang
{
    public partial class ThanhToanVayTien : Form
    {
        DataQLNganHangDataContext NH = new DataQLNganHangDataContext();
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.QLNganHangConnectionString1);
        public ThanhToanVayTien()
        {
            InitializeComponent();
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            string d = cccdtxt.Text;
            var item = (from u in NH.View_VayTiens
                        where u.Cccd == d
                        select u).FirstOrDefault();
            var item1 = (from u in NH.VayTiens
                        where u.Cccd == d
                        select u).FirstOrDefault();
            if (item == null || item1 == null)
            {
                MessageBox.Show("Thông báo! Không có thông tin khách hàng.");
            }
            else
            {
                txbTenKH.Text = item.TenKH;
                txbMaKH.Text = item.MaKH;
                txbSDT.Text = item.SDT;
                txbEmail.Text = item.Email;
                txbDChi.Text = item.DiaChi;
                txbThuNhap.Text = Convert.ToString(item.ThuNhap);
                txbTienVay.Text = Convert.ToString(item1.SoTienVay);
                tbxHinhThuc.Text = item1.HinhThucVay;
                txbTaiSanTheChap.Text = item1.TaiSanTheChap;
                dateNgayVay.Text = Convert.ToString(item1.NgayVay);
                txbNgayTra.Text = Convert.ToString(item1.NgayTra);
                comboKyHan.Text = Convert.ToString(item1.KyHan);
                txbLaiXuat.Text = Convert.ToString(item1.LaiXuat);
            }
        }

        private void ThanhToanVayTien_Load(object sender, EventArgs e)
        {

        }

        private void btnTraNo_Click(object sender, EventArgs e)
        {
            string d = cccdtxt.Text;
            var item = (from u in NH.VayTiens
                        where u.Cccd == d
                        select u).FirstOrDefault();
            var item1 = (from u in NH.TaiKhoans
                         where u.Cccd == d
                         select u).FirstOrDefault();       
            if(item == null)
            {
                MessageBox.Show("Không có thông tin khoản vay");
            }
            else
            {
                decimal temp = item.SoTienVay + (Convert.ToDecimal(txbTienVay.Text) * Convert.ToDecimal(txbLaiXuat.Text) / 100);
                DateTime now = DateTime.Now;
                DateTime ngayTra = DateTime.Parse(txbNgayTra.Text);
                int soSanh = ngayTra.CompareTo(now);
                try
                {
                    conn.Open();
                    if (soSanh < 0)
                    {
                        MessageBox.Show("Thanh toán nợ thất bại. Tài khoản này có thông tin nợ xấu do quá kỳ hạn trả nợ. Vào danh sách đen để xem chi tiết.");
                    }
                    else
                    {
                        if (item1.SoDu - temp < 0)
                        {
                            MessageBox.Show("Số dư trong tài khoản không đủ để thanh toán.");
                        }
                        else
                        {
                            item1.SoDu -= item1.SoTienVay;
                            item1.SoTienVay -= item1.SoTienVay;
                            string sqlStr = string.Format("DELETE FROM VayTien WHERE Cccd ='"+cccdtxt.Text+"'");
                            double SoTien = double.Parse(txbTienVay.Text);
                            string tenkh = txbTenKH.Text;
                            string SoTK = item1.SoTK;
                            string noidung = "Thanh toán khoán vay  " + temp;
                            LsGiaoDichDAO.Instance.ThemLichSuGiaoDich(tenkh, SoTien, SoTK, noidung);
                            SqlCommand cmd = new SqlCommand(sqlStr, conn);
                            if (cmd.ExecuteNonQuery() > 0)
                                MessageBox.Show("Thanh toán nợ hoàn tất. Khoản vay có kỳ hạn dưới 1 năm sẽ không phải chịu phí phạt.");
                        }
                    }
                    NH.SubmitChanges();
                }
                catch
                {
                    MessageBox.Show("178Không có thông tin khoản vay");
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}

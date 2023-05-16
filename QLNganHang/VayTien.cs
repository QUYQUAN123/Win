using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNganHang
{
    public partial class VayTien : Form
    {
        DataQLNganHangDataContext NH = new DataQLNganHangDataContext();
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.QLNganHangConnectionString1);
        public VayTien()
        {
            InitializeComponent();
            loadHinhThuc();
            loadKyHan();
        }
        
        private void loadHinhThuc()
        {
            comboHinhThuc.Items.Add("Tin Chap");
            comboHinhThuc.Items.Add("The Chap");
        }

        private void loadKyHan()
        {
            comboKyHan.Items.Add("3");
            comboKyHan.Items.Add("6");
            comboKyHan.Items.Add("7");
            comboKyHan.Items.Add("9");
            comboKyHan.Items.Add("12");
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string d = cccdtxt.Text;
            var item = (from u in NH.VayTiens
                        where u.Cccd == d
                        select u).FirstOrDefault();
            var item1 = (from u in NH.View_VayTiens
                        where u.Cccd == d
                        select u).FirstOrDefault();
            var item2 = (from u in NH.TaiKhoans
                         where u.Cccd == d
                         select u).FirstOrDefault();
            if (txbTienVay.Text == null)
            {
                MessageBox.Show("Vui lòng nhập số tiền cần vay!");
            }
            else if (comboKyHan.Text == null)
            {
                MessageBox.Show("Vui lòng nhập Kỳ hạn.");
            }
            else if (item1.ThuNhap < Convert.ToDecimal(txbTienVay.Text))
            {
                MessageBox.Show("Giao dịch thất bại! Số dư hiện có của bạn thấp hơn số tiền bạn muốn vay.");
            }
            else
            {
                try
                {
                    conn.Open();
                    DateTime now = DateTime.Now;
                    DateTime ngayTra = DateTime.Parse(txbNgayTra.Text);
                    int soSanh = ngayTra.CompareTo(now);
                    if (soSanh < 0)
                    {
                        string sqlStr = string.Format("INSERT INTO VayTien(MaKH,TenKH,SDT,Email,Cccd,DiaChi,ThuNhap,SoTienVay,HinhThucVay,TaiSanTheChap,KyHan,LaiXuat,NgayVay,NgayTra,NoXau) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}'," +
                            "'{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}')", txbMaKH.Text, txbTenKH.Text, txbSDT.Text, txbEmail.Text, cccdtxt.Text, txbDChi.Text, txbThuNhap.Text, txbTienVay.Text, comboHinhThuc.Text, txbTaiSanTheChap.Text, comboKyHan.Text, txbLaiXuat.Text, dateNgayVay.Text, txbNgayTra.Text,1);
                        item2.SoTienVay = Convert.ToDecimal(txbTienVay.Text);
                        SqlCommand cmd = new SqlCommand(sqlStr, conn);
                        if (cmd.ExecuteNonQuery() > 0)
                            MessageBox.Show("Vay tiền thành công!");
                    }
                    else
                    {
                        string sqlStr = string.Format("INSERT INTO VayTien(MaKH,TenKH,SDT,Email,Cccd,DiaChi,ThuNhap,SoTienVay,HinhThucVay,TaiSanTheChap,KyHan,LaiXuat,NgayVay,NgayTra,NoXau) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}'," +
                            "'{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}')", txbMaKH.Text, txbTenKH.Text, txbSDT.Text, txbEmail.Text, cccdtxt.Text, txbDChi.Text, txbThuNhap.Text, txbTienVay.Text, comboHinhThuc.Text, txbTaiSanTheChap.Text, comboKyHan.Text, txbLaiXuat.Text, dateNgayVay.Text, txbNgayTra.Text, 0);
                        item2.SoTienVay = Convert.ToDecimal(txbTienVay.Text);
                        SqlCommand cmd = new SqlCommand(sqlStr, conn);
                        if (cmd.ExecuteNonQuery() > 0)
                            MessageBox.Show("Vay Tiền Thành Công!");
                    }
                    NH.SubmitChanges();                   
                }
                catch
                {
                    MessageBox.Show("Không thể đăng ký vay tiền khi chưa hoàn tất khoản vay trước đó.");
                }
                finally
                {
                    conn.Close();
                }
            }            
        }

        private void btnLayThongTin_Click(object sender, EventArgs e)
        {
            string d = cccdtxt.Text;
            var item = (from u in NH.View_VayTiens
                        where u.Cccd == d
                        select u).FirstOrDefault();
            if(item == null)
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
            }           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboKyHan_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime ngayVay = DateTime.Parse(dateNgayVay.Text);
            int d = Convert.ToInt32(comboKyHan.Text);
            var item = (from u in NH.LaiXuats
                        where u.KyHan == d
                        select u).FirstOrDefault();
            txbLaiXuat.Text = Convert.ToString(item.LaiXuatVay);
            txbNgayTra.Text = Convert.ToString(ngayVay.AddMonths(d));
        }
    }
}

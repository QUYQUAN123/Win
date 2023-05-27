using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNganHang
{
    public partial class DKSoTietKiem : Form
    {
        QLNganHangEntities NH = new QLNganHangEntities();
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.QLNganHangConnectionString1);
        public DKSoTietKiem()
        {
            InitializeComponent();
            loadmode();
        }

        private void loadmode()
        {
            comboKyHan.Items.Add("3");
            comboKyHan.Items.Add("6");
            comboKyHan.Items.Add("7");
            comboKyHan.Items.Add("9");
            comboKyHan.Items.Add("12");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboKyHan_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal b = Convert.ToDecimal(comboKyHan.Text);
            var laiXuat = (from u in NH.LaiXuats
                           where u.KyHan == b
                           select u).FirstOrDefault();
            txbLaiXuat.Text = Convert.ToString(laiXuat.LaiXuatGui);
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            string d = tbxCCCD.Text;
            var item = (from u in NH.TaiKhoans
                        where u.Cccd == d
                        select u).FirstOrDefault();
            //var item = (from u in NH.SoTietKiems
            //            where u.Cccd == d
            //            select u).FirstOrDefault();
            if (item == null)
            {
                MessageBox.Show("Thông báo! Không có thông tin khách hàng.");
            }
            else
            {
                tbxTenKH.Text = item.TenKH;
                txbMaKH.Text = item.MaKH;
                tbxSDT.Text = item.SDT;
            }
        }

        private void btnDKSoTietKiem_Click(object sender, EventArgs e)
        {

            try
            {
                conn.Open();
                DateTime now = DateTime.Now;
                DateTime ngayGui = DateTime.Parse(dateNgayGui.Text);
                DateTime NgayDong = ngayGui.AddMonths(Convert.ToInt32(comboKyHan.Text));
                int soSanh = NgayDong.CompareTo(now);
                if (soSanh > 0)
                {
                    string sqlStr = string.Format("INSERT INTO SoTietKiem(MaSo,TenKH,MaKH,SDT, Cccd,TienGui,NgayGui,KyHan,LaiXuat,DaThanhToan) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}'," +
                        "'{7}','{8}','{9}')", tbxSTKTK.Text, tbxTenKH.Text, txbMaKH.Text, tbxSDT.Text, tbxCCCD.Text, tbxSoTienGui.Text, dateNgayGui.Text, comboKyHan.Text, txbLaiXuat.Text, 0);
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    if (cmd.ExecuteNonQuery() > 0)
                        MessageBox.Show("Mở sổ thành công!");
                }
                else
                {
                    string sqlStr = string.Format("INSERT INTO SoTietKiem(MaSo,TenKH,MaKH,SDT, Cccd,TienGui,NgayGui,KyHan,LaiXuat,DaThanhToan) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}'," +
                        "'{7}','{8}','{9}')", tbxSTKTK.Text, tbxTenKH.Text, txbMaKH.Text, tbxSDT.Text, tbxCCCD.Text, tbxSoTienGui.Text, dateNgayGui.Text, comboKyHan.Text, txbLaiXuat.Text, 1);
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    if (cmd.ExecuteNonQuery() > 0)
                        MessageBox.Show("Mở sổ thành công!");
                    NH.SaveChanges();
                    string d = txbMaKH.Text;
                    var item = (from u in NH.TaiKhoans
                                where u.MaKH == d
                                select u).FirstOrDefault();
                    decimal temp = Convert.ToDecimal(tbxSoTienGui.Text) + ((Convert.ToDecimal(tbxSoTienGui.Text) * Convert.ToDecimal(txbLaiXuat.Text)
                        * Convert.ToDecimal(comboKyHan.Text)) / 100);
                    item.SoDu += temp;
                }
                NH.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("them that bai" + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        private void txbLaiXuat_TextChanged(object sender, EventArgs e)
        {

        }

        private void DKSoTietKiem_Load(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbxTenKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxSTKTK_TextChanged(object sender, EventArgs e)
        {

        }

        private void textMaKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxCCCD_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}

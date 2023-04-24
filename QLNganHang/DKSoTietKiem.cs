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
        DataQLNganHangDataContext NH = new DataQLNganHangDataContext();
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

        private void txbLaiXuat_TextChanged(object sender, EventArgs e)
        {

        }

        private void DKSoTietKiem_Load(object sender, EventArgs e)
        {

        }

     

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("INSERT INTO SoTietKiem(MaSo,TenKH,MaKH,SDT, Cccd,TienGui,NgayGui,KyHan,LaiXuat,DaThanhToan) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}'," +
                    "'{7}','{8}','{9}')", tbxSTKTK.Text, tbxTenKH.Text, textMaKH.Text, tbxSDT.Text, tbxCCCD.Text, tbxSoTienGui.Text, txbNgayGui.Text, comboKyHan.Text, txbLaiXuat.Text, tbxThanhToan.Text);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("them thanh cong");
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            fMain f = new fMain();
            f.ShowDialog();
            this.Close();
        }
    }
}

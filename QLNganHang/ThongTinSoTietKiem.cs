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
    public partial class ThongTinSoTietKiem : Form
    {
        DataQLNganHangDataContext NH = new DataQLNganHangDataContext();
        public ThongTinSoTietKiem()
        {
            InitializeComponent();
        }

        //dhdcc
        

        private void gridviewThanhToan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ThongTinSoTietKiem_Load(object sender, EventArgs e)
        {

        }

        private void tbxMaKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnGuiTien_Click_1(object sender, EventArgs e)
        {
            GuiTien dt = new GuiTien();
            dt.ShowDialog();
        }

        private void btnDKMoSoTK_Click_1(object sender, EventArgs e)
        {
            DKSoTietKiem dk = new DKSoTietKiem();
            dk.ShowDialog();
        }

        private void btnThanhToan_Click_1(object sender, EventArgs e)
        {
            ThanhToanSoTK tt = new ThanhToanSoTK();
            tt.ShowDialog();
        }

        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            string d = tbxMaKH.Text;
            var item = (from u in NH.SoTietKiems
                        where u.MaKH == d
                        select u).ToList();
            gridviewThanhToan.DataSource = item;
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

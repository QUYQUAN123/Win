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
        QLNganHangEntities NH = new QLNganHangEntities();
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
            string d = tbxCccd.Text;
            var item = (from u in NH.SoTietKiems
                        where u.Cccd == d
                        select u).ToList();
            gridviewThanhToan.DataSource = item;
            gridviewThanhToan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ThongTinSoTietKiem_Load_1(object sender, EventArgs e)
        {

        }
    }
}

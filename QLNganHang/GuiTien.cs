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
            //loadmode();
        }

        private void loaddate()
        {
            txtDate.Text = DateTime.UtcNow.ToString("dd/mm/yyyy");
        }

        //private void loadmode()
        //{
        //    comboKyHan.Items.Add("3");
        //    comboKyHan.Items.Add("6");
        //    comboKyHan.Items.Add("7");
        //    comboKyHan.Items.Add("9");
        //}

        //private void btnLayThongTin_Click(object sender, EventArgs e)
        //{
            //string d = tbxstktk.text;
            //var item = (from u in nh.view_guitiens
            //            where u.maso == d
            //            select u).firstordefault();
            //tbxtenkh.text = item.tenkh;
            //tbxsdt.text = item.sdt;
            //tbxcccd.text = item.cccd;
            //tbxsodu.text = convert.tostring(item.tiengui);
            //comboKyHan.Text = Convert.ToString(item.KyHan);
            //lbLaiXuat.Text = Convert.ToString(item.LaiXuat);
        //}

        //private void comboKyHan_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    decimal b = Convert.ToDecimal(comboKyHan.Text);
        //    var laiXuat = (from u in NH.LaiXuats
        //                   where u.KyHan == b
        //                   select u).FirstOrDefault();
        //    lbLaiXuat.Text = Convert.ToString(laiXuat.LaiXuatGui);
        //    tbxTienLai.Text = Convert.ToString((Convert.ToDecimal(laiXuat.LaiXuatGui) * Convert.ToDecimal(tbxSoTienGui.Text) * Convert.ToDecimal(laiXuat.KyHan)) / 100);
        //    //tbxTienLai.Text = Convert.ToString(t);
        //}

        //private void btnLuu_Click(object sender, EventArgs e)
        //{
            //string d = tbxSTKTK.Text;
            //var item = (from u in NH.SoTietKiems
            //            where u.MaSo == d
            //            select u).FirstOrDefault();
            //if (Convert.ToInt32(tbxSoTienGui.Text) == 0)
            //{
            //    MessageBox.Show("Vui lòng nhập số tiền trên 500.000 VNĐ.");
            //}
            //else
            //{
            //    item.TienGui = item.TienGui + Convert.ToDecimal(tbxSoTienGui.Text);
            //    NH.SubmitChanges();
            //    MessageBox.Show("Giao dịch gửi tiền thành công!");
            //}
        //}

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void GuiTien_Load(object sender, EventArgs e)
        {

        }

        private void tbxTienLai_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLayThongTin_Click(object sender, EventArgs e)
        {
            string d = tbxSTKTK.Text;
            var item = (from u in NH.View_GuiTiens
                        where u.MaSo == d
                        select u).FirstOrDefault();
            tbxTenKH.Text = item.TenKH;
            tbxSDT.Text = item.SDT;
            tbxCCCD.Text = item.Cccd;
            tbxSoDU.Text = Convert.ToString(item.TienGui);
        }

        private void btnLuu_Click(object sender, EventArgs e)
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

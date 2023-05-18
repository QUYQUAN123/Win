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
    public partial class DSden : Form
    {
        DataQLNganHangDataContext NH = new DataQLNganHangDataContext();
        public DSden()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {         
            
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            var item1 = (from u in NH.VayTiens
                         where u.NoXau == 1
                         select new
                         {
                             u.TenKH,
                             u.SDT,
                             u.Cccd,
                             u.DiaChi,
                             u.SoTienVay,
                             u.HinhThucVay,
                             u.TaiSanTheChap,
                             u.KyHan,
                             u.LaiXuat,
                             u.NgayVay,
                             u.NgayTra,
                         }).ToList();

            gridDSDen.DataSource = item1;

            // Thiết lập auto-size cho các cột
            gridDSDen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btnDongPhat_Click(object sender, EventArgs e)
        {

        }

        private void DSden_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class LichSuGiaoDich : Form
    {
       
        public LichSuGiaoDich()
        {
            InitializeComponent();
        }

        private void LichSuGiaoDich_Load(object sender, EventArgs e)
        {

        }

      
        private void LoadLichSuGiaoDich(string soTK)
        {
            DataTable data = LsGiaoDichDAO.Instance.LayLichSuGiaoDich(soTK);
            gvLSGD.DataSource = data;
        }

       
        private void btnTim_Click(object sender, EventArgs e)
        {
            string soTK = txbSoTK.Text;
            LoadLichSuGiaoDich(soTK);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

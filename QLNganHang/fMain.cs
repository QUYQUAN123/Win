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
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void PBTinDung_Click(object sender, EventArgs e)
        {
            this.Hide();
            fTinDung f = new fTinDung();
            f.ShowDialog();
            this.Close();
        }

        private void PBMoSoTK_Click(object sender, EventArgs e)
        {
            this.Hide();
            DKSoTietKiem f = new DKSoTietKiem();
            f.ShowDialog();
            this.Close();
        }
    }
}

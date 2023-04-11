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
    public partial class fTK : Form
    {
        public fTK()
        {
            InitializeComponent();
        }

        private void btnDKSoTK_Click(object sender, EventArgs e)
        {
            DKSoTietKiem dk = new DKSoTietKiem();
            dk.ShowDialog();
        }

        private void btnGuiTien_Click(object sender, EventArgs e)
        {
            GuiTien g = new GuiTien();
            g.ShowDialog();
        }
    }
}

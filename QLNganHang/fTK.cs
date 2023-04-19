<<<<<<< HEAD:QLNganHang/fSoTietKiem.cs
﻿using System;
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

        private void fTK_Load(object sender, EventArgs e)
        {

        }
    }
}
=======
﻿using System;
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
>>>>>>> 48bff07284efaca85d2f6840f603b4c4b1aa2ced:QLNganHang/fTK.cs

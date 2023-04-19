using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNganHang
{
    public partial class fKiemTraTD : Form
    {
        DataQLNganHangDataContext db = new DataQLNganHangDataContext();

        List<CheckBox> listCheckbox = new List<CheckBox>();

        public fKiemTraTD()
        {
            InitializeComponent();

            listCheckbox.Add(checkBox1);
            listCheckbox.Add(checkBox2);
            listCheckbox.Add(checkBox3);
        }

        private void fKiemTraTD_Load(object sender, EventArgs e)
        {
            db = new DataQLNganHangDataContext();
            gvTD.DataSource = db.TinDungs;
        }

        private void gvTD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = gvTD.CurrentRow.Index;
            txtSTD.Text = gvTD.Rows[i].Cells[0].Value.ToString();
            txtHoTen.Text = gvTD.Rows[i].Cells[1].Value.ToString();
            dateTimePicker1.Text = gvTD.Rows[i].Cells[6].Value.ToString();
            txtSN.Text = gvTD.Rows[i].Cells[8].Value.ToString();

            for (int x = 0; x < 3; x++)
            {
                listCheckbox[x].Checked = false;
            }

            for (int k = 0; k < int.Parse(gvTD.Rows[i].Cells[10].Value.ToString()); k++)
            {
                listCheckbox[k].Checked = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            var tindung = (from td in db.TinDungs
                           where td.MaTD == gvTD.Rows[gvTD.CurrentRow.Index].Cells[0].Value.ToString()
                           select td).FirstOrDefault();

            if (checkBox1.Checked)
            {
                tindung.SoLan = 1.ToString();

            }
            else
            {
                tindung.SoLan = 0.ToString();
            }

            db.SubmitChanges();
        }

        private void checkBox2_Click(object sender, EventArgs e)
        {
            var tindung = (from td in db.TinDungs
                           where td.MaTD == gvTD.Rows[gvTD.CurrentRow.Index].Cells[0].Value.ToString()
                           select td).FirstOrDefault();

            if (checkBox2.Checked && checkBox1.Checked)
            {
                tindung.SoLan = 2.ToString();
            }
            else
            {
                MessageBox.Show(" Phai tich lan 1");
                tindung.SoLan = 0.ToString();
                checkBox2.Checked = false;
            }

            db.SubmitChanges();
        }

        private void checkBox3_Click(object sender, EventArgs e)
        {
            var tindung = (from td in db.TinDungs
                           where td.MaTD == gvTD.Rows[gvTD.CurrentRow.Index].Cells[0].Value.ToString()
                           select td).FirstOrDefault();

            if (checkBox3.Checked && checkBox2.Checked)
            {
                tindung.SoLan = 3.ToString();
            }
            else
            {
                MessageBox.Show(" Phai tich lan 2");
                tindung.SoLan = 1.ToString();
                checkBox3.Checked = false;
            }

            db.SubmitChanges();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {

            var a = db.TinDungs.Where(s => s.MaTD == txtSTD.Text).Single();
            DateTime dateTime = Convert.ToDateTime(a.NgayTra);

            db.SubmitChanges();

        }

        private void btnChuyen_Click(object sender, EventArgs e)
        {
            this.Hide();
            fNoTinDung f = new fNoTinDung();
            f.ShowDialog();
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}


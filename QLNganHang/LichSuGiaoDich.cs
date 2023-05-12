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
        DataQLNganHangDataContext db = new DataQLNganHangDataContext();
        public LichSuGiaoDich()
        {
            InitializeComponent();
        }
        private string sotk;

        private void LichSuGiaoDich_Load(object sender, EventArgs e)
        {

        }

      
        private void LoadLichSuGiaoDich(string soTK)
        {
            DataTable data = LsGiaoDichDAO.Instance.LayLichSuGiaoDich(soTK);
            gvLSGD.DataSource = data;
            gvLSGD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gvLSGD.AutoResizeColumns();
        }
        public string Chia()
        {
            string nhapTim = txbnhaptim.Text.ToLower();

            if (nhapTim.StartsWith("tk"))
            {
                return nhapTim;
            }
            else
            {
                string cccd = nhapTim;
                string sotk = (from tk in db.TaiKhoans
                               where tk.Cccd == cccd
                               select tk.SoTK).FirstOrDefault();

                return sotk != null ? sotk : "Không tìm thấy Sotk trong cơ sở dữ liệu.";
            }
        }



        private void btnTim_Click(object sender, EventArgs e)
        {
            string soTK = Chia();

            if (soTK != "Không tìm thấy Sotk trong cơ sở dữ liệu.")
            {
                LoadLichSuGiaoDich(soTK);
            }
            else
            {
                MessageBox.Show("Không tìm thấy dữ liệu.");
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

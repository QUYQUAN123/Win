using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNganHang
{
    internal class NhanVienDAO
    {
        private static NhanVienDAO instance;

        public static NhanVienDAO Instance
        {
            get { if (instance == null) instance = new NhanVienDAO(); return NhanVienDAO.instance; }
            private set { NhanVienDAO.instance = value; }
        }

        private NhanVienDAO() { }
        public List<NhanVien> ThongTinNV(string cccd)
        {
            List<NhanVien> lst = new List<NhanVien>();

            // Truy vấn khách hàng theo CCCD
            string query = $"SELECT * FROM NhanVien WHERE CCCD = '{cccd}'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            
            foreach (DataRow row in data.Rows)
            {
                NhanVien nv = new NhanVien();
                nv.MaNV = row["MaNV"].ToString();
                nv.TenNV = row["TenNV"].ToString();
                nv.NgaySinh = DateTime.Parse(row["NgaySinh"].ToString());
                nv.SDT = row["SDT"].ToString();
                nv.Email = row["Email"].ToString();
                nv.CCCD = row["CCCD"].ToString();
                nv.DiaChi = row["DiaChi"].ToString();
               
                lst.Add(nv);
            }

            return lst;
        }
        public bool CapNhatThongTinNhanVien(NhanVien nv)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn cập nhật thông tin nhân viên này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Nếu người dùng chọn "Yes"
            if (result == DialogResult.Yes)
            {
                // Cập nhật thông tin nhân viên vào cơ sở dữ liệu
                string query = $"UPDATE NhanVien SET TenNV = '{nv.TenNV}', NgaySinh = '{nv.NgaySinh.ToString("yyyy-MM-dd")}', SDT = '{nv.SDT}', Email = '{nv.Email}', DiaChi = '{nv.DiaChi}' WHERE MaNV = '{nv.MaNV}'";
                int resultUpdate = DataProvider.Instance.ExecuteNonQuery(query);

                // Kiểm tra kết quả cập nhật
                if (resultUpdate > 0)
                {
                    return true;
                }
            }

            // Nếu người dùng chọn "No" hoặc cập nhật không thành công
            return false;
        }

    }
}

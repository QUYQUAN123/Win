using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNganHang
{
    internal class KhachHangDAO
    {
        private static KhachHangDAO instance;

        public static KhachHangDAO Instance
        {
            get { if (instance == null) instance = new KhachHangDAO(); return KhachHangDAO.instance; }
            private set { KhachHangDAO.instance = value; }
        }

        private KhachHangDAO() { }


        public bool ThemKhachHang(string maKH, string tenKH, DateTime ngaySinh, string sdt, string email, string cccd, string diaChi, Decimal thuNhap)
        {
            // Tạo đối tượng KhachHang từ các thông tin trên form
            KhachHang khachHang = new KhachHang(maKH, tenKH, ngaySinh, sdt, email, cccd, diaChi, thuNhap);

            // Thực hiện câu lệnh INSERT để thêm khách hàng vào cơ sở dữ liệu
            string query = $"INSERT INTO KhachHang (MaKH, TenKH, NgaySinh, SDT, Email, Cccd, DiaChi, ThuNhap) VALUES ('{maKH}', '{tenKH}', '{ngaySinh.ToString("yyyy-MM-dd")}', '{sdt}', '{email}', '{cccd}', '{diaChi}', '{thuNhap}')";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            // Trả về kết quả thực hiện thêm khách hàng
            return result > 0;
        }
        public bool KiemTraCCCD(string cccd)
        {
            string query = $"SELECT COUNT(*) FROM KhachHang WHERE Cccd = '{cccd}'";
            int count = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
            return count > 0;
        }
        public List<KhachHang> TimKhachHangTheoCCCD(string cccd)
        {
            List<KhachHang> lst = new List<KhachHang>();

            // Truy vấn khách hàng theo CCCD
            string query = $"SELECT * FROM KhachHang WHERE Cccd = '{cccd}'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);


            foreach (DataRow row in data.Rows)
            {
                KhachHang kh = new KhachHang();
                kh.MaKH = row["MaKH"].ToString();
                kh.TenKH = row["TenKH"].ToString();
                kh.NgaySinh = DateTime.Parse(row["NgaySinh"].ToString());
                kh.SDT = row["SDT"].ToString();
                kh.Email = row["Email"].ToString();
                kh.CCCD = row["Cccd"].ToString();
                kh.DiaChi = row["DiaChi"].ToString();
                kh.ThuNhap = Decimal.Parse(row["ThuNhap"].ToString());
                lst.Add(kh);
            }

            return lst;
        }


        public bool CapNhatThongTinKhachHang(KhachHang kh)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn cập nhật thông tin này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Nếu người dùng chọn "Yes"
            if (result == DialogResult.Yes)
            {

                string query = $"UPDATE KhachHang SET TenKH = '{kh.TenKH}', NgaySinh = '{kh.NgaySinh.ToString("yyyy-MM-dd")}', SDT = '{kh.SDT}', Email = '{kh.Email}', DiaChi = '{kh.DiaChi}',ThuNhap ='{kh.ThuNhap}' WHERE MaKH = '{kh.MaKH}'";

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
        public bool XoaKhachHangTheoCCCD(string cccd)
        {
            // Kiểm tra khách hàng có tồn tại trong cơ sở dữ liệu không
            if (!KiemTraCCCD(cccd))
            {
                MessageBox.Show("Khách hàng không tồn tại trong cơ sở dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Nếu người dùng chọn "Yes"
            if (result == DialogResult.Yes)
            {
                // Thực hiện câu lệnh DELETE để xóa khách hàng khỏi cơ sở dữ liệu
                string query = $"DELETE FROM KhachHang WHERE Cccd = '{cccd}'";
                int resultDelete = DataProvider.Instance.ExecuteNonQuery(query);

                // Kiểm tra kết quả xóa
                if (resultDelete > 0)
                {
                    MessageBox.Show("Xóa khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Xóa khách hàng không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            // Nếu người dùng chọn "No"
            return false;
        }


        public string SinhSoMa()
        {
            string maKH;
            Random random = new Random();

            do
            {
                // Sinh ngẫu nhiên 4 chữ số
                int randomNumber = random.Next(1000, 10000);
                maKH = "KH" + randomNumber.ToString();
            } while (KiemTraTrungMaKH(maKH)); // Kiểm tra tính duy nhất

            return maKH;
        }

        private bool KiemTraTrungMaKH(string maKH)
        {
            string query = $"SELECT COUNT(*) FROM KhachHang WHERE MaKH = '{maKH}'";
            int count = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
            return count > 0;
        }



    }
}

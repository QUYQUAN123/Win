using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNganHang
{
    internal class LsGiaoDichDAO
    {
        private static LsGiaoDichDAO instance;

        public static LsGiaoDichDAO Instance
        {
            get { if (instance == null) instance = new LsGiaoDichDAO(); return LsGiaoDichDAO.instance; }
            private set { LsGiaoDichDAO.instance = value; }
        }

        private LsGiaoDichDAO() { }
        private string TaoMaGiaoDich()
        {
            string magd = "";
            Random rand = new Random();
            do
            {
                magd = rand.Next(100000, 999999).ToString();
            } while (KiemTraMaGiaoDichTonTai(magd));
            return magd;
        }

        // Hàm kiểm tra MaGD đã tồn tại hay chưa
        private bool KiemTraMaGiaoDichTonTai(string magd)
        {
            string query = "SELECT COUNT(*) FROM LichSuGiaoDich WHERE MaGD = @magd";
            int count = (int)DataProvider.Instance.ExecuteScalar(query, new object[] { magd });
            return count > 0;
        }

        // Hàm lấy lịch sử giao dịch của tài khoản có Sotk
        public DataTable LayLichSuGiaoDich(string sotk)
        {
            DataTable data = new DataTable();
            string query = "SELECT MaGD,TenKH,SoTK, SoTienGiaoDich, NoiDungGiaoDich " +
                   "FROM LichSuGiaoDich WHERE SoTK = @sotk";
            data = DataProvider.Instance.ExecuteQuery(query, new object[] { sotk });
            return data;


        }
        // Hàm thêm giao dịch vào danh sách lịch sử
        public bool ThemLichSuGiaoDich(string tenKH, double soTien, string soTK, string noiDung)
        {
            // Lấy mã giao dịch mới
            string maGD = TaoMaGiaoDich();

            // Thực hiện câu lệnh INSERT
            string query = $"INSERT INTO LichSuGiaoDich (MaGD, TenKH, SoTK, SoTienGiaoDich, NoiDungGiaoDich) VALUES ('{maGD}', '{tenKH}', '{soTK}', {soTien}, '{noiDung}')";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maGD, tenKH, soTK, soTien, noiDung });

            return result > 0;
        }




    }

}


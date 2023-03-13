using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNganHang
{
    internal class ThongTinKhacHang
    {
        public ThongTinKhacHang(string maKH,string tenKH, string ngaysinh, string sdt, string email, string cccd, string diachi ) {
        
            this.MaKH = maKH;
            this.TenKH = tenKH;
            this.NgaySinh = ngaysinh;
            this.SDT = sdt;
            this.Email = email;
            this.Cccd = cccd;
            this.DiaChi = diachi;
        }
        public ThongTinKhacHang(DataRow row)
        {
            this.MaKH = row["MaKH"].ToString();
            this.TenKH = row["TenKH"].ToString();
            this.NgaySinh = row["NgaySinh"].ToString();
            this.SDT = row["SDT"].ToString() ;
            this.Email = row["Email"].ToString();
            this.Cccd = row["Cccd"].ToString();
            this.DiaChi = row["DiaChi"].ToString();

        }
        private string maKH;
        public string MaKH
        {
            get { return maKH; }
            set { maKH = value; }
        } 
        private string tenKH;
        public string TenKH
        { get { return tenKH; } set { tenKH = value; } }
        private string ngaysinh;
        public string NgaySinh
        { get { return ngaysinh; } set{ ngaysinh = value; } }
        private string sdt;
        public string SDT
        { get { return sdt; } set {  sdt = value; } }
        private string email;
        public string Email
        { get { return email; } set {  email = value; } }
        private string cccd;
        public string Cccd
        { get { return cccd; } set {  cccd = value; } }
        private string diachi;
        public string DiaChi
        { get { return diachi; } set  { diachi = value; } }
    }
}

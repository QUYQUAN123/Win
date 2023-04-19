using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNganHang
{
        internal class KhachHang
        {
            public string MaKH { get; set; }
            public string TenKH { get; set; }
            public DateTime NgaySinh { get; set; }
            public string SDT { get; set; }
            public string Email { get; set; }
            public string CCCD { get; set; }
            public string DiaChi { get; set; }
            public Decimal ThuNhap { get; set; }

            public KhachHang()
            {
            }

            public KhachHang(string maKH, string tenKH, DateTime ngaySinh, string sdt, string email, string cccd, string diaChi, Decimal thuNhap)
            {
                MaKH = maKH;
                TenKH = tenKH;
                NgaySinh = ngaySinh;
                SDT = sdt;
                Email = email;
                CCCD = cccd;
                DiaChi = diaChi;
                ThuNhap = thuNhap;
            }
        }
    
}

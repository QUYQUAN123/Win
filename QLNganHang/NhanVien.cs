using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNganHang
{
    public partial class NhanVien
    {
            public string MaNV { get; set; }
            public string TenNV { get; set; }
            public DateTime NgaySinh { get; set; }
            public string SDT { get; set; }
            public string Email { get; set; }
            public string CCCD { get; set; }
            public string DiaChi { get; set; }
           

            public NhanVien()
            {
            }

            public NhanVien(string maNV, string tenNV, DateTime ngaySinh, string sdt, string email, string cccd, string diaChi, double thuNhap)
            {
                MaNV = maNV;
                TenNV =tenNV;
                NgaySinh = ngaySinh;
                SDT = sdt;
                Email = email;
                CCCD = cccd;
                DiaChi = diaChi;
                
            }
        
    }
}

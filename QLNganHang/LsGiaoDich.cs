using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNganHang
{
    internal class LsGiaoDich
    {
            public string MaGD { get; set; }
            public string TenKH { get; set; }
            public string SoTK { get; set; }
            public double SoTienGiaoDich { get; set; }
            public string NoiDungGiaoDich { get; set; }

            public LsGiaoDich() { }

            public LsGiaoDich(string MaGD,string tenKH, string soTK, double soTienGiaoDich, string noiDungGiaoDich)
            {
                this.MaGD = MaGD;
                this.TenKH = tenKH;
                this.SoTK = soTK;
                this.SoTienGiaoDich = soTienGiaoDich;
                this.NoiDungGiaoDich = noiDungGiaoDich;
            }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNganHang
{
    internal class ThongTinKhacHangDAO
    {
        private static ThongTinKhacHangDAO instance;

        public static ThongTinKhacHangDAO Instance
        {
            get { if (instance == null) instance = new ThongTinKhacHangDAO(); return ThongTinKhacHangDAO.instance; }
            private set { ThongTinKhacHangDAO.instance = value; }
        }

        private ThongTinKhacHangDAO() { }

    }
}

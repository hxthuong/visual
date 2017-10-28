using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class HoaDon
    {
        Ve gomve;
        public Ve Gomve
        {
            get { return gomve; }
            set { gomve = value; }
        }
        KhachHang cuaKH;
        public KhachHang CuaKH
        {
            get { return cuaKH; }
            set { cuaKH = value; }
        }
        public HoaDon(Ve gomve,KhachHang cuaKH)
        {
            Gomve = gomve;
            CuaKH = cuaKH;
        }
        public double TienPT()
        {
            return Gomve.Gia - Gomve.Giamgia();
        }
        public void TimKiem(string hoten, string sohieu)
        {
            if ((hoten == Gomve.HK.Hoten) && (sohieu == Gomve.Sohieu))
                Console.Write("\n So dien thoai cua hanh khach ten {0} co so hieu CB {1} la {2}", hoten, sohieu, CuaKH.SDT);
        }
        public override string ToString()
        {
            return string.Format("\n Thong tin KH: {0}   \n Thong tin ve: {1}   \n So tien PT: {2}",CuaKH.ToString(),Gomve.ToString(),TienPT());
        }
    }
}

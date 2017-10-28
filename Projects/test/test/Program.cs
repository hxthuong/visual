using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main()
        {
            double tong = 0;
            List<HoaDon> hoadon = new List<HoaDon>();
            hoadon.Add(new HoaDon(new Ve("1A", "Tp HCM ", "Hue", 1000, new HanhKhach("Hong", "3456723452", 20)), new KhachHang("Lan", "123456789")));
            hoadon.Add(new HoaDon(new Ve("1A", "Ha Tinh", "Hue", 1000, new HanhKhach("Linh", "02345678934", 3)), new KhachHang("Lan", "123456789")));
            foreach (HoaDon hd in hoadon)
            {
                hd.TimKiem("Hong", "1A");
                tong += hd.TienPT();
                Console.Write(hd);
             }
            Console.Write("\n Tong so tien la: {0}", tong);
            Console.ReadKey();
        }
    }
}

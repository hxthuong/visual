using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong_trinh_ban_ve
{
    class Program
    {
        enum Loai {VeThuong,VEVIP };
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Chuong trinh ban ve xem phim");
                Console.WriteLine("1. Hien thi");
                Console.WriteLine("2. In ve");
                Console.WriteLine("3. Thong tin thong ke");
                Console.WriteLine("4. Exit/n");
                Console.WriteLine("Choose an Action: ");
                string c = Console.ReadLine();

                string tenrap = Console.ReadLine();
                string diachirap = Console.ReadLine();
                string tenphim = Console.ReadLine();
                int ngay = int.Parse(Console.ReadLine());
                int thang = int.Parse(Console.ReadLine());
                int nam = int.Parse(Console.ReadLine());
                int gio = int.Parse(Console.ReadLine());
                int phut = int.Parse(Console.ReadLine());
                string mave = Console.ReadLine();
                double giave = double.Parse(Console.ReadLine());
                int soluong = int.Parse(Console.ReadLine());
                int loai = int.Parse(Console.ReadLine());

                switch (c)
                {
                    case "1":	// In thông tin ra àn hình
                        {
                            Input("Mã vé:", ref mave);
                            Input("Tên rạp:", ref tenrap);
                            Input("Địa chỉ rạp:", ref diachirap);
                            Input("Tên phim:", ref tenphim);
                            Input("Ngày:", ref ngay);
                            Input("Tháng:", ref thang);
                            Input("Năm:", ref nam);
                            Input("Giờ:", ref gio);
                            Input("Phút:", ref phut);
                            Input("Giá vé:", ref giave);
                            Input("Số lượng:", ref soluong);
                            Loaive("Loại vé:", ref loai);
                            Danhsachphim p = new Danhsachphim(tenrap, diachirap, tenphim, ngay, thang, nam, gio, phut);
                            Console.WriteLine("Mời chọn rạp:");
                            p.DSRap();
                            Console.WriteLine("Mời chọn phim:");
                            p.LayDSPhim();
                            p.DSNgayChieu();
                            p.LayDSVe();
                            break;
                        }

                    case "2":	// In vé
                        {
                            Input("Mã vé:", ref mave);
                            Input("Tên rạp:", ref tenrap);
                            Input("Địa chỉ rạp:", ref diachirap);
                            Input("Tên phim:", ref tenphim);
                            Input("Ngày:", ref ngay);
                            Input("Tháng:", ref thang);
                            Input("Năm:", ref nam);
                            Input("Giờ:", ref gio);
                            Input("Phút:", ref phut);
                            Input("Giá vé:", ref giave);
                            Input("Số lượng:", ref soluong);
                            Loaive("Loại vé:", ref loai);
                            Ve ve = new Ve(mave, tenrap, diachirap, tenphim, ngay, thang, nam, gio, phut, giave);
                            Console.Write(ve.HienThi());
                            break;
                        }

                    case "3":	// Thông tin thống kế
                        {
                            Input("Mã vé:", ref mave);
                            Input("Tên rạp:", ref tenrap);
                            Input("Địa chỉ rạp:", ref diachirap);
                            Input("Tên phim:", ref tenphim);
                            Input("Ngày:", ref ngay);
                            Input("Tháng:", ref thang);
                            Input("Năm:", ref nam);
                            Input("Giờ:", ref gio);
                            Input("Phút:", ref phut);
                            Input("Giá vé:", ref giave);
                            Input("Số lượng:", ref soluong);
                            Loaive("Loại vé:", ref loai);
                            Ve ve = new Ve(mave, tenrap, diachirap, tenphim, ngay, thang, nam, gio, phut, giave);
                            Danhsachphim dsp = new Danhsachphim(tenrap, diachirap, tenphim, ngay, thang, nam, gio, phut);
                            Console.Write("Loai va so luong ve da ban va con lai trong ngay:");
                            ve.SLConLai();
                            Console.Write("Danh sach cac ve con lai trong ngay:");
                            dsp.LayDSVe();
                            Console.WriteLine("Danh sach cac bo phim dang chieu va sap chieu:");
                            dsp.DSNgayChieu();
                            Console.WriteLine("Danh sach cac rap tham gia vao he thong:");
                            dsp.DSRap();
                            break;
                        }

                    case "4":
                        break;
                }
                }
            }
        static void Input(string message, ref string var)
        {
            Console.WriteLine("{0} : ", message);
            var = Console.ReadLine();
        }
        static void Input(string message, ref int var)
        {
            Console.WriteLine("{0} : ", message);
            var = int.Parse(Console.ReadLine());
        }

        static void Input(string message, ref double var)
        {
            Console.WriteLine("{0} : ", message);
            var = double.Parse(Console.ReadLine());
        }
        static void Loaive(string message,ref int var)
        {
            Console.WriteLine("{0}:",message);
            var = int.Parse(Console.ReadLine());
            if (var == (int)Loai.VeThuong)
                Console.Write("Vé Thường");
            else
                Console.Write("Vé VIP");
        }
        
    }
}

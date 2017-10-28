using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CTbanve
{
    public class HeThong
    {
        static void Main(string[] arg)
        {
         
            Phim phim = new Phim(tenrap,diachirap,tenphim,thoigianchieu,mave,giave,loaive,string);

            while (true)
            {
                Console.WriteLine();
                Console.Write("CHUONG TRINH QUAN LY BAN VE XEM PHIM");
                Console.WriteLine();
                Console.WriteLine("1 - Hien thi danh sach phim dang chieu");
                Console.WriteLine("2 - Hien thi danh sach phim sap chieu");
                Console.WriteLine("3 - Danh sach rap tham gia vao he thong");
                Console.WriteLine("4 - Thoat");
                Console.WriteLine("Hay chon so tu 1 den 4 phu hop voi chuc nang tuong ung.");
                Console.Write("Ban chon so : ");
                string c = Console.ReadLine();
                switch (c)
                {
                    case "1": // Danh sach phim dang chieu
                        phim.DanhsachDangchieu();
                        break;
                    case "2": // Danh sach phim sap chieu
                        phim.DanhsachSapchieu();
                        break;
                    case "3": // Danh sach cac rap tham gia he thong
                        break;
                    case "4": 
                        break;
                }
            }
        }
    }
}
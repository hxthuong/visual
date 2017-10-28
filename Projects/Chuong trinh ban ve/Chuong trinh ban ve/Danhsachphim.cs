using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Chuong_trinh_ban_ve
{
    public class Danhsachphim:Phim
    {
        ThoiGian ngaychieu;
        ThoiGian giochieu;
        public void LayDSPhim()
        {
            List<Phim> phim = new List<Phim>();
            string p = "";
            using (StreamReader rd = new StreamReader("dsphim.txt"))
            {
                while ((p = rd.ReadLine()) != null)
                {
                    Console.WriteLine("Danh sach ten phim:{0}",p.Substring(2,30));
                }
            }
        }
        public Danhsachphim(string tenrap,string diachirap,string tenphim,int ngay, int thang, int nam, int gio, int phut)
                                                                             :base(tenrap,diachirap,tenphim,ngay,thang,nam,gio,phut)
          {
            ngaychieu = new ThoiGian(ngay, thang, nam);
            giochieu = new ThoiGian(gio, phut);
          }
        public void DSRap()
        {
            string r = "";
            List<Phim> dsrap = new List<Phim>();
            using (StreamReader rap = new StreamReader("dsphim.txt"))
            {
                while ((r = rap.ReadLine()) != null)
                {
                    Console.WriteLine("Danh sach rap:{1}",r.Substring(65));
                }
            }            
        }
 
        public void DSNgayChieu()
        {
            string t = "";
            //string tm = t.Substring(44, 4);
            List<ThoiGian> dsngaychieu = new List<ThoiGian>();
            List<string> dangchieu = new List<string>();
            List<string> sapchieu = new List<string>();
            string[] xuat = new string[3];
            xuat[0] = t.Substring(44, 4);
            xuat[1] = t.Substring(51, 4);
            xuat[2] = t.Substring(58,4);

            using (StreamReader time = new StreamReader("dsphim.txt"))
            {
                while ((t = time.ReadLine()) != null)
                {
                    string t1 = t.Substring(32,2);
                    int t2 = int.Parse(t1);
                    if (t2 <= 03)
                    {
                        dangchieu.Add(t.Substring(0, 42) + xuat + t.Substring(65));
                    }
                    else
                    {
                        sapchieu.Add(t.Substring(0, 42) + xuat + t.Substring(65));
                    }
                }
            }
        }
        public override void LayDSVe()
        {
            List<Ve> ve = new List<Ve>();
            foreach (Ve v in ve)
                Console.Write("{0}-{1}-{2}-[3}-{4}-{5}",v.Mave, v.Tenrap, v.Diachirap, v.Tenphim, ngaychieu,giochieu,v.Soluong,v.Giave);
        }
    }
}
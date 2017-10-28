using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Chuong_trinh_ban_ve
{
    public class Phim
    {
        ThoiGian ngaychieu;
        ThoiGian giochieu;
        private string tenphim;
        public string Tenphim
        {
            get { return tenphim; }
            set
            {
                tenphim = value.Substring(2, 30);
            }
        }
        public string Tenrap { get; set; }
        public string Diachirap { get; set; }
        public Phim(string tenrap,string diachirap,string tenphim,int ngay,int thang,int nam,int gio, int phut)
        {
            tenrap = Tenrap;
            diachirap = Diachirap;
            tenphim = Tenphim;
            ngaychieu = new ThoiGian(ngay,thang,nam);
            giochieu = new ThoiGian(gio,phut);
        }
        public virtual void LayDSVe()
        {
            List<Ve> ve = new List<Ve>();
                foreach (Ve v in ve)
                    Console.Write("{0}-{1}-{2}-[3}-{4}-{5}-{6}",v.Tenrap,v.Diachirap,v.Tenphim,v.ngaychieu,v.giochieu,v.Soluong,v.Giave);
        }
        public virtual string HienThi()
        {
            return Tenrap + "" + Diachirap + "" + Tenphim + "" + ngaychieu.ToString() + giochieu.ToString();
        } 
    }
}
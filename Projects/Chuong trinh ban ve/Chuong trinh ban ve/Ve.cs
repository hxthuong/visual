using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chuong_trinh_ban_ve
{
    public class Ve:Phim
    {
        VeThuong vt;
        VeVIP vv;
        private int soluong;
        private double giave;
        private double giathuong;
        private double giavip;
        public string Mave { get; set; }
        public int Soluong
        {
            get { return soluong; }
            set
            {
                if (value > 0)
                    soluong = value;
                else
                    soluong = 0;
            }
        }
        public double Giave
        {
            get { return giave; }
            set
            {
                if(value >= 45000)
                {
                    giave = value;
                    giavip = giave;
                }
                else if(value >=30000)
                {
                    giave = value;
                    giathuong = giave;
                }
            }
        }
       public Ve(string mave,string tenrap,string diachirap,string tenphim,int ngay,int thang,int nam,int gio,int phut,double giave)
                                                                                     :base(tenrap,diachirap,tenphim,ngay,thang,nam,gio,phut)
        {
            soluong = Soluong;
            giave = Giave;
            mave = Mave;
            vt = new VeThuong(mave, tenrap,diachirap,tenphim,ngay,thang,nam,gio,phut,giave);
            vv = new VeVIP(mave, tenrap, diachirap, tenphim,ngay,thang,nam,gio,phut,giave);
        }
        public void SLConLai()
        {
            vt.Ban();
            vv.Ban();
        }
        public double Tongtien()
        {
            return vt.Ban() * giathuong + vv.Ban() * giavip;
        }
        public override string HienThi()
        {
            return Mave + "" + base.HienThi()+""+Soluong+""+Giave;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CTbanve
{
    public class Phim
    {
        Ve ve;
        private string tenphim;
        private string tenrap;
        private string diachirap;
        private DateTime thoigianchieu;
        private int soluongve;
        public DateTime Thoigianchieu
        {
            get { return thoigianchieu; }
            set
            {
                if (value != DateTime.Now)
                    thoigianchieu = value;
                else
                    thoigianchieu = DateTime.Now;
            }
        }
        public Phim(string tenrap,string diachirap,string tenphim,DateTime thoigianchieu,string mave,double giave,
                       string loaive,string soghe,int soluongve)
        {
            ve = new Ve(mave, loaive,giave, soghe);
            this.tenphim = tenphim;
            this.tenrap = tenrap;
            this.diachirap = diachirap;
            this.thoigianchieu = thoigianchieu;
            this.soluongve = soluongve;
        }
        ~Phim()
        {
            ve = null;
        }
        public virtual string HienThi()
        {
            return tenrap +" "+ diachirap +" " + ve.HienThi() + thoigianchieu+ " " + soluongve;
        }
        public void DanhsachSapchieu()
        {

            Phim[] Sapchieu = new Phim[15];
            foreach (Phim sapchieu in Sapchieu)
                sapchieu.HienThi();
        }
        public void DanhsachDangchieu()
        {

            Phim[] Dangchieu = new Phim[15];
            foreach (Phim dangchieu in Dangchieu)
                dangchieu.HienThi();
        }
    }
}
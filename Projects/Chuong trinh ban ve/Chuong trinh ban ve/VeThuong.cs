using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chuong_trinh_ban_ve
{
    public class VeThuong:Ve
    {
        bool daban = false;
        int sldb = 0;
        private int SoluongVT = 1000;
        private int soluongmua;
        public int SLmua
        {
            get { return soluongmua; }
            set
            {
                if (value > 0)
                {
                    soluongmua = value;
                    daban = true;
                }
                else
                {
                    soluongmua = 0;
                    daban = false;
                }
            }
        }
        public VeThuong(string mave, string tenrap, string diachirap, string tenphim,int ngay,int thang, int nam,int gio, int phut, double giave) 
                                                                    :base(mave, tenrap, diachirap, tenphim, ngay, thang, nam, gio, phut, giave)
        {
           
        }
        public int Ban()
        {
            if (daban == true)
                sldb += soluongmua;
            return SoluongVT -= sldb;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong_trinh_ban_ve
{
    class VeVIP:Ve
    {
        bool daban = false;
        int sldb = 0;
        private int SoluongVV = 1000;
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
        public VeVIP(string mave, string tenrap, string diachirap, string tenphim, int ngay, int thang, int nam, int gio, int phut, double giave) 
                                                                    :base(mave, tenrap, diachirap, tenphim, ngay, thang, nam, gio, phut, giave)
        {

        }
        public int Ban()
        {
            if (daban == true)
                sldb += soluongmua;
            return SoluongVV -= sldb;

        }
    }
}

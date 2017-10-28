using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CTbanve
{
    public class Ve
    {
        public string mave;
        public double giave;
        public string soghe;
        public string loaive;
        public Ve(string mave, string loaive, double giave, string soghe)
        {
            this.mave = mave;
            this.giave = giave;
            this.soghe = soghe;
            this.loaive = loaive;

        }
        public void Banve(string tenrap, string tenphim,DateTime thoigianchieu,string loai,int sove,double tong)
        {
            loai = loaive;
            sove = int.Parse(Console.ReadLine());
            double tien = double.Parse(Console.ReadLine());
            tong = sove * giave;
            double tienthua = tien - tong;
            Console.Write("{0}-{1}-{2}-{3}-{4}-[5}-{6}",tenrap,tenphim,thoigianchieu,loaive,sove,tong,tienthua);
        }
        public string HienThi()
        {
            bool isVIP = false;
            if(loaive == "ve VIP")
                isVIP = true;
            return string.Format("{0}-{1}-{2}-{3}",mave,isVIP?"ve thuong":"ve VIP",giave,soghe);
        }
    }
}
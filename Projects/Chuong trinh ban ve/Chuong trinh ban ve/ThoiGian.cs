using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chuong_trinh_ban_ve
{
    public class ThoiGian
    {
        private int gio = (int)DateTime.Now.Hour;
        private int phut = (int)DateTime.Now.Minute;
        private int ngay = (int)DateTime.Now.Day;
        private int thang = (int)DateTime.Now.Month;
        private int nam = (int)DateTime.Now.Year;
        public int Gio
        {
            get { return gio; }

            set
            {
                if (value > gio)
                    gio = value;
                else
                    gio = (int)DateTime.Now.Hour;
            }
        }

        public int Phut
        {
            get { return phut; }

            set
            {
                if (value > phut)
                    phut = value;
                else
                    phut = (int)DateTime.Now.Minute;
            }
        }
        public int Ngay
        {
            get { return ngay; }

            set
            {
                if (value > ngay)
                    ngay = value;
                else
                    ngay = (int)DateTime.Now.Day;
            }
        }
        public int Thang
        {
            get { return thang; }

            set
            {
                if (value > thang)
                    thang = value;
                else
                    thang = (int)DateTime.Now.Month;
            }
        }
        public int Nam
        {
            get { return nam; }

            set
            {
                if (value > nam)
                    nam = value;
                else
                    nam = (int)DateTime.Now.Year;
            }
        }
        public ThoiGian(int ngay, int thang, int nam)
        {
            ngay = Ngay;
            thang = Thang;
            nam = Nam;
            Console.Write("{0}/{1}/{2}",ngay,thang,nam);
        }
        public ThoiGian(int gio, int phut)
        {
            gio = Gio;
            phut = Phut;
            Console.Write("{3}:{4}",gio,phut);
        }
    }
}
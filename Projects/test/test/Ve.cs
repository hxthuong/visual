using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Ve
    {
        public string Sohieu { get; set; }
        public string sanden;
        public string sandi;
        public double gia;
        Ve loaiHK;
        HanhKhach hk;
        public HanhKhach HK
        {
            get { return hk; }
            set { hk = value; }
        }
        public string Sandi
        {
            get { return sanden; }
            set { sanden = value; }
        }
        public string Sanden
        {
            get { return sandi; }
            set { sandi = value; }
        }
        public double Gia
        {
            get { return gia; }
            set { gia = value;}
        }
        public Ve(string sohieu,string sandi,string sanden,double gia,HanhKhach hk)
        {
            Sohieu = sohieu;
            Sandi = sandi;
            Sanden = sanden;
            Gia = gia;
            HK = hk;
        }
        public override string ToString()
        {
            return string.Format("\n Hanh khach: {0}  \n So hieu CB: {1} \n San bay di: {2}   \n San bay den: {3}  \n Gia: {4}",HK.ToString(),Sohieu,Sandi,Sanden,Gia);
        }
        public virtual double Giamgia()
        {
            if (HK.Tuoi < 5)
            {
                return Gia*0.25;
            }
            else if (HK.Tuoi >= 18 && HK.Tuoi <=22)
            {
                return Gia*0.1;
            }
            else if (HK.Tuoi >=65)
            {
                return Gia*0.1;
            }
            else return Gia*0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class KhachHang
    {
        private string hoten;
        private string sdt;
        public string Hoten
        {
            get { return hoten; }
            set { hoten = value; }
        }
        public string SDT
        {
            get { return sdt; }
            set { sdt = value; }
        }
        public KhachHang(string hoten,string sdt)
        {
            Hoten = hoten;
            SDT = sdt;
        }
        public override string ToString()
        {
            return string.Format("\n Ho ten: {0}  SDT: {1}", Hoten, SDT);
        }
    }
}

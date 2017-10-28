using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class HanhKhach:KhachHang
    {
        private int tuoi;
        public int Tuoi
        {
            get { return tuoi; }
            set { tuoi = value; }
        }
        public HanhKhach(string hoten,string sdt,int tuoi):base(hoten,sdt)
        {
            Tuoi = tuoi;
        }
        public override string ToString()
        {
            return base.ToString() + "  "+ string.Format("Tuoi: {0}", Tuoi);
        }
    }
}

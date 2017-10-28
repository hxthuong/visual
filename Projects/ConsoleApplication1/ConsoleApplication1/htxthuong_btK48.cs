using System;
using System.Collections.Generic;
using System.IO;

namespace QLCTDT
{
    #region Vung khai bao kieu du lieu
    // cau truc luu tru mon hoc
    struct MonHoc
    {
        public string MaMH;
        public string TenMH;
        public int SoTC;
        public int HK;
        public LoaiMonHoc LoaiMH;
        public List<string> MHTQ;
    }
    enum LoaiMonHoc { TuChon,BatBuoc};
    // Kieu cu phap the hien cu phap dong lenh khi goi chuong trinh
    // Dang 1 : QLCTDT.exe
    // Dang 2 : QLCTDT.exe -h
    // Dang 3 : QLCTDT.exe <num>
    // Dang 4 : QLCTDT.exe <path>
    enum KieuCuPhap { Dang1, Dang2, Dang3, Dang4 };
    #endregion

    class Program
    {
        #region Khai bao bien
        // bien listMonHoc de luu tru danh sach cac mon hoc
        static List<MonHoc> listMonHoc;
        // bien kieuCP de nhan dang cu phap dong lenh
        static KieuCuPhap kieuCP;
        #endregion
        #region Main
        static void Main(string[] args)
        {
            // khoi tao listMonHoc;
            listMonHoc = new List<MonHoc>();
            // Kiem tra doi so dong lenh
            // de xac dinh dang cu phap dong lenh
            if (args.Length == 0)
                kieuCP = KieuCuPhap.Dang1; // khi khong co doi so nao thi thuc hien theo dang 1
            else if (args.Length == 1)
            { // khi co 1 doi so, co the thuoc vao dang 2, 3, 4
                int num;
                if (int.TryParse(args[0], out num)) // neu doi so do kieu int
                    kieuCP = KieuCuPhap.Dang3; // thi thuoc dang 3
                else if (args[0] == "-h") // neu la chuoi "-h"
                    kieuCP = KieuCuPhap.Dang2; // thuoc dang 2
                else // nguoc lai, thuoc dang 4
                    kieuCP = KieuCuPhap.Dang4;
            }
            else
            {
                // In thong bao loi va hien thi huong dan su dung
                Console.WriteLine("Lenh goi chuong trinh cua ban bi sai");
                kieuCP = KieuCuPhap.Dang2;
            }
            // xu ly theo dang cu phap dong lenh
            switch (kieuCP)
            {
                case KieuCuPhap.Dang1:
                    // Hien thi Menu
                    XuLyMenu();
                    break;
                case KieuCuPhap.Dang2:
                    InHuongDanSuDung(); // In ra huong dan su dung
                    Console.ReadKey(); // Cho nguoi sd doc huong dan va bam enter
                    Environment.Exit(0); // roi thoat khoi chuong trinh
                    break;
                case KieuCuPhap.Dang3:
                    // Goi ham nhap du lieu voi so luong phan tu da biet
                    //ThemMHMoi(int.Parse(args[0]));
                    // Hien thi Menu
                    XuLyMenu();
                    break;
                case KieuCuPhap.Dang4:
                    // Doc du lieu tu file
                    //DocFile(args[0]);
                    // Hien thi Menu
                    XuLyMenu();
                    break;
            }
        }
        // Ham thuc hien in ra huong dan su dung cho chuong trinh
        static void InHuongDanSuDung()
        {
            Console.WriteLine();
            Console.WriteLine("CHUONG TRINH QUAN LY CHUONG TRINH DAO TAO");
            Console.WriteLine("Cu phap cau lenh theo 1 trong 4 dang sau :");
            Console.WriteLine("QLCTDT.exe"); // Dang 1
            Console.WriteLine("QLCTDT.exe -h"); // Dang 2
            Console.WriteLine("QLCTDT.exe <num>"); // Dang 3
            Console.WriteLine("QLCTDT.exe <path>"); // Dang 4
            Console.WriteLine();
        }
        #endregion
        #region Xu ly menu
        // In menu cua chuong trinh
        static void InMenu()
        {
            Console.WriteLine();
            Console.Write("CHUONG TRINH QUAN LY CHUONG TRINH DAO TAO");
            Console.WriteLine();
            Console.WriteLine("1 - Them mon hoc moi");
            Console.WriteLine("2 - Sua mon hoc");
            Console.WriteLine("3 - Xoa mon hoc");
            Console.WriteLine("4 - Tim kiem mon hoc theo ma hoc phan");
            Console.WriteLine("5 - Tim kiem mon hoc theo ten");
            Console.WriteLine("6 - Xem thong tin mon hoc");
            Console.WriteLine("7 - Xem mon hoc co the dang ky trong hoc ky");
            Console.WriteLine("8 - Xem thong tin chuong trinh dao tao");
            Console.WriteLine("9 - Doc du lieu tu file");
            Console.WriteLine("10 - Ghi du lieu ra file");
            Console.WriteLine("11 - Thoat");
            Console.WriteLine("Hay chon so tu 1 den 11 phu hop voi chuc nang tuong ung.");
            Console.Write("Ban chon so : ");
        }
        // ham xu ly menu
        static void XuLyMenu()
        {
            int menu;
            while (true)
            {
                InMenu(); // in menu ra man hinh
                menu = XulyChonMenu(1, 11); // cho nguoi su dung chon menu

                switch (menu)
                {
                    case 1: // Them mon hoc moi
                        ThemMHMoi();
                        break;
                    case 2: // Sua mon hoc
                        SuaMH();
                        break;
                    case 3: // Xoa mon hoc
                        XoaMH();
                        break;
                    case 4: // in danh sach mon hoc theo ma mon hoc
                        InTheoMaMH();
                        break;
                    case 5: // in danh sach mon hoc theo ten mon hoc
                        InTheoTenMH();
                        break;
                    case 6: // In thong tin mon hoc
                        InThongTinMH();
                        break;
                    case 7: // in danh sach mon hoc co the dang ky trong hoc ky
                        InMHtrongHK();
                        break;
                    case 8: // In thong tin chuong trinh dao tao
                        ThongTinCTDT();
                        break;
                    case 9: // doc file
                        DocFile();
                        break;
                    case 10: // luu file
                        GhiFile();
                        break;
                    case 11: // thoat khoi chuong trinh
                        if (XuLyCauHoiYesNo("Ban co chac muon thoat chuong trinh ? (Y/N): "))
                        {
                            Console.WriteLine("\nCam on ban da su dung chuong trinh !");
                            Console.ReadKey();
                            Environment.Exit(0);
                        }
                        break;
                }
            }
        }
        // ham nay tra ra mot so tu 1 den 11
        // tuong ung voi cac so tren menu ma nguoi su dung nhap
        // hai tham so soduoi va sotren giup cho ham nay co the xu ly cho bat ky menu nao
        static int XulyChonMenu(int soduoi, int sotren)
        {
            int menu;
            // ham TryParse thuc hien chuyen doi tu chuoi sang so
            // neu co the chuyen duoc thi ham nay tra ra gia tri true
            // va ket qua o tham chieu menu
            while (!int.TryParse(Console.ReadLine(), out menu)
                   && ((menu < soduoi) || (menu > sotren)))
            {
                Console.WriteLine("Ban chon so nam ngoai pham vi cac so tren menu.");
                Console.WriteLine("Hay chon so tu {0} den {1} phu hop voi chuc nang tuong ung.", soduoi, sotren);
                Console.Write("Moi ban chon lai : ");
            }
            return menu;
        }
        // Ham in menu cac kieu tai khoan, loai giao dich
        // chuoiLoai : la chuoi ky tu ten cac kieu tai khoan hoac loai giao dich
        static void InMenuCacLoai(string tieude, string chuoiLoai)
        {
            Console.Write("{0} sau : ", tieude);
            Console.WriteLine(chuoiLoai);
            Console.Write("Moi ban nhap : ");
        }
        #endregion
        // XU LY THEM MON HOC MOI
        #region Them mon hoc moi
        // Ham cho phep nhap them mon hoc moi
        static void ThemMHMoi()
        {
            Console.WriteLine("\nTHEM MON HOC MOI");

            do
            {
                MonHoc monhoc = ThemMotMHMoi(); // nhap thong tin cho mot mon hoc
                // kiem tra xem ma mon hoc co bang -1 khong ?
                // neu khong thi chen vao vi tri thich hop de tao ra danh sach tang dan
                // theo hoc ky du kien
                listMonHoc.Add(monhoc);
                // hoi nguoi su dung co muon tiep tuc khong
            } while (XuLyCauHoiYesNo("\nBan co muon nhap them mon hoc khac khong ? (Y/N) : "));
        }
        // Ham xu ly nhap thong tin cho tung mon hoc
        // Ham tra ra gia tri don voi ma -1 khi du lieu nhap vao bi trung
        static MonHoc ThemMotMHMoi()
        {
            MonHoc monhoc = new MonHoc(); // khoi tao
            Console.WriteLine("\nMoi ban nhap thong tin mon hoc :");
            monhoc.ma = XuLyNhapMaMH();
            Console.Write("Ten mon hoc: ");
            monhoc.tenMH = Console.ReadLine();
            Console.Write("So tin chi: ");
            monhoc.tinchi = XuLyNhapSoTC();
            Console.Write("Loai mon hoc (TuChon hay BatBuoc): ");
            monhoc.loaiMH = XuLyNhapLoaiMH();
            Console.Write("Hoc ky du kien: ");
            monhoc.hocky = LayHKMHMoi();
            Console.Write("Nhap mon hoc tien quyet: ");
            monhoc.monhocTQ = XuLyNhapMonTQ();
            return monhoc;
        }
        // Ham lay hoc ky du kien
        static int LayHKMHMoi()
        {
            int hocky;
            while (!int.TryParse(Console.ReadLine(), out hocky)
                || hocky < 1 || hocky > 8)
            {
                Console.Write("Ban nhap sai. Moi nhap lai so:");
            }
            return hocky;
        }
        #endregion
        // Cac ham trong region Them mon hoc moi, Sua mon hoc va In an
        // su dung cac ham trong region nay
        #region Xu Ly Nhap Du Lieu
        // Ham xu ly viec nhap ma mon hoc
        static string XuLyNhapMaMH()
        {
            Console.Write("Ma mon hoc: ");
            string ma = Console.ReadLine();

            // kiem tra trung
            while (LaTrungMaMH(ma))
            {   // hoi co muon sua lai khong ?
                Console.WriteLine("Ma mon hoc ban nhap da co roi!");
                Console.WriteLine("Moi ban nhap lai: ");
                ma = Console.ReadLine();
            }

            return ma;
        }
        //Ham xu ly nhap so tin chi
        static int XuLyNhapSoTC()
        {
            int sotc;
            // So tin chi nhap vao phai nam trong doan tu 1-7 (1 mon hoc toi da co 7 tin chi)
            while (!int.TryParse(Console.ReadLine(), out sotc)
                   || sotc < 1 || sotc > 7)
            { // khong phai thi nhap lai
                Console.WriteLine("So tin chi phai tu 1-7.");
                Console.Write("Moi ban nhap lai: ");
            }
            return sotc;
        }
        //Ham xu ly nhap loai mon hoc
        static LoaiMonHoc XuLyNhapLoaiMH()
        {
            LoaiMonHoc loaiMH = LoaiMonHoc.BatBuoc;
            while (!Enum.TryParse<LoaiMonHoc>(Console.ReadLine(), out loaiMH))
            {
                Console.WriteLine("Loai mon hoc ban nhap vao sai!");
                Console.WriteLine("Moi ban nhap lai: ");
            }
            return loaiMH;
        }
        static List<string> XuLyNhapMonTQ()
        {
            List<string> listTQ = new List<string>();
            string st;
            while (true)
            {
                st = Console.ReadLine(); // ma1,ma2,ma3
                char[] delims = { ',' };
                string[] list = st.Split(delims, StringSplitOptions.RemoveEmptyEntries);
                if (list.Length == 0) break;
                bool kt = true;
                foreach (string s in list)
                    if (!LaTrungMaMH(s))
                    {
                        Console.WriteLine("Mon tien quyet khong ton tai.");
                        Console.Write("Moi ban nhap lai: ");
                        kt = false;
                        break;
                    }
                    else
                        listTQ.Add(s);
                if (kt) break;
            }
            return listTQ;
        }
        #endregion
        #region Sua Mon Hoc
        // Ham xu ly sua thong tin cac mon hoc
        static void SuaMH()
        {
            // neu danh sach rong thi bo qua
            if (LaRong("de sua thong tin"))
                return;

            int index;
            string ma;
            Console.WriteLine("\nMoi ban nhap ma cua mon hoc can sua:");
            ma = Console.ReadLine();
            do
            {

                if ((index = LayIndexTheoMa(ma)) == -1) // neu khong co
                    Console.WriteLine("Ma mon hoc ban nhap khong co trong du lieu.");
                else // nguoc lai
                {
                    Console.WriteLine("Mon hoc voi ma {0} co thong tin nhu sau :", listMonHoc[index].ma);
                    InThongTinMotMH(listMonHoc[index]); // in lai thong tin hien tai cua mon hoc muon sua
                    Console.WriteLine("\nMoi ban nhap thong tin moi cho mon hoc tren.");
                    SuaMotMH(index); // thuc hien nhap thong tin moi cho mon hoc
                }
            } while (XuLyCauHoiYesNo("\nBan co tiep tuc sua thong tin cho mon hoc khac? (Y/N):"));
        }
        // Ham cho nhap thong tin moi vao cho ma mon hoc muon sua thong tin
        static void SuaMotMH(int vitri)
        {
            MonHoc MHCu = listMonHoc[vitri]; // sao chep mon hoc muon sua ra
            listMonHoc.RemoveAt(vitri); // xoa mon hoc cu
            // nhap thong tin moi vao bien MHMoi
            // MHCu de do du phong truong hop nhap thong tin moi bi sai, khong muon nhap tiep
            // thi khoi phuc lai thong tin cu tai vi tri cu (vitri)
            MonHoc MHMoi = MHCu;
            listMonHoc.Insert(vitri, MHCu);
        }
        #endregion
        #region Xoa Mon Hoc
        // Ham xu ly xoa mon hoc
        static void XoaMH()
        {
            Console.WriteLine("\nXOA MON HOC");
            // neu la rong thi bo qua
            if (LaRong("de xoa")) return;

            int index;
            string ma;
            Console.WriteLine("\nMoi ban nhap ma cua mon hoc muon xoa: ");
            ma = Console.ReadLine();
            do
            {

                if ((index = LayIndexTheoMa(ma)) == -1) // neu ma mon hoc khong ton tai trong danh sach
                    Console.WriteLine("Ma mon hoc ban nhap khong co trong co so du lieu.");
                else // nguoc lai
                {
                    Console.WriteLine("Mon hoc voi ma {0} co thong tin nhu sau :", listMonHoc[index].ma);
                    // in thong tin hien co cua mon hoc muon xoa
                    InThongTinMotMH(listMonHoc[index]);
                    //xac dinh lai y muon xoa mon hoc cua nguoi dung
                    if (XuLyCauHoiYesNo("\nBan co that su muon xoa mon hoc nay ? (Y/N):"))
                    {
                        listMonHoc.RemoveAt(index); // xoa mon hoc khoi danh sach
                        Console.WriteLine("Mon hoc voi {0} da duoc xoa.", ma);
                        Console.ReadKey();
                    }
                }
            } while (XuLyCauHoiYesNo("\nBan co tiep tuc xoa nhung mon hoc khac? (Y/N):"));
        }
        #endregion
        #region In an
        static void InThongTinMh()
        {
            Console.WriteLine("\nIN THONG TIN MON HOC");

            do
            {
                Console.Write("Nhap ma mon hoc muon in: ");
                string ma = Console.ReadLine();
                int index = LayIndexTheoMa(ma);
                if (index != -1)
                    InThongTinMotMH(listMonHoc[index]);
                else
                    Console.Write("Khong co mon hoc voi ma nay");
            } while (XuLyCauHoiYesNo("\nBan co muon nhap them mon hoc khac khong ? (Y/N) : "));
        }

        static void InThongTinMotMH(MonHoc monhoc)
        {
            Console.WriteLine("Ma mon hoc: {0}", monhoc.ma);
            Console.WriteLine("Ten mon hoc: {0}", monhoc.tenMH);
            Console.WriteLine("So tin chi: ", monhoc.tinchi);
            Console.WriteLine("Loai mon hoc (TuChon hay BatBuoc): ", monhoc.loaiMH);
            Console.WriteLine("Nhap mon hoc tien quyet: ", monhoc.monhocTQ);
            Console.WriteLine("Nhap hoc ky: ", monhoc.hocky);


        }

        // Ham xu ly in thong tin cua tat ca cac mon hoc theo ten mon hoc
        static void InTheoTenMH()
        {
            // neu danh sach rong thi bo qua
            if (LaRong("de sua thong tin"))
                return;

            int index;
            string ten;
            Console.WriteLine("\nMoi ban nhap ten mon hoc:");
            ten = Console.ReadLine();
            do
            {
                Console.WriteLine("Mon hoc voi ten {0} co thong tin nhu sau :", listMonHoc[index].tenMH);
                InThongTinMotMH(listMonHoc[index]); // in lai thong tin hien tai cua mon hoc
            } while (XuLyCauHoiYesNo("\nBan co tiep tuc xem thong tin mon hoc khac? (Y/N):"));
            return ten;
        }
        //Ham in danh sach mon hoc co the dang ky trong hoc ky
        static int InMHtrongHK()
        {
            // neu danh sach rong thi bo qua
            if (LaRong("de sua thong tin"))
                return;

            int index;
            int hk;
            Console.WriteLine("\nMoi ban nhap hoc ky du kien:");
            hk = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("Mon hoc voi hoc ky {0} co thong tin nhu sau :", listMonHoc[index].hocky);
                InThongTinMotMH(listMonHoc[index]); // in lai thong tin hien tai cua mon hoc
            } while (XuLyCauHoiYesNo("\nBan co tiep tuc xem thong tin mon hoc khac? (Y/N):"));
            return hk;
        }
        //Ham xem thong tin chuong trinh dao tao
        static void ThongTinCTDT()
        {
            int mhtc = 0;
            int tstctc = 0;
            int mhbb = 0;
            int tstcbb = 0;
            string loai = Console.ReadLine();
            Console.Write("");
            for (int i = 0; i < listMonHoc.Count; i++)
                if (loai == "BatBuoc")
                {
                    mhbb++;
                    tstcbb = tstcbb + listMonHoc[i].tinchi;
                }
                else
                {
                    mhtc++;
                    tstctc = tstctc + listMonHoc[i].tinchi;
                }
        }
        #endregion
        #region Xu ly file
        // Ham xu ly doc file
        static void DocFile(string filename = null)
        {
            Console.WriteLine("\nDOC DU LIEU TU FILE");

            int soluongcu = listMonHoc.Count;
            if (listMonHoc.Count != 0)
            {
                Console.Write("\nChuc nang nay se chen them du lieu tu file vao CSDL.");
                if (!XuLyCauHoiYesNo("Ban co chac chan muon doc du lieu tu file ? (Y/N) : "))
                    return;
            }

            while (filename == null) // neu khong co ten file thi yeu cau nhap lai
            {
                Console.Write("\nNhap duong dan den tap tin chua du lieu : ");
                filename = Console.ReadLine();
            }
            // mo file ra de doc
            StreamReader reader = new StreamReader(filename);
            if (reader == null) // neu mo bi loi
            {
                ThongBaoLoiFile("File ban nhap khong ton tai hoac duong dan sai.");
                return; // thi thoat khoi ham
            }

            string dong = null;
            // doc mot dong trong file
            while ((dong = reader.ReadLine()) != null) // neu het file thi khong doc nua
            {
                MonHoc monhoc;
                // tach cac thanh phan trong dong doc duoc
                // va gan gia tri vao bien cau truc monhoc
                if (!TachGiaTri(dong, out monhoc))
                { // neu qua trinh tach bi loi thi bao loi
                    Console.WriteLine("File bi loi!", reader);
                    return; // thoat khoi ham Doc file
                }
            }
            Console.WriteLine("Da them duoc {0} mon hoc vao CSDL", listMonHoc.Count - soluongcu);

            // Dong tap tin
            reader.Close();
        }
        // Ham co nhiem vu tach chuoi doc duoc tu file
        // gan gia tri vao bien monhoc
        static bool TachGiaTri(string input, out MonHoc monhoc)
        {
            monhoc = new MonHoc();
            string[] items = input.Split(',');
            // phai chua 5 thanh phan
            if (items.Length != 6) return false;
            return true;
        }
        // Xu ly luu danh sach xuong file
        static void GhiFile(string filename = null)
        {
            Console.WriteLine("\nGHI DU LIEU RA FILE");

            while (filename == null) // neu khong co duong dan
            {
                Console.Write("\nNhap duong dan den luu file du lieu : ");
                filename = Console.ReadLine(); // yeu cau nhap lai
            }

            Console.Write("\nDang ghi du lieu ra file.");

            // mo file ra de ghi
            StreamWriter writer = new StreamWriter(filename);
            if (writer == null) // mo khong duoc
            {
                Console.WriteLine("\nDuong dan sai.");
                return; // error
            }
            Console.Write(".");

            //Ghi dữ liệu vào tập tin
            foreach (MonHoc monhoc in listMonHoc)
            {
                writer.WriteLine("{0}-{1}-{2}-{3}-{4}-{5}",
                                 monhoc.ma,
                                 monhoc.tenMH,
                                 monhoc.tinchi,
                                 monhoc.loaiMH,
                                 monhoc.hocky,
                                 monhoc.monhocTQ);
                Console.Write(".");
            }

            Console.WriteLine("Xong");
            writer.Close();
        }
        // Ham xu ly in thong bao cac loai file
        static void ThongBaoLoiFile(string st, StreamReader reader = null)
        {
            Console.Write(st);
            Console.ReadKey();
            if (reader != null)
                reader.Close();
        }
        #endregion

        #region CHUNG
        // Ham xu ly in cau hoi yes no
        static bool XuLyCauHoiYesNo(string cauhoi)
        {
            Console.Write(cauhoi); // in cau hoi
            ConsoleKeyInfo c = Console.ReadKey(); // nguoi su dung nhap vao lua chon
            Console.WriteLine();

            if (c.KeyChar == 'Y' || c.KeyChar == 'y')
                return true;
            return false;
        }

        // Ham kiem tra xem ma mon hoc co bi trung voi cac mon da co hay khong
        // Bi trung khi 
        static bool LaTrungMaMH(string ma)
        {
            foreach (MonHoc monhoc in listMonHoc)
                if (monhoc.ma == ma)
                    return true;
            return false;
        }

        // Ham kiem tra danh sach rong
        static bool LaRong(string mucdich)
        {
            if (listMonHoc.Count == 0)
            {
                Console.WriteLine("\nCo so du lieu khong co mon hoc nao {0}.", mucdich);
                Console.ReadKey();
                return true;
            }
            return false;
        }
        // Ham tra ra vi tri cua mot mon hoc theo ma 
        static int LayIndexTheoMa(string ma)
        {
            for (int i = 0; i < listMonHoc.Count; i++)
                if (ma == listMonHoc[i].ma)
                    return i;
            return -1;
        }
        #endregion
    }

}
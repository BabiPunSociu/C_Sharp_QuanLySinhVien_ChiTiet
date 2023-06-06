using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap7
{
    internal class SinhVien
    {
        public int maSV { get; set; }
        public string hoTen { get; set; }
        public int namSinh { get; set; }
        public string queQuan { get; set; }
        public float diemLapTrinh { get; set; }
        public float diemCSDL { get; set; }
        public float TrungBinh
        {
            get
            {
                return (diemLapTrinh + diemCSDL) / 2;
            }
            set
            {
                value = (diemLapTrinh + diemCSDL) / 2;
            }
                
        }

        public SinhVien() {}

        public SinhVien(string hoTen, int namSinh, string queQuan, float diemLapTrinh, float diemCSDL)
        {
            this.hoTen = hoTen;
            this.namSinh = namSinh;
            this.queQuan = queQuan;
            this.diemLapTrinh = diemLapTrinh;
            this.diemCSDL = diemCSDL;
//            this.TrungBinh = (diemLapTrinh + diemCSDL) / 2;
        }

        public void nhap()
        {
            try
            {   // Nhập mã sinh viên
                do
                {
                    Console.Write("\nNhập mã sinh viên: ");
                    maSV = int.Parse(Console.ReadLine());
                }while(maSV < 0);

                // Nhập họ tên
                Console.Write("Nhập họ tên: ");
                hoTen = Console.ReadLine();

                // Nhập năm sinh
                DateTime dateTime = DateTime.Now;
                do
                {
                    Console.Write("Nhập năm sinh: ");
                    namSinh = int.Parse(Console.ReadLine());
                }while (namSinh <= 0 || dateTime.Year - namSinh < 18);  // tuổi < 18

                // Nhập quê quán
                Console.Write("Nhập quê quán: ");
                queQuan = Console.ReadLine();

                // Nhập điểm lập trình
                do
                {
                    Console.Write("Nhập điểm lập trình: ");
                    diemLapTrinh = float.Parse(Console.ReadLine());
                } while (diemLapTrinh < 0 || diemLapTrinh > 10);

                // Nhập điểm CSDL
                do
                {
                    Console.Write("Nhập điểm CSDL: ");
                    diemCSDL = float.Parse(Console.ReadLine());
                } while (diemCSDL < 0 || diemCSDL > 10);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void xuat()
        {
            /*
            Console.Write("\n{0,12}" + "|" + "{1,20}" + "|" + "{2,8}" + "|" + "{3,8}" + "|" + "{4,9}" + "|" + "{5,9}" + "|" + "{6,9}",
                    "Mã sinh viên", "Họ tên", "Năm sinh", "Quê quán", "Lập trình", "CSDL", "Điểm TB");
            */
            Console.Write("\n{0,12}" + "|" + "{1,20}" + "|" + "{2,8}" + "|" + "{3,8}" + "|" + "{4,9}" + "|" + "{5,9}" + "|" + "{6,9}",
                maSV,hoTen,namSinh,queQuan,diemLapTrinh,diemCSDL,TrungBinh);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            DanhSach danhSach = new DanhSach();
            danhSach.nhap();
            danhSach.xuat();
            
            Console.WriteLine("\nNhững sinh viên có điểm TB>8.0");
            danhSach.xuatSVGioi();

            Console.WriteLine("\nDanh sách đã sắp xếp theo mã sinh viên:");
            danhSach.sapXep();
            danhSach.xuat();
        }
    }
}
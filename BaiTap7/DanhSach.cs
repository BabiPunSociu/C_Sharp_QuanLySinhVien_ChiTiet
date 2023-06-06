using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap7
{
    internal class DanhSach
    {
        int n = 0;  // số lượng sinh viên
        private SinhVien[] DS;

        public DanhSach() {}

        public void nhap()
        {
            try
            {
                do
                {
                    Console.Write("\nNhập số lượng sinh viên (n>0): n = ");
                    n = int.Parse(Console.ReadLine());
                } while (n <= 0);

                DS = new SinhVien[n];

                for(int i = 0; i < n; i++)
                {
                    DS[i] = new SinhVien();
                    Console.Write("\nNhập sinh viên thứ "+(i+1));
                    DS[i].nhap();
                }    
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void xuat()
        {
            Console.Write("\n{0,12}" + "|" + "{1,20}" + "|" + "{2,8}" + "|" + "{3,8}" + "|" + "{4,9}" + "|" + "{5,9}" + "|" + "{6,9}",
                    "Mã sinh viên", "Họ tên", "Năm sinh", "Quê quán", "Lập trình", "CSDL", "Điểm TB");

            foreach (SinhVien sv in DS)
            {
                sv.xuat();
            }    
        }

        public void xuatSVGioi()
        {
            Console.Write("\n{0,12}" + "|" + "{1,20}" + "|" + "{2,8}" + "|" + "{3,8}" + "|" + "{4,9}" + "|" + "{5,9}" + "|" + "{6,9}",
                    "Mã sinh viên", "Họ tên", "Năm sinh", "Quê quán", "Lập trình", "CSDL", "Điểm TB");

            foreach (SinhVien sv in DS)
            {
                if (sv.TrungBinh > 8) sv.xuat();
            }
        }

        public void sapXep()    // sắp xếp danh sách theo mã sinh viên
        {
            Quick_Sort.quickSort(DS, 0, n - 1);
        }
    }
}

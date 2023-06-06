using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap7
{
    internal class Quick_Sort
    {
        /* Hàm swap */
        public static void swapSV(ref SinhVien A, ref SinhVien B)
        {
            SinhVien C = new SinhVien();

            // C = A
            C.maSV = A.maSV;
            C.hoTen = A.hoTen;
            C.namSinh = A.namSinh;
            C.queQuan = A.queQuan;
            C.diemLapTrinh = A.diemLapTrinh;
            C.diemCSDL = A.diemCSDL;
            C.TrungBinh = A.TrungBinh;

            // A = B
            A.maSV = B.maSV;
            A.hoTen = B.hoTen;
            A.namSinh = B.namSinh;
            A.queQuan = B.queQuan;
            A.diemLapTrinh = B.diemLapTrinh;
            A.diemCSDL = B.diemCSDL;
            A.TrungBinh = B.TrungBinh;

            // B = C
            B.maSV = C.maSV;
            B.hoTen = C.hoTen;
            B.namSinh = C.namSinh;
            B.queQuan = C.queQuan;
            B.diemLapTrinh = C.diemLapTrinh;
            B.diemCSDL = C.diemCSDL;
            B.TrungBinh = C.TrungBinh;
        }




        public static int partition(SinhVien[] arr, int low, int high)
        {
            int pivot = arr[high].maSV;    // pivot
            int left = low;
            int right = high - 1;
            while (true)
            {
                while (left <= right && arr[left].maSV < pivot) left++;
                while (right >= left && arr[right].maSV > pivot) right--;
                if (left >= right) break;
                swapSV(ref arr[left],ref arr[right]);
                left++;
                right--;
            }
            swapSV(ref arr[left],ref arr[high]);
            return left;
        }

        /* Hàm thực hiện giải thuật quick sort */
        public static void quickSort(SinhVien[] arr, int low, int high)
        {
            if (low < high)
            {
                /* pi là chỉ số nơi phần tử này đã đứng đúng vị trí
                 và là phần tử chia mảng làm 2 mảng con trái & phải */
                int pi = partition(arr, low, high);

                // Gọi đệ quy sắp xếp 2 mảng con trái và phải
                quickSort(arr, low, pi - 1);
                quickSort(arr, pi + 1, high);
            }
        }
    }
}

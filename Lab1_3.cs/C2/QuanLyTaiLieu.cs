using System;
using System.Collections.Generic;
using System.Linq;

namespace QuanLyThuVien
{
    public class QuanLyTaiLieu
    {
        private List<TaiLieu> danhSach = new List<TaiLieu>();

        public void ThemTaiLieu()
        {
            Console.WriteLine("Chọn loại tài liệu:");
            Console.WriteLine("1. Sách");
            Console.WriteLine("2. Tạp chí");
            Console.WriteLine("3. Báo");
            Console.Write("Lựa chọn: ");
            int chon = int.Parse(Console.ReadLine());

            TaiLieu tl = null;

            switch (chon)
            {
                case 1: tl = new Sach(); break;
                case 2: tl = new TapChi(); break;
                case 3: tl = new Bao(); break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ.");
                    return;
            }

            Console.WriteLine("Nhập thông tin tài liệu:");
            tl.Nhap();
            danhSach.Add(tl);
        }

        public void HienThi()
        {
            Console.WriteLine("\nDanh sách tài liệu:");
            foreach (var tl in danhSach)
            {
                tl.Xuat();
                Console.WriteLine("-----");
            }
        }

        public void TimTheoLoai()
        {
            Console.WriteLine("Tìm theo loại:");
            Console.WriteLine("1. Sách");
            Console.WriteLine("2. Tạp chí");
            Console.WriteLine("3. Báo");
            Console.Write("Lựa chọn: ");
            int loai = int.Parse(Console.ReadLine());

            Console.WriteLine("\nKết quả tìm kiếm:");
            foreach (var tl in danhSach)
            {
                if ((loai == 1 && tl is Sach) ||
                    (loai == 2 && tl is TapChi) ||
                    (loai == 3 && tl is Bao))
                {
                    tl.Xuat();
                    Console.WriteLine("-----");
                }
            }
        }
    }
}

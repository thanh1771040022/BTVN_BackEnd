using System;
using System.Collections.Generic;

namespace QLCB
{
    public class QLCB
    {
        private List<CanBo> danhSach = new List<CanBo>();

        public void NhapCanBoMoi()
        {
            Console.WriteLine("Chọn loại cán bộ muốn thêm:");
            Console.WriteLine("1. Công nhân");
            Console.WriteLine("2. Kỹ sư");
            Console.WriteLine("3. Nhân viên");

            Console.Write("Nhập lựa chọn: ");
            int chon = int.Parse(Console.ReadLine());

            CanBo cb;

            switch (chon)
            {
                case 1:
                    cb = new CongNhan();
                    break;
                case 2:
                    cb = new KySu();
                    break;
                case 3:
                    cb = new NhanVien();
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ!");
                    return;
            }

            cb.Nhap();
            danhSach.Add(cb);
            Console.WriteLine(">> Đã thêm cán bộ thành công!\n");
        }

        public void TimKiemTheoTen()
        {
            Console.Write("Nhập tên cần tìm: ");
            string ten = Console.ReadLine();
            bool timThay = false;

            foreach (var cb in danhSach)
            {
                if (cb.HoTen.ToLower().Contains(ten.ToLower()))
                {
                    cb.HienThi();
                    Console.WriteLine("--------------------------");
                    timThay = true;
                }
            }

            if (!timThay)
                Console.WriteLine("Không tìm thấy cán bộ nào!");
        }

        public void HienThiTatCa()
        {
            Console.WriteLine("Danh sách cán bộ:");
            foreach (var cb in danhSach)
            {
                cb.HienThi();
                Console.WriteLine("--------------------------");
            }
        }
    }
}


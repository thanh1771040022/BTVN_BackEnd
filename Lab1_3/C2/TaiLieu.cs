using System;

namespace QuanLyThuVien
{
    public class TaiLieu
    {
        public string MaTaiLieu { get; set; }
        public string TenNXB { get; set; }
        public int SoBanPhatHanh { get; set; }

        public virtual void Nhap()
        {
            Console.Write("Mã tài liệu: ");
            MaTaiLieu = Console.ReadLine();
            Console.Write("Tên NXB: ");
            TenNXB = Console.ReadLine();
            Console.Write("Số bản phát hành: ");
            SoBanPhatHanh = int.Parse(Console.ReadLine());
        }

        public virtual void Xuat()
        {
            Console.WriteLine($"Mã TL: {MaTaiLieu}, NXB: {TenNXB}, Số bản: {SoBanPhatHanh}");
        }
    }

    public class Sach : TaiLieu
    {
        public string TacGia { get; set; }
        public int SoTrang { get; set; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Tên tác giả: ");
            TacGia = Console.ReadLine();
            Console.Write("Số trang: ");
            SoTrang = int.Parse(Console.ReadLine());
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Tác giả: {TacGia}, Số trang: {SoTrang}");
        }
    }

    public class TapChi : TaiLieu
    {
        public int SoPhatHanh { get; set; }
        public int ThangPhatHanh { get; set; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Số phát hành: ");
            SoPhatHanh = int.Parse(Console.ReadLine());
            Console.Write("Tháng phát hành: ");
            ThangPhatHanh = int.Parse(Console.ReadLine());
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Số PH: {SoPhatHanh}, Tháng PH: {ThangPhatHanh}");
        }
    }

    public class Bao : TaiLieu
    {
        public DateTime NgayPhatHanh { get; set; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Ngày phát hành (dd/MM/yyyy): ");
            NgayPhatHanh = DateTime.Parse(Console.ReadLine());
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Ngày phát hành: {NgayPhatHanh:dd/MM/yyyy}");
        }
    }
}

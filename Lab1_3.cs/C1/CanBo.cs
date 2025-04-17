using System;

namespace QLCB
{
    public class CanBo
    {
        public string HoTen { get; set; }
        public int NamSinh { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }

        public virtual void Nhap()
        {
            Console.Write("Họ tên: ");
            HoTen = Console.ReadLine();

            Console.Write("Năm sinh: ");
            NamSinh = int.Parse(Console.ReadLine());

            Console.Write("Giới tính: ");
            GioiTinh = Console.ReadLine();

            Console.Write("Địa chỉ: ");
            DiaChi = Console.ReadLine();
        }

        public virtual void HienThi()
        {
            Console.WriteLine($"Họ tên: {HoTen}, Năm sinh: {NamSinh}, Giới tính: {GioiTinh}, Địa chỉ: {DiaChi}");
        }
    }

    public class CongNhan : CanBo
    {
        public int Bac { get; set; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Bậc công nhân (VD: 3/7 → nhập 3): ");
            Bac = int.Parse(Console.ReadLine());
        }

        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine($"Bậc công nhân: {Bac}/7");
        }
    }

    public class KySu : CanBo
    {
        public string NganhDaoTao { get; set; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Ngành đào tạo: ");
            NganhDaoTao = Console.ReadLine();
        }

        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine($"Ngành đào tạo: {NganhDaoTao}");
        }
    }

    public class NhanVien : CanBo
    {
        public string CongViec { get; set; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Công việc: ");
            CongViec = Console.ReadLine();
        }

        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine($"Công việc: {CongViec}");
        }
    }
}

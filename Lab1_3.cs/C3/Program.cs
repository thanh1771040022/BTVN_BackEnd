/*Bài 3: Các thí sinh dự thi đại học bao gồm các thí sinh thi khối A, thí sinh thi khối B, thí sinh
thi khối C
+ Các thí sinh cần quản lý các thuộc tính: Số báo danh, họ tên, địa chỉ, ưu tiên.
+ Thí sinh thi khối A thi các môn: Toán, lý, hoá
+ Thí sinh thi khối B thi các môn: Toán, Hoá, Sinh
+ Thí sinh thi khối C thi các môn: Văn, Sử, Địa
1. Xây dựng các lớp để quản lý các thí sinh sao cho sử dụng lại được nhiều nhất.
2. Xây dựng lớp TuyenSinh cài đặt các phương thức thực hiện các nhiệm vụ sau:
- Nhập thông tin về các thí sinh dự thi
- Hiển thị thông tin về các thí sinh đã trúng tuyển (Giả sử điểm chuẩn cho khối A: 15,
điểm chuẩn khối B: 16, điểm chuẩn khối C: 13,5).
- Tìm kiếm các thí sinh theo số báo danh
- Kết thúc chương trình.*/
using System;
using System.Collections.Generic;

public abstract class ThiSinh
{
    public string SoBaoDanh { get; set; }
    public string HoTen { get; set; }
    public string DiaChi { get; set; }
    public string UuTien { get; set; }

    public ThiSinh(string soBaoDanh, string hoTen, string diaChi, string uuTien)
    {
        SoBaoDanh = soBaoDanh;
        HoTen = hoTen;
        DiaChi = diaChi;
        UuTien = uuTien;
    }

    public abstract double TinhDiem();
}

public class ThiSinhKhoiA : ThiSinh
{
    public double Toan { get; set; }
    public double Ly { get; set; }
    public double Hoa { get; set; }

    public ThiSinhKhoiA(string soBaoDanh, string hoTen, string diaChi, string uuTien, double toan, double ly, double hoa)
        : base(soBaoDanh, hoTen, diaChi, uuTien)
    {
        Toan = toan;
        Ly = ly;
        Hoa = hoa;
    }

    public override double TinhDiem()
    {
        return Toan + Ly + Hoa;
    }
}

public class ThiSinhKhoiB : ThiSinh
{
    public double Toan { get; set; }
    public double Hoa { get; set; }
    public double Sinh { get; set; }

    public ThiSinhKhoiB(string soBaoDanh, string hoTen, string diaChi, string uuTien, double toan, double hoa, double sinh)
        : base(soBaoDanh, hoTen, diaChi, uuTien)
    {
        Toan = toan;
        Hoa = hoa;
        Sinh = sinh;
    }

    public override double TinhDiem()
    {
        return Toan + Hoa + Sinh;
    }
}

public class ThiSinhKhoiC : ThiSinh
{
    public double Van { get; set; }
    public double Su { get; set; }
    public double Dia { get; set; }

    public ThiSinhKhoiC(string soBaoDanh, string hoTen, string diaChi, string uuTien, double van, double su, double dia)
        : base(soBaoDanh, hoTen, diaChi, uuTien)
    {
        Van = van;
        Su = su;
        Dia = dia;
    }

    public override double TinhDiem()
    {
        return Van + Su + Dia;
    }
}

public class TuyenSinh
{
    private List<ThiSinh> danhSachThiSinh;

    public TuyenSinh()
    {
        danhSachThiSinh = new List<ThiSinh>();
    }

    public void NhapThongTinThiSinh()
    {
        Console.WriteLine("Nhập thông tin thí sinh:");
        Console.Write("Chọn khối (A/B/C): ");
        string khoi = Console.ReadLine();
        Console.Write("Số báo danh: ");
        string soBaoDanh = Console.ReadLine();
        Console.Write("Họ tên: ");
        string hoTen = Console.ReadLine();
        Console.Write("Địa chỉ: ");
        string diaChi = Console.ReadLine();
        Console.Write("Ưu tiên: ");
        string uuTien = Console.ReadLine();

        if (khoi == "A")
        {
            Console.Write("Điểm Toán: ");
            double toan = double.Parse(Console.ReadLine());
            Console.Write("Điểm Lý: ");
            double ly = double.Parse(Console.ReadLine());
            Console.Write("Điểm Hóa: ");
            double hoa = double.Parse(Console.ReadLine());
            danhSachThiSinh.Add(new ThiSinhKhoiA(soBaoDanh, hoTen, diaChi, uuTien, toan, ly, hoa));
        }
        else if (khoi == "B")
        {
            Console.Write("Điểm Toán: ");
            double toan = double.Parse(Console.ReadLine());
            Console.Write("Điểm Hóa: ");
            double hoa = double.Parse(Console.ReadLine());
            Console.Write("Điểm Sinh: ");
            double sinh = double.Parse(Console.ReadLine());
            danhSachThiSinh.Add(new ThiSinhKhoiB(soBaoDanh, hoTen, diaChi, uuTien, toan, hoa, sinh));
        }
        else if (khoi == "C")
        {
            Console.Write("Điểm Văn: ");
            double van = double.Parse(Console.ReadLine());
            Console.Write("Điểm Sử: ");
            double su = double.Parse(Console.ReadLine());
            Console.Write("Điểm Địa: ");
            double dia = double.Parse(Console.ReadLine());
            danhSachThiSinh.Add(new ThiSinhKhoiC(soBaoDanh, hoTen, diaChi, uuTien, van, su, dia));
        }
        else
        {
            Console.WriteLine("Khối không hợp lệ!");
        }
    }

    public void HienThiThongTinTrungTuyen()
    {
        Console.WriteLine("\nDanh sách thí sinh trúng tuyển:");
        foreach (var thiSinh in danhSachThiSinh)
        {
            double diem = thiSinh.TinhDiem();
            if ((thiSinh is ThiSinhKhoiA && diem >= 15) ||
                (thiSinh is ThiSinhKhoiB && diem >= 16) ||
                (thiSinh is ThiSinhKhoiC && diem >= 13.5))
            {
                Console.WriteLine($"SBD: {thiSinh.SoBaoDanh}, Họ tên: {thiSinh.HoTen}, Điểm: {diem}");
            }
        }
    }

    public void TimKiemThiSinhTheoSBD(string soBaoDanh)
    {
        var thiSinh = danhSachThiSinh.Find(ts => ts.SoBaoDanh == soBaoDanh);
        if (thiSinh != null)
        {
            Console.WriteLine($"SBD: {thiSinh.SoBaoDanh}, Họ tên: {thiSinh.HoTen}, Địa chỉ: {thiSinh.DiaChi}, Ưu tiên: {thiSinh.UuTien}");
        }
        else
        {
            Console.WriteLine("Không tìm thấy thí sinh với SBD này.");
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        TuyenSinh tuyenSinh = new TuyenSinh();
        bool continueRunning = true;

        while (continueRunning)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Nhập thông tin thí sinh");
            Console.WriteLine("2. Hiển thị thí sinh trúng tuyển");
            Console.WriteLine("3. Tìm kiếm thí sinh theo số báo danh");
            Console.WriteLine("4. Kết thúc");
            Console.Write("Lựa chọn: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    tuyenSinh.NhapThongTinThiSinh();
                    break;
                case 2:
                    tuyenSinh.HienThiThongTinTrungTuyen();
                    break;
                case 3:
                    Console.Write("Nhập số báo danh cần tìm: ");
                    string sbd = Console.ReadLine();
                    tuyenSinh.TimKiemThiSinhTheoSBD(sbd);
                    break;
                case 4:
                    continueRunning = false;
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ.");
                    break;
            }
        }
    }
}

//Bài 1: Xây dựng chương trình tính tổng các phân số
//Gợi ý:
//-Tạo một lớp “PhanSo” có các thuộc tính là tử số và mẫu số
//- Viết phương thức nhập phân số
//- Viết hàm thực hiện cộng 2 phân số
//- Tạo List chỉ chứa các phân số. Tính tổng các phân số trong List
using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        List<PhanSo> danhSachPhanSo = new List<PhanSo>();

        Console.Write("Nhập số lượng phân số: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Nhập phân số thứ {i + 1}:");
            PhanSo ps = new PhanSo();
            ps.Nhap();
            danhSachPhanSo.Add(ps);
        }

        PhanSo tong = new PhanSo(0, 1);

        foreach (var ps in danhSachPhanSo)
        {
            tong = PhanSo.Cong(tong, ps);
        }

        Console.WriteLine("Tổng các phân số là:");
        tong.Xuat();

        Console.WriteLine("Nhấn phím bất kỳ để kết thúc...");
        Console.ReadKey();
    }
}


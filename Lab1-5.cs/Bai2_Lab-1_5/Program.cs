//   Bài 2 Xây dựng chương trình tính chu vi và diện tích hình tròn, vuông, tam giác, chữ nhật
//Gợi ý:
//-Tạo một lớp “Hinh” có phương thức ảo tính chu vi, diện tích
//- Tạo các lớp: “HinhTron”, “HinhVuong”, “HinhTamGiac”, “HinhChuNhat” kế thừa
//từ class “Hinh” và định nghĩa các hàm tính chu vi, diện tích
//- Tạo List chỉ các Hinh. Tính tổng chu vi và tổng diện tích các hình trong List
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        List<Hinh> danhSachHinh = new List<Hinh>();

        // Thêm ví dụ:
        danhSachHinh.Add(new HinhTron(5));
        danhSachHinh.Add(new HinhVuong(4));
        danhSachHinh.Add(new HinhChuNhat(3, 6));
        danhSachHinh.Add(new HinhTamGiac(3, 4, 5));

        double tongChuVi = 0;
        double tongDienTich = 0;

        foreach (var hinh in danhSachHinh)
        {
            tongChuVi += hinh.TinhChuVi();
            tongDienTich += hinh.TinhDienTich();
        }

        Console.WriteLine($"Tổng chu vi các hình: {tongChuVi:F2}");
        Console.WriteLine($"Tổng diện tích các hình: {tongDienTich:F2}");

        Console.ReadKey();
    }
}

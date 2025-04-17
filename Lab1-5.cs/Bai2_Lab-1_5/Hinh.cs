//Bài 2: Xây dựng chương trình tính chu vi và diện tích hình tròn, vuông, tam giác, chữ nhật
//Gợi ý:
//-Tạo một lớp “Hinh” có phương thức ảo tính chu vi, diện tích
//- Tạo các lớp: “HinhTron”, “HinhVuong”, “HinhTamGiac”, “HinhChuNhat” kế thừa
//từ class “Hinh” và định nghĩa các hàm tính chu vi, diện tích
//- Tạo List chỉ các Hinh. Tính tổng chu vi và tổng diện tích các hình trong List
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Hinh
{
    public abstract double TinhChuVi();
    public abstract double TinhDienTich();
}


public class HinhTron : Hinh
{
    public double BanKinh { get; set; }

    public HinhTron(double r)
    {
        BanKinh = r;
    }

    public override double TinhChuVi()
    {
        return 2 * Math.PI * BanKinh;
    }

    public override double TinhDienTich()
    {
        return Math.PI * BanKinh * BanKinh;
    }
}
public class HinhVuong : Hinh
{
    public double Canh { get; set; }

    public HinhVuong(double canh)
    {
        Canh = canh;
    }

    public override double TinhChuVi()
    {
        return 4 * Canh;
    }

    public override double TinhDienTich()
    {
        return Canh * Canh;
    }
}
public class HinhChuNhat : Hinh
{
    public double Dai { get; set; }
    public double Rong { get; set; }

    public HinhChuNhat(double dai, double rong)
    {
        Dai = dai;
        Rong = rong;
    }

    public override double TinhChuVi()
    {
        return 2 * (Dai + Rong);
    }

    public override double TinhDienTich()
    {
        return Dai * Rong;
    }
}


public class HinhTamGiac : Hinh
{
    public double A { get; set; }
    public double B { get; set; }
    public double C { get; set; }

    public HinhTamGiac(double a, double b, double c)
    {
        A = a; B = b; C = c;
    }

    public override double TinhChuVi()
    {
        return A + B + C;
    }

    public override double TinhDienTich()
    {
        double p = (A + B + C) / 2;
        return Math.Sqrt(p * (p - A) * (p - B) * (p - C)); // Công thức Heron
    }
}
    
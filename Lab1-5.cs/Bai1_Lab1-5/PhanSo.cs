//Bài 1: Xây dựng chương trình tính tổng các phân số
//Gợi ý:
//-Tạo một lớp “PhanSo” có các thuộc tính là tử số và mẫu số
//- Viết phương thức nhập phân số
//- Viết hàm thực hiện cộng 2 phân số
//- Tạo List chỉ chứa các phân số. Tính tổng các phân số trong List
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

public class PhanSo
{
    public int TuSo { get; set; }
    public int MauSo { get; set; }

    public PhanSo()
    {
        TuSo = 0;
        MauSo = 1;
    }

    public PhanSo(int tu, int mau)
    {
        TuSo = tu;
        MauSo = mau == 0 ? 1 : mau; // Tránh mẫu = 0
        RutGon();
    }

    public void Nhap()
    {
        Console.Write("- Nhập tử số: ");
        TuSo = int.Parse(Console.ReadLine());

        do
        {
            Console.Write("- Nhập mẫu số (khác 0): ");
            MauSo = int.Parse(Console.ReadLine());
        } while (MauSo == 0);

        RutGon();
    }

    public void Xuat()
    {
        Console.WriteLine($"{TuSo}/{MauSo}");
    }

    public static PhanSo Cong(PhanSo a, PhanSo b)
    {
        int tuMoi = a.TuSo * b.MauSo + b.TuSo * a.MauSo;
        int mauMoi = a.MauSo * b.MauSo;
        return new PhanSo(tuMoi, mauMoi);
    }

    private int UCLN(int a, int b)
    {
        a = Math.Abs(a);
        b = Math.Abs(b);
        while (b != 0)
        {
            int r = a % b;
            a = b;
            b = r;
        }
        return a;
    }

    private void RutGon()
    {
        int ucln = UCLN(TuSo, MauSo);
        TuSo /= ucln;
        MauSo /= ucln;
        if (MauSo < 0)
        {
            TuSo = -TuSo;
            MauSo = -MauSo;
        }
    }
}


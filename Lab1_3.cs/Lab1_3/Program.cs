using System;

namespace BaiTap1
{
    class Program
    {
        public static void NhapPhanSo(PhanSo phanSo1, PhanSo phanSo2)
        {
            Console.WriteLine("Phân số 1: ");
            phanSo1.Nhap();
            Console.WriteLine("Phân số 2: ");
            phanSo2.Nhap();
        }

        static void Main(string[] args)
        {
            PhanSo ps1 = new PhanSo();
            PhanSo ps2 = new PhanSo();
            PhanSo ps3 = new PhanSo();
            int x;

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Các phép toán với phân số:");
            Console.WriteLine("\t1. Nhập 1 nếu muốn cộng");
            Console.WriteLine("\t2. Nhập 2 nếu muốn trừ");
            Console.WriteLine("\t3. Nhập 3 nếu muốn nhân");
            Console.WriteLine("\t4. Nhập 4 nếu muốn chia");
            Console.WriteLine("\t5. Nhập 5 nếu muốn tối giản");
            Console.Write("- Mời bạn nhập lựa chọn: ");
            x = int.Parse(Console.ReadLine());

            switch (x)
            {
                case 1:
                    NhapPhanSo(ps1, ps2);
                    ps3 = ps1 + ps2;
                    Console.WriteLine($"Kết quả: {ps1.TuSo}/{ps1.MauSo} + {ps2.TuSo}/{ps2.MauSo} = {ps3.TuSo}/{ps3.MauSo}");
                    break;

                case 2:
                    NhapPhanSo(ps1, ps2);
                    ps3 = ps1 - ps2;
                    Console.WriteLine($"Kết quả: {ps1.TuSo}/{ps1.MauSo} - {ps2.TuSo}/{ps2.MauSo} = {ps3.TuSo}/{ps3.MauSo}");
                    break;

                case 3:
                    NhapPhanSo(ps1, ps2);
                    ps3 = ps1 * ps2;
                    Console.WriteLine($"Kết quả: {ps1.TuSo}/{ps1.MauSo} * {ps2.TuSo}/{ps2.MauSo} = {ps3.TuSo}/{ps3.MauSo}");
                    break;

                case 4:
                    NhapPhanSo(ps1, ps2);
                    ps3 = ps1 / ps2;
                    Console.WriteLine($"Kết quả: {ps1.TuSo}/{ps1.MauSo} / {ps2.TuSo}/{ps2.MauSo} = {ps3.TuSo}/{ps3.MauSo}");
                    break;

                case 5:
                    Console.WriteLine("Nhập phân số muốn tối giản:");
                    ps1.Nhap();
                    if (ps1.KiemTra())
                    {
                        Console.WriteLine("Phân số đã tối giản.");
                    }
                    else
                    {
                        ps1.ToiGian();
                        Console.WriteLine($"Sau khi tối giản: {ps1.TuSo}/{ps1.MauSo}");
                    }
                    break;

                default:
                    Console.WriteLine("Bạn đã nhập sai lựa chọn!");
                    break;
            }
        }
    }
}

/*
  Bài 5: Viết chương trình tính tổng và tích của hai số nhập từ bàn phím.
 */
using System;
using System.Text;

namespace BAI5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập số thứ nhất: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Nhập số thứ hai: ");
            double b = double.Parse(Console.ReadLine());

            double tong = a + b;
            double tich = a * b;

            Console.WriteLine($"Tổng: {tong}");
            Console.WriteLine($"Tích: {tich}");
        }
    }
}

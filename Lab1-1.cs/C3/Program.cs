/*Bài 3: Viết chương trình chuyển đổi nhiệt độ từ độ C sang độ F
Công thức: F = (C * 9/5) + 32*/
using System;
using System.Text;

namespace BAI3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập nhiệt độ (°C): ");
            double doC = double.Parse(Console.ReadLine());

            double doF = (doC * 9 / 5) + 32;

            Console.WriteLine($"{doC}°C = {doF}°F");
        }
    }
}

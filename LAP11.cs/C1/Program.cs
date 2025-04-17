
/*
 Bài 1: Viết chương trình nhập vào tên và tuổi, sau đó in ra màn hình thông báo "Xin chào
[tên], bạn [tuổi] tuổi!".
 */
using System;
using System.Text;

namespace BAI1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Đảm bảo hiển thị tiếng Việt
            Console.OutputEncoding = Encoding.UTF8;

            // Nhập tên và tuổi
            Console.Write("Nhập tên của bạn: ");
            string ten = Console.ReadLine();

            Console.Write("Nhập tuổi của bạn: ");
            int tuoi = int.Parse(Console.ReadLine());

            // In lời chào
            Console.WriteLine($"Xin chào {ten}, bạn {tuoi} tuổi!");
        }
    }
}


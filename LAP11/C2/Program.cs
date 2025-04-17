/*Bài 2: Viết chương trình tính diện tích của hình chữ nhật khi người dùng nhập chiều dài và
chiều rộng.*/
using System;
using System.Text;

namespace BAI2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Đảm bảo hiển thị tiếng Việt
            Console.OutputEncoding = Encoding.UTF8;

            // Nhập chiều dài và chiều rộng
            Console.Write("Nhập chiều dài: ");
            double chieuDai = double.Parse(Console.ReadLine());

            Console.Write("Nhập chiều rộng: ");
            double chieuRong = double.Parse(Console.ReadLine());

            // Tính diện tích
            double dienTich = chieuDai * chieuRong;

            // Hiển thị kết quả
            Console.WriteLine($"Diện tích hình chữ nhật là: {dienTich}");
        }
    }
}


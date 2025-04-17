/*
 Bài 4: Viết chương trình nhập vào một số nguyên và kiểm tra xem số đó có phải là số chẵn
hay không.

 */
using System;
using System.Text;

namespace BAI4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập một số nguyên: ");
            int so = int.Parse(Console.ReadLine());

            if (so % 2 == 0)
                Console.WriteLine($"{so} là số chẵn.");
            else
                Console.WriteLine($"{so} là số lẻ.");
        }
    }
}

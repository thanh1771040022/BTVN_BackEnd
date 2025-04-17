/*
 * Bài 7: Viết chương trình kiểm tra xem một năm nhập vào có phải là năm nhuận hay không.
(Năm nhuận là năm chia hết cho 4, trừ các năm chia hết cho 100 nhưng không chia hết cho
400).
 */
using System;
using System.Text;

namespace BAI7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập một năm: ");
            int nam = int.Parse(Console.ReadLine());

            if ((nam % 4 == 0 && nam % 100 != 0) || (nam % 400 == 0))
                Console.WriteLine($"{nam} là năm nhuận.");
            else
                Console.WriteLine($"{nam} không phải là năm nhuận.");
        }
    }
}

/*Bài 9: Viết chương trình tính giai thừa của một số nguyên dương n.
*/
using System;
using System.Text;

namespace BAI9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập số nguyên dương n: ");
            int n = int.Parse(Console.ReadLine());

            long giaiThua = 1;

            for (int i = 1; i <= n; i++)
            {
                giaiThua *= i;
            }

            Console.WriteLine($"{n}! = {giaiThua}");
        }
    }
}

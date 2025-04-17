/*Bài 6: Viết chương trình kiểm tra xem một số nhập vào có phải là số dương, số âm hay số
không*/
using System;
using System.Text;

namespace BAI6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập một số: ");
            double so = double.Parse(Console.ReadLine());

            if (so > 0)
                Console.WriteLine("Đây là số dương.");
            else if (so < 0)
                Console.WriteLine("Đây là số âm.");
            else
                Console.WriteLine("Đây là số 0.");
        }
    }
}

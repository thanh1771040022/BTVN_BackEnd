/*Bài 4: Để quản lý các hộ dân trong một khu phố, người ta quản lý các thông tin như sau:
- Với mỗi hộ dân, có các thuộc tính:
+ Số thành viên trong hộ (số người)
+ Số nhà của hộ dân đó (số nhà được gắn cho mỗi hộ dân)
+ Thông tin về mỗi cá nhân trong hộ gia đình.
- Với mỗi cá nhân, người ta quản lý các thông tin như: số chứng minh nhân dân, họ và
tên, tuổi, năm sinh, nghề nghiệp.
1. Hãy xây dựng lớp Nguoi để quản lý thông tin về mỗi cá nhân.
2. Xây dựng lớp KhuPho để quản lý thông tin về các hộ gia đình.
3. Viết các phương thức nhập, hiển thị thông tin cho mỗi hộ gia đình.
4. Cài đặt chương trình thực hiện các công việc sau:
- Nhập vào một dãy gồm n hộ dân (n - nhập từ bàn phím).
- Tìm kiếm thông tin về hộ dân theo họ tên hoặc theo số nhà
- Hiển thị thông tin cho toàn bộ các hộ dân trong khu phố.
- Thoát khỏi chương trình.
*/
using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        List<KhuPho> khuPho = new List<KhuPho>();
        bool continueRunning = true;

        while (continueRunning)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Nhập thông tin hộ dân");
            Console.WriteLine("2. Tìm kiếm hộ dân theo họ tên hoặc số nhà");
            Console.WriteLine("3. Hiển thị thông tin toàn bộ hộ dân");
            Console.WriteLine("4. Thoát");
            Console.Write("Lựa chọn: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    // Nhập thông tin n hộ dân
                    Console.Write("Nhập số lượng hộ dân: ");
                    int n = int.Parse(Console.ReadLine());
                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine($"Nhập thông tin hộ dân thứ {i + 1}:");
                        Console.Write("Số nhà: ");
                        int soNha = int.Parse(Console.ReadLine());
                        KhuPho khu = new KhuPho(soNha);
                        khu.NhapThongTinHokinhDoanh();
                        khuPho.Add(khu);
                    }
                    break;

                case 2:
                    // Tìm kiếm thông tin hộ dân theo số nhà hoặc họ tên
                    Console.Write("Tìm kiếm theo (1) số nhà (2) họ tên: ");
                    int searchOption = int.Parse(Console.ReadLine());
                    if (searchOption == 1)
                    {
                        Console.Write("Nhập số nhà cần tìm: ");
                        int searchSoNha = int.Parse(Console.ReadLine());
                        var foundHouse = khuPho.Find(kp => kp.SoNha == searchSoNha);
                        if (foundHouse != null)
                        {
                            foundHouse.HienThiThongTinHokinhDoanh();
                        }
                        else
                        {
                            Console.WriteLine("Không tìm thấy hộ dân với số nhà này.");
                        }
                    }
                    else if (searchOption == 2)
                    {
                        Console.Write("Nhập họ tên cần tìm: ");
                        string searchHoTen = Console.ReadLine();
                        bool found = false;
                        foreach (var khu in khuPho)
                        {
                            foreach (var nguoi in khu.DanhSachNguoi)
                            {
                                if (nguoi.HoTen.ToLower().Contains(searchHoTen.ToLower()))
                                {
                                    nguoi.HienThiThongTin();
                                    found = true;
                                }
                            }
                        }
                        if (!found)
                        {
                            Console.WriteLine("Không tìm thấy người với họ tên này.");
                        }
                    }
                    break;

                case 3:
                    // Hiển thị thông tin toàn bộ hộ dân
                    Console.WriteLine("Thông tin toàn bộ các hộ dân:");
                    foreach (var khu in khuPho)
                    {
                        khu.HienThiThongTinHokinhDoanh();
                    }
                    break;

                case 4:
                    // Thoát chương trình
                    continueRunning = false;
                    break;

                default:
                    Console.WriteLine("Lựa chọn không hợp lệ.");
                    break;
            }
        }
    }
}


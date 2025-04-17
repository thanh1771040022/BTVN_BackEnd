/*
 * Bài 2: Một thư viện cần quản lý các tài liệu bao gồm, Sách, Tạp chí, Báo
+ Mỗi tài liệu có các thuộc tính: Mã tài liệu, Tên nhà xuất bản, Số bản phát hành.
+ Các loại sách cần quản lý: Tên tác giả, số trang
+ Các tạp chí cần quản lý: Số phát hành, tháng phát hành
+ Các báo cần quản lý: ngày phát hành.
1. Xây dựng các lớp để quản lý các loại tài liệu trên sao cho việc sử dụng lại được nhiều nhất.
2. Xây dựng lớp QuanLyTailieu cài đặt các phương thức thực hiện các công việc sau:
- Nhập thông tin về các tài liệu (Hỏi người dùng muốn nhập thông tin cho loại tài liệu
nào: Sách, Tạp chí hay Báo và nhập đúng thông tin cho loại tài liệu đó).
- Hiển thị thông tin về các tài liệu
- Tìm kiếm tài liệu theo loại
- Thoát khỏi chương trình
 */
using System;

namespace QuanLyThuVien
{
    class Program
    {
        static void Main(string[] args)
        {
            QuanLyTaiLieu ql = new QuanLyTaiLieu();
            int chon;

            do
            {
                Console.WriteLine("\n==== MENU ====");
                Console.WriteLine("1. Nhập tài liệu mới");
                Console.WriteLine("2. Hiển thị danh sách tài liệu");
                Console.WriteLine("3. Tìm kiếm theo loại tài liệu");
                Console.WriteLine("4. Thoát");
                Console.Write("Chọn chức năng: ");
                chon = int.Parse(Console.ReadLine());

                switch (chon)
                {
                    case 1: ql.ThemTaiLieu(); break;
                    case 2: ql.HienThi(); break;
                    case 3: ql.TimTheoLoai(); break;
                    case 4: Console.WriteLine("Tạm biệt anh Thành đẹp zai 😎!"); break;
                    default: Console.WriteLine("Lựa chọn không hợp lệ."); break;
                }

            } while (chon != 4);
        }
    }
}

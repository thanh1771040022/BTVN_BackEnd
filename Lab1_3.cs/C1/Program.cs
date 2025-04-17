/*Bài 1: Một đơn vị sản xuất gồm có các cán bộ là công nhân, kỹ sư, nhân viên.
+ Mỗi cán bộ cần quản lý các thuộc tính: Họ tên, năm sinh, giới tính, địa chỉ
+ Các công nhân cần quản lý: Bậc (công nhân bậc 3/7, bậc 4/7 ...)
+ Các kỹ sư cần quản lý: Ngành đào tạo
+ Các nhân viên phục vụ cần quản lý thông tin: công việc
1. Xây dựng các lớp NhanVien, CongNhan, KySu kế thừa từ lớp CanBo
2. Xây dựng các phương thức nhập, hiển thị thông tin và kiểm tra về các thuộc tính của các
lớp.
3. Xây dựng lớp QLCB cài đặt các phương thức thực hiện các chức sau:
- Nhập thông tin mới cho cán bộ (Hỏi người dùng muốn nhập cho: công nhân, kỹ sư
hay nhân viên và nhập đúng thông tin cho đối tượng đó).
- Tìm kiếm theo họ tên
- Hiển thị thông tin về danh sách các cán bộ
- Thoát khỏi chương trình.*/
using System;

namespace QLCB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            QLCB ql = new QLCB();
            int chon;

            do
            {
                Console.WriteLine("===== QUẢN LÝ CÁN BỘ =====");
                Console.WriteLine("1. Nhập thông tin cán bộ mới");
                Console.WriteLine("2. Tìm kiếm cán bộ theo họ tên");
                Console.WriteLine("3. Hiển thị tất cả cán bộ");
                Console.WriteLine("4. Thoát");
                Console.Write("Mời chọn chức năng: ");
                chon = int.Parse(Console.ReadLine());

                switch (chon)
                {
                    case 1:
                        ql.NhapCanBoMoi();
                        break;
                    case 2:
                        ql.TimKiemTheoTen();
                        break;
                    case 3:
                        ql.HienThiTatCa();
                        break;
                    case 4:
                        Console.WriteLine("Thoát chương trình...");
                        break;
                    default:
                        Console.WriteLine("Chức năng không hợp lệ!");
                        break;
                }

                Console.WriteLine();
            } while (chon != 4);
        }
    }
}

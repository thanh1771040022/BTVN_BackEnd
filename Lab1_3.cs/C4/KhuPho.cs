using System;
using System.Collections.Generic;

public class KhuPho
{
    public int SoNha { get; set; }
    public List<Nguoi> DanhSachNguoi { get; set; }

    public KhuPho(int soNha)
    {
        SoNha = soNha;
        DanhSachNguoi = new List<Nguoi>();
    }

    public void NhapThongTinHokinhDoanh()
    {
        Console.WriteLine("Nhập số thành viên trong hộ: ");
        int soThanhVien = int.Parse(Console.ReadLine());

        for (int i = 0; i < soThanhVien; i++)
        {
            Console.WriteLine($"Nhập thông tin thành viên thứ {i + 1}:");
            Console.Write("Số CMND: ");
            string soCMND = Console.ReadLine();
            Console.Write("Họ và tên: ");
            string hoTen = Console.ReadLine();
            Console.Write("Tuổi: ");
            int tuoi = int.Parse(Console.ReadLine());
            Console.Write("Năm sinh: ");
            int namSinh = int.Parse(Console.ReadLine());
            Console.Write("Nghề nghiệp: ");
            string ngheNghiep = Console.ReadLine();

            Nguoi nguoi = new Nguoi(soCMND, hoTen, tuoi, namSinh, ngheNghiep);
            DanhSachNguoi.Add(nguoi);
        }
    }

    public void HienThiThongTinHokinhDoanh()
    {
        Console.WriteLine($"Thông tin hộ dân số nhà {SoNha}:");
        foreach (var nguoi in DanhSachNguoi)
        {
            nguoi.HienThiThongTin();
        }
    }
}

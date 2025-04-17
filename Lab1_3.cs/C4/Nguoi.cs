﻿public class Nguoi
{
    public string SoCMND { get; set; }
    public string HoTen { get; set; }
    public int Tuoi { get; set; }
    public int NamSinh { get; set; }
    public string NgheNghiep { get; set; }

    public Nguoi(string soCMND, string hoTen, int tuoi, int namSinh, string ngheNghiep)
    {
        SoCMND = soCMND;
        HoTen = hoTen;
        Tuoi = tuoi;
        NamSinh = namSinh;
        NgheNghiep = ngheNghiep;
    }

    public void HienThiThongTin()
    {
        Console.WriteLine($"CMND: {SoCMND}, Họ tên: {HoTen}, Tuổi: {Tuoi}, Năm sinh: {NamSinh}, Nghề nghiệp: {NgheNghiep}");
    }
}
